using System;

namespace Objects_and_classes_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Phrases = new string[]
         { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
             "Exceptional product.", "I can’t live without this product." };
            string[] Evenets = new string[]{ 
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. " +
                "I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] Authors = new string[] {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random positionPhrases=new Random();
            Random positionEvenets = new Random();
            Random positionsAuthors=new Random();
            Random posotopnsCities=new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <n ; i++)
            {
               int positionPhrase=positionPhrases.Next(0,Phrases.Length);
               string phrase=Phrases[positionPhrase];
               int evenetsPosition=positionEvenets.Next(0,Evenets.Length);
               string evenets=Evenets[evenetsPosition];
                int authorsPosition=positionsAuthors.Next(0,Authors.Length);
                string authors=Authors[authorsPosition];
                int citiesPosition=posotopnsCities.Next(0,Cities.Length);
                string cities=Cities[citiesPosition];
                Console.WriteLine($"{phrase} {evenets} {authors} – {cities}.");
            }
        }
    }
}
