using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Utilities
{
    public static class ValidationTool
    {
        public static ProductValidator _validatorProduct { get; set; }

        public static void ValidateProduct(Product p)
        {
            _validatorProduct = new ProductValidator();
            var result = _validatorProduct.Validate(p);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }

        }
    }
}

