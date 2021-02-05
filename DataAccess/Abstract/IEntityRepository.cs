using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //GENERİC REPOSİTORY 
    //generic constraint:generic repositorylere filtre koyuyoruz
    //class yazmamızın sebebi referans tip olabilir demektir.yani int gibi şeyler yazamayız
    //T ya IEntity olabilir yada IEntity (implemente eden bir nesne) den referans alabilir(IEntity olabilir veya IEntity implemnte eden bir nesne olabilir)
   //new (): newlenebilir olmalı. IEntity newlenemez.Interfaceler newlenemez.
    public  interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       
    }
}
