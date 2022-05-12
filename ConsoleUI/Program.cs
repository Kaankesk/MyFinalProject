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
            // OrderTest();
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
