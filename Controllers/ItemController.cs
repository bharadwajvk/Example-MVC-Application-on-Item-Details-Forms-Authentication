using ItemApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ItemApplication.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        [Authorize]
        public ActionResult Index()
        {
            ItemRepository r = new ItemRepository();
            return View(r.ItemData());
        }

   
        public ActionResult Login()
        {
            return View();
        }

       
        public ActionResult LoginSubmit(string userName, string password)
        {
            bool flag = false;  
            DatabaseEntities db = new DatabaseEntities();
            var list = db.LoginDetails.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].UserName.Trim() ==userName && list[i].Password.Trim() ==password)
                {
                    FormsAuthentication.SetAuthCookie(userName, false);
                    Session["sign"] = "in";
                    Session["message"] = userName;
                    flag = true;
                }
            }

            if (flag)
            {
                return RedirectToAction("Index", "Item");
            }
            else
            {
                return RedirectToAction("Login", "Item");
            }
        }

        public ActionResult LogOff()
        {
            Session["sign"] = "out";
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}