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
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //IDisposiable pattern implementation of c# (using yapısına deniliyor)
            //using içerisine yazdıgınız nesneler işi bitince garbage collectore gidecek 
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context= new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //filtre null ise ilk kısım calısır
                //burada select * from products döndürür.
                return filter == null ? //filtre null ise
                    context.Set<Product>().ToList():context.Set<Product>().Where(filter).ToList();

            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
    

