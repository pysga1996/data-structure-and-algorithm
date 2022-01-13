using System;
using CommonFunctionAndUtility;

namespace ArrayDataStructure
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var arrayDataStructureDemo = new ArrayDataStructureDemo();
            // arrayDataStructureDemo.CheckLinearArray();
            Utility.ReadMenu("menu.txt");
            int command;
            var commandMap = Utility.ConvertToCommandMap("command.txt");
            do
            {
                Console.WriteLine("Enter your command: ");
                command = Utility.ReadCommand();
                Utility.ExecuteCommand(ref commandMap, command, arrayDataStructureDemo);
            } while (command != 0);
        }
    }
}