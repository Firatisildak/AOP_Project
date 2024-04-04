using AOP_Demo.Business.Abstract;
using AOP_Demo.DataAccess.Abstract;
using AOP_Demo.Entities.Concrete;
using Core.Aspects.Logging;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP_Demo.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [LogAspect]
        public List<Product> GetAll()
        {
            //iş kodları
            return _productDal.GetAll();
        }
    }
}
