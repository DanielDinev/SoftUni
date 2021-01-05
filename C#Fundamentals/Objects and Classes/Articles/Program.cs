using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int n = int.Parse(Console.ReadLine());
            List<Article> listArticles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] inp = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Article newArticle = new Article(inp);
                listArticles.Add(newArticle);



            }
            string input = Console.ReadLine();

            if (input == "title")
            {
                foreach (var item in listArticles.OrderBy(n => n.Title))
                {
                    Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
                }
            }
            else if (input == "content")
            {
                foreach (var item in listArticles.OrderBy(n => n.Content))
                {
                    Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
                }
            }
            else
            {
                foreach (var item in listArticles.OrderBy(n => n.Author))
                {
                    Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
                }
            }
           










        }

        
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public Article(string [] input)
        {
            Title = input[0];
            Content = input[1];
            Author = input[2];
        }

        
        





    }
}
