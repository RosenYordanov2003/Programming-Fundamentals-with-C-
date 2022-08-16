using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\#|\|){1}(?<foodName>[A-Za-z]+(\s+[A-Za-z]+)?)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            List<FoodPorperties> food = new List<FoodPorperties>();
            int totalCalories = 0;
            foreach (Match match in matches)
            {
                int currentCalories = int.Parse(match.Groups["calories"].Value);
                string currentFood = match.Groups["foodName"].Value;
                string date = match.Groups["date"].Value;
                totalCalories += currentCalories;
                FoodPorperties currentFoodPorp = new FoodPorperties(currentFood, date, currentCalories);
                food.Add(currentFoodPorp);

            }
            CalculateDays(totalCalories);
            PrintResult(food);
        }

        static void PrintResult(List<FoodPorperties> food)
        {
            foreach (FoodPorperties item in food)
            {
                Console.WriteLine($"Item: {item.FoodName}, Best before: {item.Date}, Nutrition: {item.Calories}");
            }
        }

        static void CalculateDays(int totalCalories)
        {
            int dayCounter = 0;
            while (totalCalories >= 2000)
            {
                totalCalories -= 2000;
                dayCounter++;
            }
            Console.WriteLine($"You have food to last you for: {dayCounter} days!");
        }
    }
    class FoodPorperties
    {
        public FoodPorperties(string foodName, string date, int calories)
        {
            this.FoodName = foodName;
            this.Date = date;
            this.Calories = calories;
        }
        public string FoodName { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }
    }
}
