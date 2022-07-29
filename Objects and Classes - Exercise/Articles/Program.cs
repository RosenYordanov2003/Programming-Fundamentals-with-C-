using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]articleInput=Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(articleInput[0],articleInput[1],articleInput[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n ; i++)
            {
                string command=Console.ReadLine();
                string[] comandArugments = command.Split(": ");
                string operation=comandArugments[0];
                if (operation=="Edit")
                {
                    string newContent = comandArugments[1];
                    article.EditMethod(newContent);
                }
                else if (operation == "Rename")
                {
                    string newTtile=comandArugments[1];
                    article.RenameTitle(newTtile);
                }
                else if (operation=="ChangeAuthor")
                {
                    string newAuthor = comandArugments[1];
                    article.ChangeAuthorMethod(newAuthor);
                }
            }
            Console.WriteLine(article);
        }
    }
    class Article
    {
        public Article(string title,string content,string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void EditMethod(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthorMethod(string newAuthor)
        {
          Author = newAuthor;
        }
        public void RenameTitle(string newTitle)
        {
           Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
