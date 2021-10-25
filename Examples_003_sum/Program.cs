using System;

namespace Examples_003_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = new Random().Next(1,10);
            int nubmerB = new Random().Next(1,10);
            int result = numberA + nubmerB;
            Console.Write(result);
        }
    }
}
