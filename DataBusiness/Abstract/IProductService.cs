using DataEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBusiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
