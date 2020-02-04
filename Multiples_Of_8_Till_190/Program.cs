using System;

namespace Multiples_Of_8_Till_190
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Multiples of 8 till 190");
            int StartValue, Limit;
            for(StartValue = 1; StartValue <= 23; StartValue += 1)
                {
                Limit = StartValue * 8;
                Console.WriteLine(Limit);
            }
        }
    }
}
