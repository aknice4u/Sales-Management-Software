using MSAS.Models.StateLGA;
using MSAS.Services.StateLGAServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSAS.Extension;

namespace MSAS.Controllers
{
    public class StateLGAController : Controller
    {
         private IStateService _stateService;
         private ILGAService _lgaService;
        public StateLGAController(IStateService stateService,ILGAService lgaService)
        {
            this._stateService = stateService;
            this._lgaService = lgaService;
        }
        // GET: StateLGA
        public ActionResult Index()
        {
            return View();
        }

        // GET: StateLGA/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult States()
        {
            var model = new StateViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult States(StateViewModel mode)
        {
            try
            {
                if (mode == null)
                    return View(mode);
                var enter = mode.ToEntity();
                _stateService.Insert(enter);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.mss = ex.Message;
                return View();
            }
            
        }


        public ActionResult LGAs()
        {
            var model = new LGAViewModel();
            var states = _stateService.GetAll();       
            ViewBag.StateId = new SelectList(states, "StateId", "StateName");
            return View(model);
        }

        [HttpPost]
        public ActionResult LGAs(LGAViewModel mode)
        {
            try
            {
                if (mode == null)
                    return View(mode);
                var enter = mode.ToEntity();
                _lgaService.Insert(enter);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.mss = ex.Message;
                return View();
            }

        }

        // GET: StateLGA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StateLGA/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: StateLGA/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StateLGA/Edit/5
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

        // GET: StateLGA/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StateLGA/Delete/5
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
