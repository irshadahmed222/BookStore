using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return DataSource().ToList();
        }

        public Book GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        
        public List<Book> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList(); // use && or || conditions
        }

        private List<Book> DataSource()
        {
            return new List<Book>()
            {
                new Book(){ Id = 1, Title="DotNet", Author="Microsoft"},
                new Book(){ Id = 2, Title="JavaScript", Author="JAVA"},
                new Book(){ Id = 3, Title="WordPress", Author="PHP"},
                new Book(){ Id = 4, Title="REACT", Author="Facebook"},
                new Book(){ Id = 5, Title="Nodejs", Author="Google"},
            };
        }
    }
}
