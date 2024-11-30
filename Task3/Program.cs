

namespace Task3
{
    class Book
    {
        string Author, Title;
        bool Availability;
        string ISBN;

        public Book(string title = " ", string author = " ", string ISBN = "1", bool availability = true)
        {
            this.Author = author;
            this.Title = title;
            this.ISBN = ISBN;
            this.Availability = availability;
        }

        public void SetAuthor(string author) { this.Author = author; }
        public void SetTitle(string title) { this.Title = title; }
        public void SetAvailability(bool availability) { this.Availability = availability; }
        public void SetISBN(string ISBN) { this.ISBN = ISBN; }

        public string GetAuthor() { return this.Author; }
        public string GetTitle() { return this.Title; }
        public string GetISBN() { return this.ISBN; }
        public bool GetAvailability() { return this.Availability; }
    }

    class Library
    {
        List<Book> books;

        public Library()
        {
            this.books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public bool SearchBook(string name)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (name == books[i].GetAuthor() || name == books[i].GetTitle())
                {
                    Console.WriteLine($"Book is found ISBN : {books[i].GetISBN()} , Title : {books[i].GetTitle()}");
                    return true;
                }
            }
            Console.WriteLine("Book is not found");
            return false;
        }


        public void BorrowBook(string name)
        {
           for (int i = 0; i < books.Count; i++)
                {
                    if ((books[i].GetAuthor() == name || books[i].GetTitle() == name) && books[i].GetAvailability() == true)
                    {
                        Console.WriteLine("Book has been borrowed: " + books[i].GetTitle());
                        books[i].SetAvailability(false);
                        return;
                    }
                }
                Console.WriteLine("Book is not available to borrow");
            
        }

        public void ReturnBook(string name)
        {
           
                for (int i = 0; i < books.Count; i++)
                {
                    if ((books[i].GetAuthor() == name || books[i].GetTitle() == name) && books[i].GetAvailability() == false)
                    {
                        Console.WriteLine("Book has been returned: " + books[i].GetTitle());
                        books[i].SetAvailability(true);
                        return;
                    }
                }
                Console.WriteLine("Book is already not available to return");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            // Searching and borrowing books
            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("The Great Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); // This book is not in the library
            Console.WriteLine("========================");
            // Returning books
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("The Great Gatsby");
            library.ReturnBook("Harry Potter"); // This book is not borrowed

            
        }
    }
}
