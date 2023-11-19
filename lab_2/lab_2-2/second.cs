using System;
using System.IO;
using System.Text;

class VernamCipher
{
    static void Main()
    {
            string encryptedFilePath = @"C:\Users\Lenovo\OneDrive\Документи\КНУ\2 курс\1 семестр\основи інформаційної безпеки\лабораторні\лаб 2\encfile.dat";

            byte[] encryptedData = File.ReadAllBytes(encryptedFilePath);

            string targetPhrase = "Mit21";

            for (long i = 0; i < Math.Pow(256, 8); i++)
            {
                byte[] key = BitConverter.GetBytes(i);

                byte[] decryptedData = Decrypt(encryptedData, key);

                string decryptedText = Encoding.UTF8.GetString(decryptedData);
                if (decryptedText.Contains(targetPhrase))
                {
                    Console.WriteLine("Фраза знайдена! Ключ: " + BitConverter.ToString(key).Replace("-", ""));
                    break;
                }
            }

        Console.ReadLine();
    }

    static byte[] Decrypt(byte[] data, byte[] key)
    {
        byte[] decryptedData = new byte[data.Length];

        for (int i = 0; i < data.Length; i++)
        {
            decryptedData[i] = (byte)(data[i] ^ key[i % key.Length]);
        }

        return decryptedData;
    }
}
