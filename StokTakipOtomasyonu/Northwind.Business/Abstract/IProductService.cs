using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetProductByCategory(int categoryId);
        List<Product> GetProductByProductName(string productName);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
