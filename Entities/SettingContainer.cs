using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Entities
{
    /// <summary>
    /// This class defines the container all settings are held in
    /// </summary>
    public sealed class SettingContainer
    {
        #region Constructor
        /// <summary>
        /// The constructor used to create a new setting container without adding settings to the collection
        /// </summary>
        /// <param name="containerId">The database id for this setting container</param>
        /// <param name="containerName">The name of the setting container</param>
        public SettingContainer(long containerId, string containerName)
        {
            ContainerId = containerId;
            ContainerName = containerName;
            Settings = new Collection<Setting>();
        }

        /// <summary>
        /// The constructor used to create a new setting container with settings
        /// </summary>
        /// <param name="containerId">The database id for this setting container</param>
        /// <param name="containerName">The name of the setting container</param>
        /// <param name="settings">The collection of settings for this container</param>
        public SettingContainer(long containerId, string containerName, ICollection<Setting> settings )
        {
            ContainerId = containerId;
            ContainerName = containerName;
            Settings = settings;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The database id for this setting container
        /// </summary>
        public long ContainerId
        {
            get;
            private set;
        }

        /// <summary>
        /// The name of the setting container
        /// </summary>
        public string ContainerName
        {
            get;
            private set;
        }

        /// <summary>
        /// The collection of setting objects for this container
        /// </summary>
        public ICollection<Setting> Settings
        {
            get;
            private set;
        }
        #endregion
    }
}
