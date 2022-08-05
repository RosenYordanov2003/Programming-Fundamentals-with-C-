using System;
using System.Text;

namespace HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titleArticle = Console.ReadLine();
            string content = Console.ReadLine();
            string commad = string.Empty;
            StringBuilder result = new StringBuilder();
            result.AppendLine($"<h1>\n    {titleArticle}\n</h1>");
            result.AppendLine($"<article>\n    {content}\n</article>");
            while ((commad = Console.ReadLine()) != "end of comments")
            {
                result.AppendLine($"<div>\n    {commad}\n</div>");
            }
            Console.WriteLine(result.ToString());
        }

    }
}
