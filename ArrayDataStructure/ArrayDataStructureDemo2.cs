using System;

namespace ArrayDataStructure
{
    internal partial class ArrayDataStructureDemo
    {
        internal void PrintSum()
        {
            Console.WriteLine("Enter number of elements:");
            string input = Console.ReadLine();
            int numberOfElements = Convert.ToInt32(input);
            int sum = 0;
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter number #{0}:", i + 1);
                input = Console.ReadLine();
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine(sum);
        }
    }
}