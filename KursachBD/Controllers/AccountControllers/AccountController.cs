using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachBD.Models;
using KursachBD.Models.DataBaseModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KursachBD.Controllers.AccountControllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;

        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ConfirmEmail([FromServices] DBContext dBContext, string userId, string code)
        {
            await _userManager.ConfirmEmailAsync(dBContext.Users.Find(userId), code);
            return View();
        }
    }
}