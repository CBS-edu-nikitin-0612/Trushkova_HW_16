using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal static class ClassException 
    {
        public static void ExceptionProcessing(Exception ex)
        {
            switch (ex.GetType().ToString())
            {
                case "System.OverflowException":
                    ExceptionMessage($"Введите от 1 до {UInt32.MaxValue}\n");
                    break;

                case "System.FormatException":
                    ExceptionMessage("Вы ввели не целочисленное число.\n");
                    break;

                default:
                    ExceptionMessage(ex.GetType().ToString());
                    break;
            }
        }

        public static void ExceptionMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
