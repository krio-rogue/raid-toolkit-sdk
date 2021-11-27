using System;
using System.Collections.Generic;
using System.Linq;
using Raid.DataModel;

namespace Raid.Service
{
    [Facet("artifacts")]
    public class ArtifactsFacet : UserAccountFacetBase<IReadOnlyDictionary<int, Artifact>, ArtifactsFacet>
    {
        private const int kForceRefreshInterval = 30000;
        private DateTime m_nextForcedRefresh = DateTime.MinValue;
        private int m_nextId;
        private int m_nextRevisionId;

        protected override IReadOnlyDictionary<int, Artifact> Merge(ModelScope scope, IReadOnlyDictionary<int, Artifact> previous = null)
        {
            var artifactData = scope.AppModel._userWrapper.Artifacts.ArtifactData;

            IReadOnlyList<Artifact> artifacts;

            // Only refresh if lastHeroId changed since last read, or after we've exceeded the forced read interval
            if (previous != null && DateTime.UtcNow < m_nextForcedRefresh
                && artifactData.NextArtifactId == m_nextId
                && artifactData.NextArtifactRevisionId == m_nextRevisionId)
            {
                artifacts = previous.Values.ToList();
            }
            else
            {
                artifacts = GetArtifacts(scope);
                m_nextForcedRefresh = DateTime.UtcNow.AddMilliseconds(kForceRefreshInterval);
                m_nextId = artifactData.NextArtifactId;
                m_nextRevisionId = artifactData.NextArtifactRevisionId;
            }

            Dictionary<int, Artifact> result = new();

            var updatedArtifacts = artifactData.UpdatedArtifacts;
            var deletedArtifacts = artifactData.DeletedArtifactIds;

            foreach (var artifactEntry in artifacts)
            {
                if (artifactEntry == null) continue;
                if (deletedArtifacts.Contains(artifactEntry.Id)) continue;

                if (updatedArtifacts.TryGetValue(artifactEntry.Id, out var artifact))
                {
                    result.Add(artifactEntry.Id, artifact.ToModel());
                }
                else
                {
                    result.Add(artifactEntry.Id, artifactEntry);
                }

            }
            return result;
        }

        private static IReadOnlyList<Artifact> GetArtifacts(ModelScope scope)
        {
            Client.Model.Guard.UserWrapper userWrapper = scope.AppModel._userWrapper;
            var artifactStorageResolver = SharedModel.Meta.Artifacts.ArtifactStorage.ArtifactStorageResolver.GetInstance(scope.Context);
            if (userWrapper.Artifacts.ArtifactData.StorageMigrationState == SharedModel.Meta.Artifacts.ArtifactStorage.ArtifactStorageMigrationState.Migrated)
            {
                var storage = artifactStorageResolver._implementation as Client.Model.Gameplay.Artifacts.ExternalArtifactsStorage;
                return storage._state._artifacts.Values.Select(ModelExtensions.ToModel).ToList();
            }
            return userWrapper.Artifacts.ArtifactData.Artifacts.Select(ModelExtensions.ToModel).ToList();
        }
    }
}