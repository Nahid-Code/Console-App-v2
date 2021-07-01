using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lahiyev2.Iterface;
using lahiyev2.Models;

namespace lahiyev2.services
{
    class Marketable : IMarketable
    {
        public List<Order> Orders { get ; set; }
        public List<Product> Products { get; set; }
        public Marketable()
        {
            Orders = new List<Order>();
            Products = new List<Product>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public void AddProduct(string name, double price, string catagory, int count)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(string code, string newname, double newprice, string newcatagory, int newcount)
        {
            throw new NotImplementedException();
        }

        public void ReturnOrder(string orderno)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrderByCosts(double startcost, double endcost)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrderByDate(string date)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrderByDates(string startdate, string olddate)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrderByOrderNo(string orderno)
        {
            throw new NotImplementedException();
        }

        public void ReturnOrderItem(string order, string orderproduct, int orderproductcount)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnProductByCatagory(string catagory)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnProductByPrice(double starprice, double endprice)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnProductByPrice(string productname)
        {
            throw new NotImplementedException();
        }
    }
}
