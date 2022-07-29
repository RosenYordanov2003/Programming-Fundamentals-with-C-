using System;
using System.Collections.Generic;
using System.Linq;
namespace Article_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article>articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] comandArugments = command.Split(", ");
                string operation = comandArugments[0];
                Article article = new Article(comandArugments[0],comandArugments[1],comandArugments[2]);
                articles.Add(article);
            }
            foreach (Article article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
