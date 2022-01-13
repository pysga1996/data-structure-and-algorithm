using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CommonFunctionAndUtility
{
    public static class Utility
    {
        public static int ReadCommand()
        {
            var cmdStr = Console.ReadLine();
            var convertSuccess = int.TryParse(cmdStr, out var cmd);
            return convertSuccess ? cmd : -1;
        }

        public static void ReadMenu(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine();

                var str = File.ReadAllText(filePath);
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        public static Dictionary<int, string> ConvertToCommandMap(string filePath)
        {
            var commandDict = new Dictionary<int, string>();
            var lines = File.ReadAllLines(filePath);
            foreach (var t in lines)
            {
                var tmpStr = t.Split(".");
                if (tmpStr.Length < 2) continue;
                var convertSuccess = int.TryParse(tmpStr[0], out var cmd);
                if (!convertSuccess) continue;
                var methodName = tmpStr[1];
                commandDict.Add(cmd, methodName);
            }

            return commandDict;
        }

        public static void ExecuteCommand(ref Dictionary<int, string> commandMap, int command, object obj)
        {
            if (commandMap.ContainsKey(command))
            {
                var methodName = commandMap[command];
                var methodInfo =
                    obj.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
                if (methodInfo == null)
                {
                    Console.WriteLine("Method {0} not found on object", methodName);
                    return;
                }

                methodInfo.Invoke(obj, new object[] { });
            }
            else
            {
                if (command != 0)
                {
                    Console.WriteLine("Command {0} not found: ", command);
                }
            }
        }
    }
}