using System;
public class Example
{
    public static void Main()
    {
        for (int i = 0; i < 2; i++)
        {
            Random rnd = new Random(5234);
            for (int ctr = 0; ctr < 10; ctr++)
            {
                Console.Write("{0,3} ", rnd.Next(-10, 11));
            }
            Console.WriteLine();
        }
    }
}