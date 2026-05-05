using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace   TeleMedichineProject.Common
{
    public class EncDec
    {
        private const string _saltString = "saltKereeennn";
        private const string _passwordString = "whatisthis";

        public static string Encrypt(string input)
        {
            return Encrypt(input, _saltString, _passwordString);
        }

        public static string Encrypt(string input, string saltString, string passwordString)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(input);
            byte[] saltBytes = Encoding.UTF8.GetBytes(saltString);

            using var aes = Aes.Create();
            //using var key = new Rfc2898DeriveBytes(passwordString, saltBytes, 10000, HashAlgorithmName.SHA256);
            using var key = new Rfc2898DeriveBytes(passwordString, saltBytes);

            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            using var ms = new MemoryStream();
            using var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(plainBytes, 0, plainBytes.Length);
            cs.FlushFinalBlock();

            return Convert.ToBase64String(ms.ToArray());
        }

        public static string EncryptInterop(string input)
        {
            byte[] utfdata = Encoding.UTF8.GetBytes(input);
            byte[] saltBytes = Encoding.UTF8.GetBytes(_saltString);

            using (var aes = new AesManaged())
            using (var rfc = new Rfc2898DeriveBytes(_passwordString, saltBytes)) // sama persis dengan App Lama NET 4
            {
                aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
                aes.KeySize = aes.LegalKeySizes[0].MaxSize;
                aes.Key = rfc.GetBytes(aes.KeySize / 8);
                aes.IV = rfc.GetBytes(aes.BlockSize / 8);

                using (var ms = new MemoryStream())
                using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(utfdata, 0, utfdata.Length);
                    cs.Flush();
                    cs.Close();

                    var base64 = Convert.ToBase64String(ms.ToArray());

                    // 🔥 penting untuk URL
                    return HttpUtility.UrlEncode(base64);
                }
            }
        }

        public static string Decrypt(string input)
        {
            return Decrypt(input, _saltString, _passwordString);
        }

        public static string Decrypt(string base64Input, string saltString, string passwordString)
        {
            byte[] encryptBytes = Convert.FromBase64String(base64Input);
            byte[] saltBytes = Encoding.UTF8.GetBytes(saltString);

            using (var aes = Aes.Create())
            {
                //var rfc = new Rfc2898DeriveBytes(passwordString, saltBytes, 10000, HashAlgorithmName.SHA256);
                var rfc = new Rfc2898DeriveBytes(passwordString, saltBytes);

                aes.Key = rfc.GetBytes(aes.KeySize / 8);
                aes.IV = rfc.GetBytes(aes.BlockSize / 8);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using var decryptStream = new MemoryStream();
                using var decryptor = new CryptoStream(decryptStream, aes.CreateDecryptor(), CryptoStreamMode.Write);
                decryptor.Write(encryptBytes, 0, encryptBytes.Length);
                decryptor.FlushFinalBlock();

                byte[] decryptBytes = decryptStream.ToArray();
                return Encoding.UTF8.GetString(decryptBytes);
            }
        }
        public static string DecryptInterop(string input)
        {
            // decode dulu
            input = HttpUtility.UrlDecode(input);

            byte[] encryptBytes = Convert.FromBase64String(input);
            byte[] saltBytes = Encoding.UTF8.GetBytes(_saltString);

            using (var aes = new AesManaged())
            using (var rfc = new Rfc2898DeriveBytes(_passwordString, saltBytes))
            {
                aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
                aes.KeySize = aes.LegalKeySizes[0].MaxSize;
                aes.Key = rfc.GetBytes(aes.KeySize / 8);
                aes.IV = rfc.GetBytes(aes.BlockSize / 8);

                using (var ms = new MemoryStream())
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(encryptBytes, 0, encryptBytes.Length);
                    cs.Flush();
                    cs.Close();

                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }
    }
}
