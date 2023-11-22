using System;

namespace uppgift_5._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in 5 namn");
            string[] namn = new string[5];
            for (int i = 0; i < namn.Length; i++)
            {
                namn[i] = Console.ReadLine();
            }
            for (int i = 0;i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            }
            Console.Read();
        }
    }
}
