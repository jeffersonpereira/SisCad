using System;
using System.Text;
using System.Security.Cryptography;

namespace Model.Data
{
    public static class Security
    {
        public static string GetHashMD5(string senha)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("x2"));
            }
            return builder.ToString();
        }

        public static bool VeryHash(string senha, string hash)
        {
            string hash2 = GetHashMD5(senha);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            bool very = 0 == comparer.Compare(hash2, hash);
            return very;
        }
    }
}