using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concrete
    //Bir is sınıfı baska sınıfları newleyemez.
{
   public class ProductManager:IProductService
       
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //is kodları 

            return _productDal.GetAll();
        }
    }
}
