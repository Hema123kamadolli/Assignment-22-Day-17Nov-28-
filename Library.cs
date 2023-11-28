using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_22
{
    public class Library
    {
        private List<Book> bookList = new List<Book>();

        public void AddBook(int bookId, string title, string author, string genre)
        {
            Book newBook = new Book
            {
                BookId = bookId,
                Title = title,
                Author = author,
                Genre = genre,
                IsAvailable = true
            };

            bookList.Add(newBook);
            Console.WriteLine("Book added successfully.");
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("Library Catalog:");
            foreach (var book in bookList)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
        }

        public void SearchBookById(int bookId)
        {
            Book foundBook = bookList.Find(book => book.BookId == bookId);
            if (foundBook != null)
            {
                Console.WriteLine("Book found:");
                Console.WriteLine($"ID: {foundBook.BookId}, Title: {foundBook.Title}, Author: {foundBook.Author}, Genre: {foundBook.Genre}, Available: {(foundBook.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine($"Book not found with ID: {bookId}");
            }
        }

        public void SearchBookByTitle(string title)
        {
            Book foundBook = bookList.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (foundBook != null)
            {
                Console.WriteLine("Book found:");
                Console.WriteLine($"ID: {foundBook.BookId}, Title: {foundBook.Title}, Author: {foundBook.Author}, Genre: {foundBook.Genre}, Available: {(foundBook.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine($"Book not found with title: {title}");
            }
        }

    }
}
