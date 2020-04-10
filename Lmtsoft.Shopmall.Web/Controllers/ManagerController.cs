using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lmtsoft.Shopmall.Interface;
using Lmtsoft.Shopmall.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETCore.Encrypt;
using Lmtsoft.Shopmall.Common;
using Microsoft.AspNetCore.Authorization;

namespace Lmtsoft.Shopmall.Web.Controllers
{
    public class ManagerController : Controller
    {
        private readonly ILogger<ManagerController> _logger;
        private IBaseManagerService _managerService;

        public ManagerController(ILogger<ManagerController> logger, IBaseManagerService managerService)
        {
            _logger = logger;
            _managerService = managerService;

        }
        // GET: User
        public ActionResult Index()
        {
            var manager = _managerService.Query();
            ViewData.Model = manager;
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

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        
        public ActionResult SignIn()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(IFormCollection collection)
        {
            try
            {
                string userName = collection["UserName"].ToString();
                string password = collection["Password"].ToString();
                if (!_managerService.Exsit(userName))
                {
                    return new JsonResult(new RspResult { Code = 100, Status = 1, Msg = "用户名不存在" });
                }

                BaseManager user = _managerService.QueryByName(userName);

                string pwd = Utils.MD5(password);
                if (!pwd.Equals(user.Password))
                {
                    return new JsonResult(new RspResult { Code = 100, Status = 1, Msg = "密码不正确" });
                }
                return new JsonResult(new RspResult { Code = 100, Status = 1, Msg = "登录成功" });
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
       
        public ActionResult Register(IFormCollection collection)
        {
            try
            {
                string userName = collection["UserName"].ToString();
                string password = collection["Password"].ToString();
                if (_managerService.Exsit(userName))
                {
                    return new JsonResult(new RspResult { Code = 100, Status = 1, Msg = "用户名已存在" });
                }

                BaseManager user = new BaseManager
                {
                    UserName = userName,
                    Password = password,
                    DepartmentId = "35"

                };
                user.Password = Utils.MD5(user.Password);

                RspResult rsp = _managerService.Save(user);

                return new JsonResult(rsp);
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