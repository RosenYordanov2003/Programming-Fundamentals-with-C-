using System;
using System.Linq;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] intialIndexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < fieldSize; i++)
            {
                if (intialIndexes.Contains(i))
                {
                    field[i] = 1;
                }
            }
            string comand = string.Empty;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] separateComand = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int startIndexToFly = (int.Parse(separateComand[0]));
                string direction = separateComand[1];
                int flyLenght = (int.Parse(separateComand[2]));
                if (startIndexToFly < 0 || startIndexToFly >= field.Length)
                {
                    continue;
                }
                if (field[startIndexToFly] == 0)
                {
                    continue;
                }
                field[startIndexToFly] = 0;/// lady bug starts flying
                int nextIndex = startIndexToFly;//lady bug starts flying
                while (true)
                {

                    if (direction == "left")
                    {
                        nextIndex -= flyLenght;
                    }
                    else if (direction == "right")
                    {
                        nextIndex += flyLenght;
                    }
                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        break;
                    }
                    if (field[nextIndex] == 0)
                    {
                        break;
                        //lady bug land here
                    }

                }
                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}
