using AOP_Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP_Demo.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
