using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachBD.Models;
using KursachBD.Models.DataBaseModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

namespace KursachBD.Controllers.FilmControllers
{
    public class FilmsController : Controller
    {
        private DBContext dBContext { get; set; }

        public FilmsController(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpGet]
        public async Task<IActionResult> Film()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var star = dBContext.Users
                    .Include(e => e.UserStars)
                    .ThenInclude(e => e.UserFilm)
                    .Where(e => e.UserName == HttpContext.User.Identity.Name)
                    .FirstOrDefaultAsync().Result.UserStars
                    .Where(e => e.UserFilm.FilmId == Convert.ToInt32(RouteData.Values["Id"]))
                    .FirstOrDefault().Star;

                ViewData["checked" + star] = "checked"; 
            }

            var film = await dBContext.Films
                .Include(e => e.FilmsToCountrys)
                .ThenInclude(e => e.Country)
                .Include(e => e.FilmsToGenres)
                .ThenInclude(e => e.Genre)
                .Include(e => e.MPAA)
                .Include(e => e.Reting)
                .Include(e => e.Year).Where(e => e.Id == Convert.ToInt32(RouteData.Values["Id"])).FirstOrDefaultAsync();

            return View(film);
        }
    }
}