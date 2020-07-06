using System.Collections.Generic;

namespace SaiDhamEntity.Entity
{
    /// <summary>
    /// Interface of IUser Details
    /// </summary>
    public interface IUser : ILog
    {
        #region [IUser]
        /// <summary>
        /// Get or Set UserId
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Get or Set UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Get or Set UserDetails
        /// </summary>
        public string UserDetails { get; set; }

        /// <summary>
        /// Get ClientDetails
        /// </summary>
        public List<IClient> client { get; }
        #endregion
    }
}
