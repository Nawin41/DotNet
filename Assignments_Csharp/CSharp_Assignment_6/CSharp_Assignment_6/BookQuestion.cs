using System;

//Question 1

namespace CSharp_Assignment_6
{
    //Books class
    class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

       
        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

       
        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}, Author Name: {AuthorName}");
        }
    }

    
    class BookShelf
    {
        private Books[] books = new Books[5];

        //Index
        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                    return books[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < books.Length)
                    books[index] = value;
            }
        }

        
        public void DisplayAllBooks()
        {
            for (int i = 0; i < books.Length; i++)
            {
                books[i]?.Display();
            }
        }
    }

    
    class BookQuestion
    {
        public static void Execute()
        {
            BookShelf shelf = new BookShelf();

            shelf[0] = new Books("The Alchemist", "Paulo Coelho");
            shelf[1] = new Books("Wings of Fire", "A.P.J Abdul Kalam");
            shelf[2] = new Books("Rich Dad Poor Dad", "Robert Kiyosaki");
            shelf[3] = new Books("Think and Grow Rich", "Napoleon Hill");
            shelf[4] = new Books("Atomic Habits", "James Clear");

            Console.WriteLine("Books in Shelf:\n");
            shelf.DisplayAllBooks();
        }
    }
}