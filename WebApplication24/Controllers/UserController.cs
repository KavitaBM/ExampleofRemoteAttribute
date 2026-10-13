using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication24.Models;

namespace WebApplication24.Controllers
{
    public class UserController : Controller
    {
        ContextCls obj=new ContextCls();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var temp=obj.Countries.ToList<Country>();
            ViewBag.CountryList=temp;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                obj.Users.Add(user);
                obj.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult CheckUsername(string Username)
        {
            bool IsValid;
            var results=obj.Users.SingleOrDefault<User>(x=>x.UserName==Username);
            if(results==null)
                IsValid=true;
            else
            {
                IsValid=false;
            }
            return Json(IsValid,JsonRequestBehavior.AllowGet);
        }
        
    }
}