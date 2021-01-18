using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal:IProductDal
    {
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> l = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    CategoryId = 1,
                    ProductName = "Hello",
                    QuantityPerUnit = "World",
                    UnitPrice = 99.9m,
                    UnitsInStock = 99
                },
                new Product
                {
                    ProductId = 2,
                    CategoryId = 2,
                    ProductName = "Hello2",
                    QuantityPerUnit = "World2",
                    UnitPrice = 99.9m,
                    UnitsInStock = 99
                },
                new Product
                {
                    ProductId = 3,
                    CategoryId = 3,
                    ProductName = "Hello3",
                    QuantityPerUnit = "World3",
                    UnitPrice = 99.9m,
                    UnitsInStock = 99
                },
                new Product
                {
                    ProductId = 4,
                    CategoryId = 4,
                    ProductName = "Hello4",
                    QuantityPerUnit = "World4",
                    UnitPrice = 99.9m,
                    UnitsInStock = 99
                },
            };
            return l;
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
