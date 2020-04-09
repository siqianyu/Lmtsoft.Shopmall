using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lmtsoft.Shopmall.Web.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            //是否已登入
        }
        // GET: Base
        public ActionResult Index()
        {
            return View();
        }

        // GET: Base/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Base/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Base/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Base/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Base/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Base/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Base/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}