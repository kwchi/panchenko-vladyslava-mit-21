using System;
using System.IO;
class VernamCipher
{
    static void Main(string[] args)
    {

        string filePath = @"C:\Users\Lenovo\OneDrive\Документи\КНУ\2 курс\1 семестр\основи інформаційної безпеки\лабораторні\лаб 2\cipher.txt";

        string key = "4C F5 4B 14 92 B1 36 27 46 96 CE 75 B4 5E 03 55 BE 95 FF 00 20 A2 A3 1C F5 9E 7D 93 BD 35 47 12";

        if (File.Exists(filePath))
        {
            Console.WriteLine("Виберiть операцiю: \n1. Шифрування \n2. Розшифрування\n");
            char operation = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (operation == '1')
            {
                EncryptFile(filePath, key);
                Console.WriteLine("Файл був зашифрований");
            }
            else if (operation == '2')
            {
                DecryptFile(filePath, key);
                Console.WriteLine("Файл був розшифрований");
            }
            else
            {
                Console.WriteLine("Помилка");
            }
        }
        else
        {
            Console.WriteLine("Файл не знайдено");
        }
    }

    static void EncryptFile(string filePath, string key)
    {
        byte[] fileData = File.ReadAllBytes(filePath);
        byte[] encryptedData = TransformData(fileData, key);
        string outputFilePath = Path.ChangeExtension(filePath, ".dat");
        File.WriteAllBytes(outputFilePath, encryptedData);
    }

    static void DecryptFile(string filePath, string key)
    {
        byte[] fileData = File.ReadAllBytes(filePath);
        byte[] decryptedData = TransformData(fileData, key);

        File.WriteAllBytes(filePath, decryptedData);
    }

    static byte[] TransformData(byte[] data, string key)
    {
        byte[] transformedData = new byte[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            transformedData[i] = (byte)(data[i] ^ key[i % key.Length]);
        }
        return transformedData;
    }
}
