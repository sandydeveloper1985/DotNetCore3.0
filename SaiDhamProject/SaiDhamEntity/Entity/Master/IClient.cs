namespace SaiDhamEntity.Entity
{
    /// <summary>
    /// Interface of Client Details
    /// </summary>
    public interface IClient: ILog
    {
        #region [IClient]

        /// <summary>
        /// Get or Set ClientId
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Get or Set the ClientName
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// Get or Set the Client Description
        /// </summary>
        public string ClientDescription { get; set; }

        /// <summary>
        /// Get or Set the Client Logo
        /// </summary>
        public string ClientLogo { get; set; }

        #endregion
    }
}
