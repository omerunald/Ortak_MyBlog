using DataAccess.Abstract;
using DataBusiness.Abstract;
using DataEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBusiness.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetProducts()
        {
            return _productDal.GetList();
        }
    }
}
