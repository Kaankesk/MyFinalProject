using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName + " " + item.CategoryName);
            }
        }

        private static void OrderTest()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());

            foreach (var item in orderManager.GetAllOrders())
            {
                Console.WriteLine(item.OrderId + "-" + item.OrderDate.ToShortDateString());
            }
        }
    }
}
