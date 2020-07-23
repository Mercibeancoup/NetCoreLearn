using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreLearn.Models;

namespace NetCoreLearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //扩展方法，可以使用扩展功能
            if(string.IsNullOrWhiteSpace(this.HttpContext.Session.GetString("CurrentUserSession")))
            {
                base.HttpContext.Session.SetString("CurrentUserSession", Newtonsoft.Json.JsonConvert.SerializeObject(
                    new CurrentUser()
                    {
                        Id = 7,
                        Name = "测试",
                        Account = "jjjj",
                        Email = "Koke",
                        Password = "test",
                        LoginTime = DateTime.Now
                    }
                    ));
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
