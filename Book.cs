using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

    }
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Kitab elave olundu.");
        }

        public List<Book> Search_Books(string query)
        {
            return books.Where(b => b.Title.Contains(query) || b.Author.Contains(query)).ToList();
        }

        public void ShowBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Kitabxana bosdur.");
                return;
            }
            Console.WriteLine("Kitabxanadakı kitablar:");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}. Author: {book.Author}");
            }
        }
    }
}
