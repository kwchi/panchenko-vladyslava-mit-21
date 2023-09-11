using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
        {
            byte[] randomBytes = new byte[32]; 

            rng.GetBytes(randomBytes);

            string randomHex = BitConverter.ToString(randomBytes).Replace("-", "");

            Console.WriteLine(randomHex);
        }
    }
}
