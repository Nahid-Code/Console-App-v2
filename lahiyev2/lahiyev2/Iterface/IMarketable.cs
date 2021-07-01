using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lahiyev2.Models;

namespace lahiyev2.Iterface
{
    interface IMarketable
    {
       List<Order> Orders { get; set; }
       List<Product> Products { get; set; }
        void AddOrder(Order order);
        void ReturnOrderItem(string order, string orderproduct,int orderproductcount);
        void ReturnOrder(string orderno);
        List<Order> ReturnOrderByDates(string startdate, string olddate);
        List<Order> ReturnOrderByDate(string date);
        List<Order> ReturnOrderByCosts(double startcost, double endcost);
        List<Order> ReturnOrderByOrderNo(string orderno);
        void AddProduct(string name, double price, string catagory, int count);
        void EditProduct(string code,string newname,double newprice,string newcatagory,int newcount);
        List<Product> ReturnProductByCatagory(string catagory);
        List<Product> ReturnProductByPrice(double starprice, double endprice);
        List<Product> ReturnProductByPrice(string productname);





    }
}
