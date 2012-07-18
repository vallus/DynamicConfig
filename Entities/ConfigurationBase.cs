using System;

namespace Entities
{
    /// <summary>
    /// The abstract class that defines the common properties shared by all configurations
    /// </summary>
    public abstract class ConfigurationBase
    {
        #region Properties
        /// <summary>
        /// The database id for the application this configuration applies to
        /// </summary>
        public long AplicationId
        {
            get;
            set;
        }

        /// <summary>
        /// The database id for the client this configuration applies to
        /// </summary>
        public long ClientId
        {
            get;
            set;
        }

        /// <summary>
        /// The UTC date and time this configuration expires
        /// </summary>
        /// <remarks>It is important for compatiblity reasons the expiration date and time be expressed in universal time (UTC)</remarks>
        public DateTime Expiration
        {
            get;
            set;
        }
        #endregion
    }
}
