using DataAccess.Abstract;
using DataBusiness.Abstract;
using DataEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBusiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;
        
        public CategoryManager(ICategoryDal category) // Constructor - Yapıcı fonkisyon
        {
            categoryDal = category;
        }
        public List<Category> GetCategories()
        {
            return categoryDal.GetList();
        }
    }
}
