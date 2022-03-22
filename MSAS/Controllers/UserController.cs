using MSAS.Models.Users;
using MSAS.Services.ClientServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSAS.Extension;
using MSAS.Models.Login;
using MSAS.Core.UsersMgt;

namespace MSAS.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService uService)
        {
            this._userService = uService;
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            var model = new UsersViewModel();
            return View(model);
           
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UsersViewModel model)
        {
            try
            {
                if (model == null)
                    return View(model);
                var enter = model.ToEntity();
                _userService.Insert(enter);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.mss = ex.Message;
                return View();
            }
           
        }

        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(LoginViewModel model)
        {
            var ulog = _userService.LoginUser(model.Email, model.Password).ToList();
           if (ulog != null)
            {
                               
                foreach (var v in ulog)
                {
                    Session["EmailID"] = v.Email.ToString();
                    Session["UserID"] = v.UserId.ToString();
                    if (model.RememberMe == true)
                    {
                        HttpCookie cookie = new HttpCookie("Login");
                        cookie.Values.Add("EmailID", v.Email);
                        cookie.Values.Add("Password", v.Password);
                        cookie.Expires = DateTime.Now.AddDays(15);
                        Response.Cookies.Add(cookie);

                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
        }
    }
}
