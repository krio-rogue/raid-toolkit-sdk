using Microsoft.Extensions.DependencyInjection;
using Raid.Toolkit.Extensibility.Providers;
using Raid.Toolkit.Extensibility.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Raid.Toolkit.Extensibility.Host
{
    public class ExtensionHost : IExtensionHostController, IDisposable
    {
        private readonly IModelLoader ModelLoader;
        private readonly IPackageLoader PackageLoader;
        private readonly IPackageManager Locator;
        private readonly IServiceProvider ServiceProvider;
        private readonly IScopedServiceManager ScopedServices;
        private readonly IServiceManager ServiceManager;
        private readonly IContextDataManager DataManager;
        private readonly Dictionary<string, IExtensionPackage> ExtensionPackages = new();
        private readonly Dictionary<Type, IDisposable> Instances = new();
        private bool IsDisposed;

        public ExtensionHost(
            IPackageManager locator,
            IPackageLoader loader,
            IScopedServiceManager scopedServices,
            IContextDataManager dataManager,
            IModelLoader modelLoader,
            IServiceManager serviceManager,
            IServiceProvider serviceProvider
            )
        {
            Locator = locator;
            PackageLoader = loader;
            ScopedServices = scopedServices;
            DataManager = dataManager;
            ModelLoader = modelLoader;
            ServiceManager = serviceManager;
            ServiceProvider = serviceProvider;
        }


        #region IExtensionHost
        public T CreateInstance<T>() where T : IDisposable
        {
            IServiceProvider scope = ServiceProvider.CreateScope().ServiceProvider;
            T instance = ActivatorUtilities.CreateInstance<T>(scope);
            Instances.TryAdd(typeof(T), instance);
            return instance;
        }

        public T GetInstance<T>() where T : IDisposable
        {
            return (T)Instances[typeof(T)];
        }

        public IDisposable RegisterMessageScopeHandler<T>() where T : IMessageScopeHandler
        {
            IServiceProvider scope = ServiceProvider.CreateScope().ServiceProvider;
            T instance = ActivatorUtilities.CreateInstance<T>(scope);
            ScopedServices.AddMessageScopeHandler(instance);
            return new HostResourceHandle(() => ScopedServices.RemoveMessageScopeHandler(instance));
        }

        public IDisposable RegisterDataProvider<T>() where T : IDataProvider
        {
            return DataManager.AddProvider<T>();
        }

        public IDisposable RegisterBackgroundService<T>() where T : IBackgroundService
        {
            IServiceProvider scope = ServiceProvider.CreateScope().ServiceProvider;
            T instance = ActivatorUtilities.CreateInstance<T>(scope);
            return ServiceManager.AddService(instance);
        }
        #endregion

        #region IExtensionHostController
        public async Task LoadExtensions()
        {
            foreach (var pkg in Locator.GetAllPackages())
                ExtensionPackages.Add(pkg.Id, PackageLoader.LoadPackage(pkg));

            var typePatterns = ExtensionPackages.Values.OfType<IRequireCodegen>().SelectMany(cg => cg.TypeFilter.IncludeTypes);
            await Task.Run(() => ModelLoader.BuildAndLoad(typePatterns, false));
        }

        public void ActivateExtensions()
        {
            foreach (var pkg in ExtensionPackages.Values)
                pkg.OnActivate(this);
        }

        public void DeactivateExtensions()
        {
            foreach (var pkg in ExtensionPackages.Values)
                pkg.OnDeactivate(this);

            ExtensionPackages.Clear();
            Instances.Clear();
        }

        public void InstallPackage(PackageDescriptor pkgToInstall, bool activate)
        {
            PackageDescriptor installedPkg = Locator.AddPackage(pkgToInstall);
            var pkg = PackageLoader.LoadPackage(installedPkg);
            pkg.OnInstall(this);
            ExtensionPackages.Add(installedPkg.Id, pkg);
        }

        public void UninstallPackage(PackageDescriptor descriptor)
        {
            if (ExtensionPackages.Remove(descriptor.Id, out var pkg))
            {
                pkg.OnDeactivate(this);
                pkg.OnUninstall(this);
            }
        }
        #endregion

        #region IDisposable
        protected virtual void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects)
                    DeactivateExtensions();
                }

                IsDisposed = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}