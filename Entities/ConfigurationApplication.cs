namespace Entities
{
    /// <summary>
    /// The class that defines application specific configuration
    /// </summary>
    public class ConfigurationApplication : ConfigurationBase
    {
        #region Constructor
        /// <summary>
        /// The constructor used to instaintiate application specific configuration
        /// </summary>
        /// <param name="applicationSettings">The settings contanier holding application specific settings</param>
        public ConfigurationApplication(SettingContainer applicationSettings)
        {
            ApplicationSettings = applicationSettings;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The container holding all of the users settings
        /// </summary>
        public SettingContainer ApplicationSettings
        {
            get;
            private set;
        }
        #endregion
    }
}
