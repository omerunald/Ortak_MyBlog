using DataAccess.Concrete;
using DataBusiness.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());

        public IActionResult Index()
        {
            return View(categoryManager.GetCategories());
        }
    }
}
