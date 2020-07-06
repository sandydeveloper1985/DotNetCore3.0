namespace SaiDhamEntity.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMenu : ILog
    {
        #region [IMenu]
        /// <summary>
        /// Get or Set MenuId
        /// </summary>
        public int MenuId { get; set; }

        /// <summary>
        /// Get or Set MenuName
        /// </summary>
        public string MenuName { get; set; }

        /// <summary>
        /// Get or Set Menu Description
        /// </summary>
        public string MenuDescription { get; set; }
        #endregion
    }
}
