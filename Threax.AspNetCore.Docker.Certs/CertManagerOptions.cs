using System;
using System.Collections.Generic;
using System.Text;

namespace Threax.AspNetCore.Docker.Certs
{
    /// <summary>
    /// Options for the system certficiate manager.
    /// </summary>
    public class CertManagerOptions
    {
        /// <summary>
        /// Set this to true (default) to load the certificates using Process.Start with FileName.
        /// </summary>
        public bool LoadCerts { get; set; } = true;

        /// <summary>
        /// The file name of the process to load to update certificates.
        /// </summary>
        public String FileName { get; set; } = "update-ca-certificates";
    }
}
