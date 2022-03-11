using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate rows");
            for (int row = 1; row < 11; row++)
            {
                Console.WriteLine($"The row is {row}");
            }
            Console.WriteLine();
            Console.WriteLine("Generate columns");
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The column is {column}");
            }

            Console.WriteLine();
            Console.WriteLine("Nested loop");
            for (int row1 = 1; row1 < 11; row1++)
            {
                for(char column1 = 'a'; column1 < 'k'; column1++)
                {
                    Console.WriteLine($"The cell is: ({row1}, {column1})");
                }
            }
        }
    }
}
