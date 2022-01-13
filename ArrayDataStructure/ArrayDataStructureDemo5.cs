using System;
using System.Collections.Generic;

namespace ArrayDataStructure
{
    internal partial class ArrayDataStructureDemo
    {
        internal void RemoveAndPrint()
        {
            Console.WriteLine("Enter number of elements:");
            var input = Console.ReadLine();
            var numberOfElements = Convert.ToInt32(input);
            int number;

            IList<double> list = new List<double>(numberOfElements);

            for (var i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter number #{0}:", i + 1);
                input = Console.ReadLine();
                number = Convert.ToInt32(input);
                list.Add(number);
            }
            Console.WriteLine("Enter index to remove:");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            var removeIndex = Convert.ToInt32(number);
            list.RemoveAt(removeIndex);
            foreach (var t in list)
            {
                Console.Write("{0} ", t);
            }
        } 
    }
}