using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ürün Adını Boş geçemezsiniz");
            RuleFor(x => x.Name).MinimumLength(50).WithMessage("Ürün adı en az 50 karakterli olmalıdır.");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stock sayısı boş geçilemez");
        }
    }
}
