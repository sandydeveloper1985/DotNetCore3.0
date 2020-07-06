using System;
using System.Collections.Generic;
using System.Text;

namespace SaiDhamEntity.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISubMenu : ILog
    {
        #region ISubMenu
        /// <summary>
        /// 
        /// </summary>
        public string SubMenuId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SubMenuName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SubMenuDescription { get; set; }

        /// <summary>
        /// Get  MenuDetails
        /// </summary>
        public List<IMenu> MenuDetails { get; }
        #endregion
    }
}
