using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;

namespace Blog.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            t_users userModel = new t_users();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(t_users userModel)
        {
            using (DBmodels dbModel = new DBmodels())
            {
                dbModel.t_users.Add(userModel);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successfull";
            return View("AddOrEdit" , new t_users());

        }

    }
}