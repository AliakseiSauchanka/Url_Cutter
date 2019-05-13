using System.Security.Cryptography;
using System.Text;

namespace Url_cutter.Services
{
    public static class URLGenerator
    {
        public static string GetUniqueURL(int size)
        {
            char[] chars ="abcdefghijklmnopqrstuvwxyz1234567890".ToCharArray();
            byte[] data = new byte[size];

            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }

            StringBuilder result = new StringBuilder(size);

            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }

            result.Append(".cutter");
            return result.ToString();
        }
    }
}
