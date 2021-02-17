using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        //kurallar constructor içine yazılır.
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);//WithMessage(" verdirmek istediğin açıkmayaı yazabilirsin");


            // CROSS CUTTING CONCERN : LOG,CACHE,TRANSACTİON,AUTHORİZATİON
            // her katman için de yapılabilir(data access, business,uı)

        }
    }
}
