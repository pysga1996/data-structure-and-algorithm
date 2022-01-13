using System;

namespace ArrayDataStructure
{
    internal partial class ArrayDataStructureDemo
    {
        internal void CheckLinearArray()
        {
            Console.WriteLine("Enter number of elements:");
            var input = Console.ReadLine();
            var numberOfElements = Convert.ToInt32(input);
            var arr = new int[numberOfElements];
            for (var i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter number {0}", i + 1);
                input = Console.ReadLine();
                arr[i] = Convert.ToInt32(input);
            }
            if (arr.Length == 1)
            {
                Console.WriteLine("YES");
                return;
            }
            var check = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        continue;
                    case 1:
                        check = arr[i] - arr[i - 1];
                        continue;
                }

                if (check * (arr[i] - arr[i - 1]) <= 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                check = arr[i] - arr[i - 1];
            }
            Console.WriteLine("YES");
        }
    }
}