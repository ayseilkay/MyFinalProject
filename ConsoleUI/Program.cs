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

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAllByCategoryId(2))//GetAll() da diyebiliriz,//GetByUnitPrice(50,100) de yazabliriz
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
