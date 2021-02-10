using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
//Abstractlar ile bagılılıkları ortadan kaldırmaya çalışıcaz.referans tutucuları tutacagız
namespace ConsoleUI
{
    // SOLID 
    //Open Closed Principle: yaptıgın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiçbir koduna dokunamazsın
    class Program
    {
        static void Main(string[] args)
        {
            //DTO :Data Transformation Object :tasıyacagım objeler
             ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var product in result.Data)//GetAll() da diyebiliriz,//GetByUnitPrice(50,100) de yazabliriz
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }
    }
}
