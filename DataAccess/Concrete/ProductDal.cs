using DataAccess.Abstract;
using DataAccess.EntityFrameworkBase;
using DataEntity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class ProductDal : EntityRepository<Product, NorthwindContext>, IProductDal
    {
    }
}
