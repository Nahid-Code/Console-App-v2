using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lahiyev2.Models
{
    class OrderItem
        
    {
        public  int OrderItemNo;
        public int OrderCount { get; set; }
        public Product OrderProduct { get; set; }
        public OrderItem(int ordercount,Product orderproduct)
        {                     
            OrderCount = ordercount;
            OrderProduct = orderproduct;
        }
    }
}
