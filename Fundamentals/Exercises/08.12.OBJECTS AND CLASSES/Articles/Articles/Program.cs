using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)//razpisvame logikata v Main methoda;
        {
            string[] tokens = Console.ReadLine().Split(", ");
            Article article = new Article(tokens[0],tokens[1],tokens[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(": ");//vzimame input
                string command = cmdArg[0];
                string argument = cmdArg[1];
                switch (command)
                {
                    case "Edit":article.Edit(argument);break;//izvikvame methoda
                    case "ChangeAuthor": article.ChangeAuthor(argument);break;
                    case "Rename":article.Rename(argument);break;

                }
            }
            Console.WriteLine(article.ToString());
        }

    }
    class Article
    {
        public Article(string title,string content,string author)//constructor
        {
            Title = title;//parameters
            Content = content;
            Author = author;

        }
        public string Title { get; set; }//properties
        public string Content { get; set; }//properties
        public string Author { get; set; }//properties


        public void Edit(string content)//Methods
        {
            Content = content;//change content ot uslovieto;
        }

        public void ChangeAuthor(string author)//Methods
        {
            Author = author;//
        }
        public void Rename(string title)//Methods
        {
            Title = title;//preimenuva naimeto;
        }
        public override string ToString()//Methods
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
