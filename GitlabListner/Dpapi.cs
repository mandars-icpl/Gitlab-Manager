using System;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace GitlabListner
{
    public static class Dpapi
    {

        public static void Set(string key, string value)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));

            }
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            byte[] secretData = Encoding.UTF8.GetBytes(value);
            byte[] entropy = Encoding.UTF8.GetBytes(key);
            var encryptedData = ProtectedData.Protect(secretData, entropy, DataProtectionScope.CurrentUser);
            var encryptedValue = Convert.ToBase64String(encryptedData);
            Environment.SetEnvironmentVariable(key, encryptedValue, EnvironmentVariableTarget.Machine);
        }

        public static string Get(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            var encryptedValue = Environment.GetEnvironmentVariable(key, EnvironmentVariableTarget.Machine);

            // decrypt and return
            // Optional entropy
            byte[] entropy = Encoding.Unicode.GetBytes(GetProcessorId());

            // Convert the data from string to byte array
            byte[] encryptedData = Convert.FromBase64String(encryptedValue);

            // Unprotect (Decrypt) the data
            byte[] decryptedData = ProtectedData.Unprotect(encryptedData, entropy, DataProtectionScope.LocalMachine);

            var decryptedValue = Encoding.Unicode.GetString(decryptedData);

            return decryptedValue;

        }

        private static string GetProcessorId()
        {
            var mc = new ManagementClass("Win32_Processor");
            var moc = mc.GetInstances();
            string id = string.Empty;
            foreach (var mo in moc.Cast<ManagementObject>())
            {
                id = mo.Properties["processorID"].Value.ToString();
                break;
            }

            return id;
        }
    }
}
