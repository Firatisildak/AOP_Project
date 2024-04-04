using AOP_Demo.DataAccess.Abstract;
using AOP_Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP_Demo.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product> 
            { 
                new Product
                {
                    Id = 1, Name="Laptop"
                },
                new Product
                {
                    Id = 2, Name="Mouse"
                }
            };
        }
    }
}
