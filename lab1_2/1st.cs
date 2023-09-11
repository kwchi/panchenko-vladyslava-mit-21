using System;
public class Example
{
    public static void Main()
    {
        Random rnd = new Random();
        for (int ctr = 0; ctr < 10; ctr++)
        {
            Console.Write("{0,3} ", rnd.Next(-10, 11));
        }
    }
}