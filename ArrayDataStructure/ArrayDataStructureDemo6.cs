using System;
using System.Collections.Generic;

namespace ArrayDataStructure
{
    internal partial class ArrayDataStructureDemo
    {
        private static bool IsPrime(ref int x)
        {
            if (x < 2) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;
            var squareRoot = Convert.ToInt32(Math.Sqrt(x));
            for (var i = 3; i <= squareRoot; i += 2)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        
        internal void PrintPrimeArray()
        {
            Console.WriteLine("Enter number of elements:");
            var input = Console.ReadLine();
            var numberOfElements = Convert.ToInt32(input);

            IList<int> list = new List<int>(numberOfElements);

            for (var i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter number #{0}:", i + 1);
                input = Console.ReadLine();
                var number = Convert.ToInt32(input);
                list.Add(number);
            }

            Console.Write("[");
            foreach (var t in list)
            {
                var tmp = t;
                if (IsPrime(ref tmp))
                {
                    Console.Write("{0} ", t);
                }
            }

            Console.WriteLine();
        }
    }
}