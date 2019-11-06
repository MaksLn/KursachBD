using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KursachBD.Controllers.AccountControllers
{
    public class LoginingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}