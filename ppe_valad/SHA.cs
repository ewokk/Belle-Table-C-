using System;
using System.Text;
using System.Security.Cryptography;

namespace HashageStandard
{
    public static class SHA
    {
		public static string MakeMD5Hash(string input)//MD5
        {
            // etape 1, calculer MD5 depuis la chaine
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

			// etape 2, concertir vers chaine Hexa
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
         {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

            private static string GetStringFromHash(byte[] hash)
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    result.Append(hash[i].ToString("X2"));
                }
                return result.ToString();
            }
        }

}
