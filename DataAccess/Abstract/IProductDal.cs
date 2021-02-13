using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
   public interface IProductDal:IEntityRepository<Product>
    {
        //interface metodları default public 'dir.
        List<ProductDetailDto> GetProductDetails();
    }
}
