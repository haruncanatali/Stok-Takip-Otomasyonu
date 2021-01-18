using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(c => c.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Olamaz");


            RuleFor(c => c.CategoryId).NotEmpty().GreaterThan(0);


            RuleFor(c => c.UnitPrice).NotEmpty().GreaterThan(10).When(c=>c.CategoryId==2).WithMessage("Kategori Id = 2 Olan Ürünler 10 Liradan Yüksek Olmalı!");


            RuleFor(c => c.QuantityPerUnit).NotEmpty();


            RuleFor(c => c.UnitsInStock).NotEmpty().GreaterThanOrEqualTo((short)0);


            ////
            RuleFor(c => c.ProductName).Must(startsWith).WithMessage("Ürün Adı \'U\' İle Başlamalı!");
        }

        private bool startsWith(string arg)
        {
            return arg.StartsWith("U");
        }
    }
}
