using AslamAssign.Dal;
using AslamAssign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AslamAssign.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            CategoryDal catdal = new CategoryDal();
            List<Categories> catlist = catdal.CategoriesList();

            ProductDal dal = new ProductDal();
            List<Products> list = dal.ProductList();

            // MyViewModel viewModel = new MyViewModel();
            // viewModel.productsList = list;//first table content
            //viewModel.categoryList = catlist;//second table content
            ViewBag.catlist = catlist;
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}