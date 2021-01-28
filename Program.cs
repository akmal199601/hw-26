using System;

namespace book
{
    class Book
    {
        Title  title;
        Author author;
        Content content;


        public Book(string t, string a,string c)
        {
            title = new Title(t);
            author = new Author(a);
            content = new Content(c);
        }
        public void Show()
        {
            Console.ForegroundColor =ConsoleColor.Red;
            title.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            author.Show();
            Console.ForegroundColor = ConsoleColor.Blue;
            content.Show();
            
        }
    }
    class Title
    {
        string title;
        public Title(string t)
        {
            title = t;
        }
        public void Show()
        {
            System.Console.WriteLine(title);
        }
    }
    class Author
    {
        string author;
        public Author(string a)
        {
            author = a;
        }
        public void Show()
        {
            System.Console.WriteLine(author);
        }
    }
    class Content
    {
        string content;
        public Content(string c)
        {
            content = c;
        }
        public void Show()
        {
            System.Console.WriteLine(content);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           var book1 = new Book("Шохнома","Akmal","Literatura");
           book1.Show();
        }
    }
}
