using DataAccess.Concrete;
using DataBusiness.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dependeny Injection -- Bağımlılıkları minumuna indirme

            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            ProductManager productManager = new ProductManager(new ProductDal());
            foreach (var item in categoryManager.GetCategories())
            {
                Console.WriteLine(item.CategoryName);
                Console.WriteLine("********************");
            }

            Console.WriteLine("-------------------------------------");
            foreach (var item in productManager.GetProducts())
            {
                Console.WriteLine("ProductName : " +item.ProductName);
            }
        }
    }
}
