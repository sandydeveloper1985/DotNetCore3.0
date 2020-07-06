using System.Collections.Generic;

namespace SaiDhamEntity.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRole : ILog
    {
        #region [IRole]
        /// <summary>
        /// Get or Set RoleId
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Get or Set RoleName
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// Get or Set RoleDetails
        /// </summary>
        public string RoleDetails { get; set; }

        /// <summary>
        /// Get ClientDetails
        /// </summary>
        public List<IClient> client { get; }

        /// <summary>
        /// Get UserDetails
        /// </summary>
        public List<IUser> user { get; }
        #endregion
    }
}
