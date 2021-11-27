using DataAccess.Abstract;
using DataAccess.EntityFrameworkBase;
using DataEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class CategoryDal : EntityRepository<Category, NorthwindContext>, ICategoryDal
    {
    }
}
