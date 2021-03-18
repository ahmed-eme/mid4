using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using mid4.Models;


namespace mid4.Controllers
{
    public class RestaurantController : Controller
    {
        BookTabledb dbop = new BookTabledb();
        // GET: Restaurant
        public ActionResult _RestaurantLayout()
        {
            return View();
        }

        [HttpPost]

        public ActionResult _RestaurantLayout([Bind] BookTableModels book)
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
