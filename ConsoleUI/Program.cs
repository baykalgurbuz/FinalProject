using Business.Concreate;
using DataAccess.Concreate.EntitiyFramework;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("----------------------------");

            foreach (var item in productManager.GetAllByCategoryId(3))
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("----------------------------");

            foreach (var item in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
