using System;

namespace _9X9_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("start");
            for (var i = 0; i <= 6; i += 3)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (var k = 1; k < 4; k++)
                        Console.Write((k + i) + "*" + j + "=" + (k + i) * j + '\t');
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
