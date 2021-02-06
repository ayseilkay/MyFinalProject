using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
   public interface IProductDal:IEntityRepository<Product>
    {
        //interface metodları default public 'dir.
        List<ProductDetailDto> GetProductDetails();
    }
}
