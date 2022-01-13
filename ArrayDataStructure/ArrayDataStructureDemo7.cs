using System;
using System.Collections.Generic;

namespace ArrayDataStructure
{
    internal partial class ArrayDataStructureDemo
    {
        internal void PrintFrequencyArray()
        {
            Console.WriteLine("Enter number of elements:");
            var input = Console.ReadLine();
            var numberOfElements = Convert.ToInt32(input);
            IDictionary<int, int> dictionary = new SortedDictionary<int, int>();

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter number #{0}:", i + 1);
                input = Console.ReadLine();
                var number = Convert.ToInt32(input);
                if (dictionary.ContainsKey(number))
                {
                    dictionary[number]++;
                }
                else
                {
                    dictionary.Add(number, 1);
                }
            }
            foreach (var (key, value) in dictionary)
            {
                Console.Write("{0} - {1}; ", key, value);
            }
        }
    }
}