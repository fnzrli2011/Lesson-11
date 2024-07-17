using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Product
    {
        public string Name { get; set; }
        private long Id { get; set; }
         
        public long id
        {
            get
            {
                return Id;
            }
            set
            {
                if(value>0) Id= value;
            }
        }

        private decimal Price { get; set; }


        public decimal price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value > 0) Price = value;
            }
        }




        public Product(string name,long ID ,decimal PRICE)
        {
            Name = name;
            id = ID;
            price= PRICE;
        }
    }
}
