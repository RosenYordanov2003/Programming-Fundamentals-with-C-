using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            Console.WriteLine(current);
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] tokens = command.Split(":");
                string operation = tokens[0];
                if (operation == "Add")
                {
                    string lessonToAdd = tokens[1];
                    if (!lessons.Contains(lessonToAdd))
                    {
                        lessons.Add(lessonToAdd);
                    }
                }
                else if (operation == "Insert")
                {
                    string lessonToInsert = tokens[1];
                    int indexToInsert = int.Parse(tokens[2]);
                    if (indexToInsert >= 0 && indexToInsert < lessons.Count)
                    {
                        if (!lessons.Contains(lessonToInsert))
                        {
                            lessons.Insert(indexToInsert, lessonToInsert);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (operation == "Remove")
                {
                    string lessonToRemove = tokens[1];
                    if (lessons.Contains(lessonToRemove))
                    {
                        lessons.Remove(lessonToRemove);
                        string exercise = string.Format($"{lessons}-Exercise");
                        if (lessons.Contains(exercise))
                        {
                            lessons.Remove(exercise);
                        }
                    }
                }
                else if (operation == "Swap")
                {
                    string firstLesson = tokens[1];
                    string secondLesson = tokens[2];
                    if (lessons.Contains(firstLesson) && lessons.Contains(secondLesson))
                    {
                        SwapLessons(lessons, firstLesson, secondLesson);
                    }
                }
                else if (operation == "Exercise")
                {
                    string exerciseToAdd = tokens[1];
                    string exercise = string.Format($"{exerciseToAdd}-Exercise");
                    if (lessons.Contains(exerciseToAdd) && !lessons.Contains(exercise))
                    {
                        int exerciseIndex = lessons.IndexOf(exerciseToAdd);
                        lessons.Insert(exerciseIndex + 1, exercise);
                    }
                    else if (!lessons.Contains(exerciseToAdd))
                    {
                        int indexToInsert = lessons.Count;
                        lessons.Insert(indexToInsert, exerciseToAdd);
                        lessons.Insert(indexToInsert + 1, exercise);
                    }
                }
            }
            for (int i = 0; i < lessons.Count; i++)
            {

                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }

        static void SwapLessons(List<string> list, string firstLesson, string secondLesson)
        {
            string lessonTitle1 = firstLesson;
            string lessonTitle2 = secondLesson;
            int index1 = list.IndexOf(lessonTitle1);
            int index2 = list.IndexOf(lessonTitle2);

            if (list.Contains(lessonTitle1) && list.Contains(lessonTitle2))
            {
                string tempLessonTitle1 = list.ElementAt(index1);
                list[index1] = list[index2];
                list[index2] = tempLessonTitle1;
            }

            if (list.Contains(lessonTitle1 + "-Exercise") && list.Contains(list[index1]))
            {
                index1 = list.IndexOf(lessonTitle1);
                list.Remove(lessonTitle1 + "-Exercise");
                list.Insert(index1 + 1, lessonTitle1 + "-Exercise");
            }
            else if (list.Contains(lessonTitle2 + "-Exercise") && list.Contains(list[index2]))
            {
                index2 = list.IndexOf(lessonTitle2);
                list.Remove(lessonTitle2 + "-Exercise");
                list.Insert(index2 + 1, lessonTitle2 + "-Exercise");
            }
        }
    }
}
