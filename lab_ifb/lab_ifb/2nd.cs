using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 2; i++)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[32];

                rng.GetBytes(randomBytes);

                string randomHex = BitConverter.ToString(randomBytes).Replace("-", " ");

                Console.WriteLine(randomHex);
            }
        }
    }
}
