using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Book : Product
    {
        public string Genre { get; set; }
        public Book(string name, long ID,string genre, decimal PRICE) : base(name, ID, PRICE)
        {
            Genre = genre;
        }
    }
}
