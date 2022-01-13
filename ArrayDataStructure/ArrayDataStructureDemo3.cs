using System;

namespace ArrayDataStructure
{
    internal partial class ArrayDataStructureDemo
    {
        internal void PrintSquareArray()
        {
            Console.WriteLine("Enter number of elements:");
            var input = Console.ReadLine();
            var numberOfElements = Convert.ToInt32(input);
            var arr = new double[numberOfElements];
            for (var i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter number #{0}", i + 1);
                input = Console.ReadLine();
                var number = Convert.ToInt32(input);
                arr[i] = Math.Pow(number, 2d);
            }

            Console.Write("[");
            foreach (var t in arr)
            {
                Console.Write("{0} ", t);
            }
            Console.WriteLine("]");
        }
    }
}