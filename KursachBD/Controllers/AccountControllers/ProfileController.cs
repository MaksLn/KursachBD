using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachBD.Models;
using KursachBD.Models.DataBaseModel;
using KursachBD.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KursachBD.Controllers.AccountControllers
{
    public class ProfileController : Controller
    {
        private DBContext dBContext { get; set; }

        public ProfileController(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index(string param = "")
        {
            var userInfo = await dBContext.Users.Include(e => e.UserStars).ThenInclude(e => e.UserFilm)
   .ThenInclude(e => e.StatusView).ThenInclude(e => e.UserFilms).ThenInclude(e => e.Film).ThenInclude(e => e.Reting)
   .Where(e => e.UserName == HttpContext.User.Identity.Name).FirstOrDefaultAsync();

            switch (param)
            {
                case "⧗ Хочу смотреть":
                    {
                        userInfo.UserStars = userInfo.UserStars.Where(x => x.UserFilm.StatusView.Status == "⧗ Просмотреть позже").ToList();
                        ViewData["id"] = 11;
                        break;
                    }
                case "★ Понравившиeся":
                    {
                        userInfo.UserStars = userInfo.UserStars.Where(x => x.UserFilm.StatusView.Status == "★ Понравившийся").ToList();
                        ViewData["id"] = 12;
                        break;
                    }
                case "✓ Просмотренные":
                    {
                        userInfo.UserStars = userInfo.UserStars.Where(x => x.UserFilm.StatusView.Status == "✓ Смотрел").ToList();
                        ViewData["id"] = 13;
                        break;
                    }
                default:
                    {
                        ViewData["id"] = 10;
                        break;
                    }
            }

            ProfileViewModel profileViewModel = new ProfileViewModel() { UserStar = userInfo.UserStars };
            return View(profileViewModel);
        }
    }
}