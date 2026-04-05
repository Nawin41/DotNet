using System;

namespace CSharp_Assignment_5
{
    //Books class
    internal class Books
    {
        string bookName;
        string authorName;

        public Books(string bname, string aname)
        {
            bookName = bname;
            authorName = aname;
        }

        public void Display()
        {
            Console.WriteLine("Book Name: " + bookName);
            Console.WriteLine("Author Name: " + authorName);
            Console.WriteLine();
        }
    }

    //BookShelf class
    internal class BookShelf
    {
        Books[] books = new Books[5];

        
        public Books this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }
    }

    
    internal class BookShelfOperations
    {
        public static void Start()
        {
            BookShelf shelf = new BookShelf();

            
            shelf[0] = new Books("C# Basics", "John");
            shelf[1] = new Books("OOPS Concepts", "James");
            shelf[2] = new Books("ASP.NET", "Robert");
            shelf[3] = new Books("Data Structures", "Smith");
            shelf[4] = new Books("Algorithms", "David");

            
            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }

            Console.ReadLine();
        }
    }
}