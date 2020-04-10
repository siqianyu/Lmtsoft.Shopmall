using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lmtsoft.Shopmall.Repository;
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
        private IBaseManagerService _baseManagerService;


        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IBaseManagerService BaseManagerService)
        {
            _logger = logger;
            _baseManagerService = BaseManagerService;

        }

        public IActionResult QueryBaseManager()
        {

            return View();
        }

        public IActionResult Index()
        {
            BaseManager BaseManager = new BaseManager
            {
                UserName = "13336677383",
                Telephone = "13336677383",
                RealName = "达西先森"
            };
            HttpContext.Session.Set<BaseManager>($"_{BaseManager.UserName}", BaseManager);
            return View();

        }

        public IActionResult Privacy()
        {
            string BaseManagerName = "13336677383";
            BaseManager BaseManager = HttpContext.Session.Get<BaseManager>($"_{BaseManagerName}");
            return new JsonResult(BaseManager);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
