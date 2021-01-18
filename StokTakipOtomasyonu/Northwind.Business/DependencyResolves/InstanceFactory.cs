using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace Northwind.Business.DependencyResolves
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var _kernel = new StandardKernel(new BusinessModule());
            return _kernel.Get<T>();
        }
    }
}
