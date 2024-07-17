using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public interface ILibrary
    {
        public void AddBook(Book book);
        public Book? GetBookById(int Id);
        public Book? GetBookByName(string n);
        public Book[] GetFilteredBooks(string value);
        public Book[] GetFilteredBooks(decimal minPrice, decimal maxPrice);
    }
}
