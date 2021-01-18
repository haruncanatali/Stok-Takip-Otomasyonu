using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
