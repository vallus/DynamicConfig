namespace Entities
{
    /// <summary>
    /// The class that defines user specific configuration
    /// </summary>
    public class ConfigurationUser : ConfigurationBase
    {
        #region Constructor
        /// <summary>
        /// The constructor used to instaintiate user specific configuration
        /// </summary>
        /// <param name="userId">The database id of the user</param>
        /// <param name="userSettings">The settings contanier holding the user specific settings</param>
        public ConfigurationUser(long userId, SettingContainer userSettings)
        {
            UserId = userId;
            UserSettings = userSettings;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The database id of the user the settings apply to
        /// </summary>
        public long UserId
        {
            get;
            private set;
        }

        /// <summary>
        /// The container holding all of the users settings
        /// </summary>
        public SettingContainer UserSettings
        {
            get;
            private set;
        }
        #endregion
    }
}
