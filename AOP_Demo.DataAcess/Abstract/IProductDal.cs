using AOP_Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP_Demo.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
    }
}
