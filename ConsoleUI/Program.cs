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
            ProductTest();
           // CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName+"***"+item.CategoryName);
            }
            Console.WriteLine("----------------------------");

            foreach (var item in productManager.GetAllByCategoryId(3))
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("----------------------------");

            foreach (var item in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
