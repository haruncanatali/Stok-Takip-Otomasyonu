using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _dal;

        public ProductManager(IProductDal p)
        {
            _dal = p;
        }

        public List<Product> GetAll()
        {
            return _dal.GetAll();
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            return _dal.GetAll(c => c.CategoryId == categoryId);
        }

        public List<Product> GetProductByProductName(string productName)
        {
            return _dal.GetAll(c => c.ProductName.Contains(productName));
        }

        public void AddProduct(Product product)
        {
            ValidationTool.ValidateProduct(product);
            _dal.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            ValidationTool.ValidateProduct(product);
            _dal.Update(product);
        }

        public void DeleteProduct(Product product)
        {
            _dal.Delete(product);
        }
    }
}
