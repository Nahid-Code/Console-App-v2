using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lahiyev2.Enum;

namespace lahiyev2.Models
{
    
    class Product
    {
        public string  Name { get; set; }
        public double Price { get; set; }
        public Catagories Catagory{ get; set; }
        public int  Count { get; set; }
        private static int Codecount { get; set; } = 1000;
        public string Code;
        public Product(string name,double price, Catagories catagory,int count)
        {
            Codecount++;
            Name = name;
            Price = price;
            Catagory = catagory;
            Count = count;
            Code = name.Trim().ToUpper().Substring(0, 2) + Codecount.ToString();

        }
        public override string ToString()
        {
            return $"{Code},{Name},{Price},{Catagory},{Count}";

        }             
    }
}
