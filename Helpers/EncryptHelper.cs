// Common/EncryptHelper.cs
using System.Security.Cryptography;
using System.Text;

namespace TeleMedichineProject.Helpers
{
    public static class EncryptHelper
    {
        private static string _key = "SphairaSecretKey123!";

        public static void Initialize(string key)
        {
            if (!string.IsNullOrEmpty(key)) _key = key;
        }

        public static string Encrypt(string text)
        {
            var keyBytes = SHA256.HashData(Encoding.UTF8.GetBytes(_key));
            using var aes = Aes.Create();
            aes.Key = keyBytes;
            aes.GenerateIV();
            using var enc = aes.CreateEncryptor();
            var input = Encoding.UTF8.GetBytes(text);
            var result = enc.TransformFinalBlock(input, 0, input.Length);
            return Convert.ToBase64String(aes.IV.Concat(result).ToArray())
                .Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        public static string Decrypt(string text)
        {
            try
            {
                text = text.Replace("-", "+").Replace("_", "/");
                var padding = text.Length % 4 == 0 ? 0 : 4 - (text.Length % 4);
                text += new string('=', padding);
                var buffer = Convert.FromBase64String(text);
                var iv = buffer.Take(16).ToArray();
                var data = buffer.Skip(16).ToArray();
                var keyBytes = SHA256.HashData(Encoding.UTF8.GetBytes(_key));
                using var aes = Aes.Create();
                aes.Key = keyBytes;
                aes.IV = iv;
                using var dec = aes.CreateDecryptor();
                var result = dec.TransformFinalBlock(data, 0, data.Length);
                return Encoding.UTF8.GetString(result);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}