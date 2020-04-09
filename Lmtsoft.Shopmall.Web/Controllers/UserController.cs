using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lmtsoft.Shopmall.Interface;
using Lmtsoft.Shopmall.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lmtsoft.Shopmall.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserService _userService;

        public UserController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;

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
            return View();
        }

        // GET: User/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(IFormCollection collection)
        {
            try
            {
                string userName = collection["Name"].ToString();
                string password = collection["Password"].ToString();
                if (_userService.Exsit(userName))
                {
                    return new JsonResult(new RspResult { Code = 100, Status = 1, Msg = "用户名已存在" });
                }
                User user = new User
                {
                    Name = userName,
                    Password = password
                };
                RspResult rsp = _userService.Save(user);
                // TODO: Add insert logic here
                return new JsonResult(rsp);
                //return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return new JsonResult(new
                {
                    Message = e.Message
                });
            }
        }

        // POST: User/Create
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

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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