using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lmtsoft.Shopmall.Models;
using Lmtsoft.Shopmall.Service;
using Lmtsoft.Shopmall.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Lmtsoft.Shopmall.Web.Utity.Extensions;

namespace Lmtsoft.Shopmall.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserService _userService;


        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IUserService userService)
        {
            _logger = logger;
            _userService = userService;

        }

        public IActionResult QueryUser()
        {

            return View();
        }

        public IActionResult Index()
        {
            User user = new User
            {
                Name = "13336677383",
                Mobile = "13336677383",
                NickName = "达西先森"
            };
            HttpContext.Session.Set<User>($"_{user.Name}", user);
            return View();

        }

        public IActionResult Privacy()
        {
            string userName = "13336677383";
            User user = HttpContext.Session.Get<User>($"_{userName}");
            return new JsonResult(user);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
