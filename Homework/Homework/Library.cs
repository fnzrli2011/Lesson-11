using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Homework
{
    public class Library : ILibrary
    {
        public Book[] Books = Array.Empty<Book>();
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public Book? GetBookById(int Id)
        {
            foreach (Book item in Books)
            {
                if (item.id == Id)
                {
                    return item;
                }
            }
            return null;
        }

        public Book? GetBookByName(string n)
        {
            foreach (Book item in Books)
            {
                if (item.Name == n)
                {
                    return item;
                }
            }
            return null;
        }

        public Book[] GetFilteredBooks(string value)
        {
            Book[] filtredbooks = Array.Empty<Book>();
            foreach (var item in Books)
            {
                if (item.Genre == value)
                {
                    Array.Resize(ref filtredbooks, filtredbooks.Length + 1);
                    filtredbooks[filtredbooks.Length - 1] = item;
                }
            }
            return filtredbooks;
        }

        public Book[] GetFilteredBooks(decimal minPrice, decimal maxPrice)
        {
            Book[] filtredBooksp = Array.Empty<Book>();
            foreach (Book item in Books)
            {
                if (item.price >= minPrice && item.price <= maxPrice)
                {
                    Array.Resize(ref filtredBooksp, filtredBooksp.Length + 1);
                    filtredBooksp[filtredBooksp.Length - 1] = item;
                }
            }
            return filtredBooksp;
        }
    }
}
