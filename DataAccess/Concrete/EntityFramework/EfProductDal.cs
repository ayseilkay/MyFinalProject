using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Entity Framework:Microsoftun bir ürünüdür. Bir Object Relational Mapping (ORM) dediğimiz bir ürünü.
    //Link destekli çalışıyor.
    //ORM veri tabanındaki tabloyu sanki classmıs gibi bütün operasyonları link ile yaptıgımız
    //bir ortamdır. ORM veritabanı ile kodlar arasında bir bağ kurup veri tabanı işlemlerini yapma sürecidir.
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }

       
    }
}
    

