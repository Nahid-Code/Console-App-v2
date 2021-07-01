using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lahiyev2.Models
{
      class Order
    {
        public  int OrderNo;
        public static int OrderNoCount { get; set; } = 1000;
        public double  Cost { get; set; }
        public string Date { get; set; }
        public List<OrderItem> SoldProducts { get; set; }
        public Order(byte day,byte month,int year ,List<OrderItem> soldproducts)
        {
            OrderNoCount++;
            OrderNo = OrderNoCount;
            SoldProducts = new List<OrderItem>();
            Date = day.ToString() + "." + month.ToString() + "." + year.ToString();
            
            
        }
 

    }
}
