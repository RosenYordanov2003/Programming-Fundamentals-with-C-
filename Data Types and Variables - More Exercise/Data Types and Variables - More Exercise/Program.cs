using System;

namespace Data_Types_and_Variables___More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = string.Empty;
            string dataType = string.Empty;
            int intValue;
            float floatValue;
            char charValue;
            bool boolValue;
            string type = string.Empty;
            while ((comand = Console.ReadLine()) != "END")
            {
                if (int.TryParse(comand, out intValue))
                {
                    dataType = "integer";
                    Console.WriteLine($"{comand} is {dataType} type");
                }
                else if (float.TryParse(comand,out floatValue))
                {
                    dataType = "floating point";
                    Console.WriteLine($"{comand} is {dataType} type");
                }
                else if (char.TryParse(comand,out charValue))
                {
                    dataType = "character";
                    Console.WriteLine($"{comand} is {dataType} type");

                }
                else if (bool.TryParse(comand,out boolValue))
                {
                    dataType = "boolean";
                    Console.WriteLine($"{comand} is {dataType} type");
                }
                else
                {
                    dataType = "string";
                    Console.WriteLine($"{comand} is {dataType} type");

                }

            }
        }
    }
}
