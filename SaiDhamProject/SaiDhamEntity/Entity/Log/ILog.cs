using System;
using System.Collections.Generic;
using System.Text;

namespace SaiDhamEntity.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILog
    {
        /// <summary>
        /// Get or Set LogId
        /// </summary>
        public int LogId { get; set; }

        /// <summary>
        /// Get or Set IPaddress
        /// </summary>
        public string IPaddress { get; set; }

        /// <summary>
        /// Get or Set OSName
        /// </summary>
        public string OSName { get; set; }

        /// <summary>
        /// Get or Set OSVersion
        /// </summary>
        public string OSVersion { get; set; }

        /// <summary>
        /// Get or Set BrowserName
        /// </summary>
        public string BrowserName { get; set; }

        /// <summary>
        /// Get or Set Intime
        /// </summary>
        public DateTime Intime { get; set; }

        /// <summary>
        /// Get or Set Outime
        /// </summary>
        public DateTime OutTime { get; set; }
    }
}
