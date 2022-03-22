using MSAS.Core.ClientManagement;
using MSAS.Core.UsersMgt;
using MSAS.Services.ClientServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSAS.Controllers
{
    public class UsersController : Controller
    {
       /* private ILoginServices<Users> _loginService = null;

        public UsersController()
        {
            this._loginService = new LoginService<Users>();
        }
        //
        // GET: /Users/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Users u)
        {
            if (ModelState.IsValid)
            {
                var login = _loginService.signin(u);
                if (login != null)
                {

                    Session["UserID"] = u.UserId.ToString();
                    Session["mail"] = u.Email.ToString();
                    return RedirectToAction("CreateUser");
                   
                }
                else
                {
                    ViewBag.message = "Username or Password is not correct";
                }
            }
            else
            {

            }
            return View();
        }

        //
        // GET: /Users/Create
        public ActionResult CreateUser()
        {
            ViewBag.sess = Session["UserID"];
            return View();
        }

        //
        // POST: /Users/Create
        [HttpPost]
        public ActionResult CreateUser(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }*/
    }
}
