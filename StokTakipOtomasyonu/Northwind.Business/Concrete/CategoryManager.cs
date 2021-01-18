using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Business.Abstract;
using Northwind.Entities.Concrete;
using Northwind.DataAccess.Abstract;


namespace Northwind.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _dal;

        public CategoryManager(ICategoryDal _d)
        {
            _dal = _d;
        }
        public List<Category> GetAll()
        {
            return _dal.GetAll();
        }
    }
}
