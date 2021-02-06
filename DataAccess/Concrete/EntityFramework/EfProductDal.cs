using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
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
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        
    }
}
    

