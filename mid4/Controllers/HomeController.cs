using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using mid4.Models;

namespace mid4.Controllers
   
{


    public class HomeController : Controller
    {
        BookTabledb dbop = new BookTabledb();
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]

        public ActionResult Index([Bind] BookTableModels book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string res = dbop.savercord(book);
                    TempData["test"] = res;
                }

            }
            catch (Exception ex)
            {
                TempData["test"] = ex.Message;

            }




            return View();
        }
    }




}



        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

  
