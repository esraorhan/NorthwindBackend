using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            //validasyon kodlarımız bu kısıma yazılır. 
            _productDal.ADD(product);
        }

        public void Delete(Product product)
        {
            _productDal.DELETE(product);
        }

        public Product GetById(int productId)
        {
            return _productDal.GET(p => p.ProductId == productId);
        }

        public List<Product> GetList()
        {
            return _productDal.GETLIST();
        }

        public List<Product> GetListByCategory(int categoryId)
        {
            return _productDal.GETLIST(p => p.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            _productDal.UPDATE(product);
        }
    }
}
