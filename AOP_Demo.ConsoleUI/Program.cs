using AOP_Demo.Business.Abstract;
using AOP_Demo.Business.Concrete;
using AOP_Demo.DataAccess.Concrete.EntityFramework;
using AOP_Demo.DataAccess.Concrete.NHibernate;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService _productService=new ProductManager(new NhProductDal());
            foreach(var product in _productService.GetAll())
            {
                Console.WriteLine(product.Name);
            }
            Console.ReadLine();
        }
    }
}