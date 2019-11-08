using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KursachBD.Models;
using KursachBD.Models.DataBaseModel;
using KursachBD.Models.ViewModel;
using KursachBD.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace KursachBD.Controllers.AccountControllers
{
    public class RegistrController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public RegistrController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Registr()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registr(RegistrModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User { Email = model.Email, UserName = model.Name, Year = new DateTime(model.Year, 1, 1), StatusComentId = 1 };

                if (model.Avatar != null&&(model.Avatar.ContentType=="image/png" || model.Avatar.ContentType == "image/jpeg"))
                {
                    byte[] imageData = null;
                    using (var binaryReader = new BinaryReader(model.Avatar.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)model.Avatar.Length);
                    }
                    user.Photo = imageData;
                }

                var result = await _userManager.CreateAsync(user, model.Password);
                await _userManager.AddToRoleAsync(user, "user");
                if (result.Succeeded)
                {
                    await SendCode(user, _userManager, model.Email);

                    await _signInManager.SignInAsync(user, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        private async Task SendCode(User user, UserManager<User> _userManager, string email)
        {
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Action(
                "ConfirmEmail",
                "Account",
                new { userId = user.Id, code = code },
                protocol: HttpContext.Request.Scheme);
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(email, "Подтверждение регистрации",
                $"Подтвердите регистрацию, перейдя по ссылке: <a href='{callbackUrl}'>подтвердить</a>");

        }
    }
}