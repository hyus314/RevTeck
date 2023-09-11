using Microsoft.AspNetCore.DataProtection;

namespace RevTech.Security
{
    public class ConfigurationDataProtector
    {
        private readonly IDataProtector dataProtector;

        public ConfigurationDataProtector(IDataProtector dataProtector)
        {
            this.dataProtector = dataProtector;
        }

        public string Encrypt(string id)
        {
            return dataProtector.Protect(id);
        }

        public int Decrypt(string id)
        {
            var decryptedString = dataProtector.Unprotect(id);
            return int.Parse(decryptedString);
        }
    }
}