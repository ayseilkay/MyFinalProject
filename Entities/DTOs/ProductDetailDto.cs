using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
   // IEntity den implement edemeyiz.cünkü bu bir veritabanı tablosu degil. Birden fazla tablonun joini olabilir.
   //ProductDetailDto tek başına bir tablo degil.Ama IEntity bir veritabanı tablosuna karsılık gelir.
   public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
