using System;

namespace Threax.AspNetCore.Docker.Certs
{
    public static class CertManager
    {
        /// <summary>
        /// Load trusted roots by calling update-ca-certificates. Good inside Linux containers
        /// that support this function (like the microsoft/aspnetcore:2.0 image). Returns true
        /// if the certs were loaded, false otherwise. Does not indicate how many certs were loaded
        /// just the the commands completed successfully.
        /// Right now this is just to centralize this call, this will
        /// evolve as the docker integration evolves.
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
