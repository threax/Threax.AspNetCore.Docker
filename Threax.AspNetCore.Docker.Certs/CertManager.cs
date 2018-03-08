using System;

namespace Threax.AspNetCore.Docker.Certs
{
    /// <summary>
    /// A class to manage certificates in the microsoft/aspnetcore:2.0 Linux docker image.
    /// </summary>
    public static class CertManager
    {
        /// <summary>
        /// Load all certificates that can be found by update-ca-certificates. The best
        /// thing to do is to mount any custom certificates into /usr/local/share/ca-certificates
        /// and then call this function on startup. This will load the custom certificates dynamically
        /// on container startup each time. This function will return true if the commands completed
        /// sucessfully and false otherwise. This does not indicate if any certificates were loaded
        /// or not. If run outside of a container this will likely always return false unless the
        /// app can manage to run update-ca-certificates on your system.
        /// </summary>
        public static bool LoadTrustedRoots()
        {
            try
            {
                var process = System.Diagnostics.Process.Start("update-ca-certificates");
                process.WaitForExit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
