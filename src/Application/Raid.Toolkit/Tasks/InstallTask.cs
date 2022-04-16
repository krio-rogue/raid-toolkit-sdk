using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;
using Raid.Toolkit.Extensibility;
using Raid.Toolkit.Extensibility.Host;
using Raid.Toolkit.UI;

namespace Raid.Toolkit
{
    [Verb("install", HelpText = "Installs an extension")]
    internal class InstallOptions
    {
        [Value(0, MetaName = "rtkx", HelpText = "Path to RTKX package to install")]
        public string? PackagePath { get; set; }
    }

    internal class InstallTask : CommandTaskBase<InstallOptions>
    {
        private InstallOptions? Options;
        private readonly IPackageManager PackageManager;
        private readonly IServiceProvider ServiceProvider;

        public InstallTask(IServiceProvider serviceProvider, IPackageManager packageManager)
        {
            ServiceProvider = serviceProvider;
            PackageManager = packageManager;
        }

        public override Task<int> Invoke()
        {
            if (Options == null)
                throw new NullReferenceException();

            ExtensionBundle bundleToInstall = ExtensionBundle.FromFile(Options.PackagePath);
            using InstallExtensionDialog dlg = ActivatorUtilities.CreateInstance<InstallExtensionDialog>(ServiceProvider, bundleToInstall);
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return Task.FromResult(10);
            }

            _ = PackageManager.AddPackage(bundleToInstall);

            return Task.FromResult(0);
        }

        public override ApplicationStartupCondition Parse(InstallOptions options)
        {
            Options = options;
            ApplicationHost.Enabled = false;
            return ApplicationStartupCondition.Services;
        }
    }
}
