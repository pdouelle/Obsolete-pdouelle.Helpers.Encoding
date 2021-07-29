using System.Security.Cryptography;
using System.Text;

namespace pdouelle.Helpers.Encoding
{
    public static class Sha256
    {
        public static string Hash(string value)
        {
            var sb = new StringBuilder();

            using (var hash = SHA256.Create())            
            {
                System.Text.Encoding enc = System.Text.Encoding.UTF8;
                var result = hash.ComputeHash(enc.GetBytes(value));

                foreach (var b in result)
                    sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}