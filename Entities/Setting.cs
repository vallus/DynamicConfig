namespace Entities
{
    /// <summary>
    /// This is the class that defines what a setting looks like
    /// </summary>
    public sealed class Setting
    {
        #region Constructor
        /// <summary>
        /// This is the constructor used to build the setting object
        /// </summary>
        /// <param name="settingId">The database id of the setting</param>
        /// <param name="settingName">The name of the setting</param>
        /// <param name="settingValue">The value of the setting</param>
        public Setting(long settingId, string settingName, string settingValue)
        {
            SettingId = settingId;
            SettingName = settingName;
            SettingValue = settingValue;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The database id of the setting
        /// </summary>
        public long SettingId
        {
            get;
            private set;
        }

        /// <summary>
        /// The name of the setting
        /// </summary>
        public string SettingName
        {
            get;
            private set;
        }

        /// <summary>
        /// The value of the setting
        /// </summary>
        public string SettingValue
        {
            get;
            private set;
        }
        #endregion
    }
}
