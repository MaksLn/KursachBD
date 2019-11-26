using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachBD.Models;
using KursachBD.Models.DataBaseModel;
using KursachBD.Models.ViewModel;
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
            if (RouteData.Values["Id"] == null||dBContext.Films.Where(e=>e.Id==Convert.ToInt32(RouteData.Values["Id"])).Count()==0)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new FilmViewModel();

            try
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    try
                    {
                        var user = dBContext.Users
                            .Include(e => e.UserStars)
                            .ThenInclude(e => e.UserFilm)
                            .Where(e => e.UserName == HttpContext.User.Identity.Name)
                            .FirstOrDefault().UserStars
                            .Where(e => e.UserFilm.FilmId == Convert.ToInt32(RouteData.Values["Id"]))
                            .FirstOrDefault();

                        var star = user.Star;
                        ViewData["checked" + star] = "checked";

                        ViewData["IsConfimEmail"] = user.User.EmailConfirmed;
                    }
                    catch(Exception x)
                    {
                        var user = await dBContext.Users
                            .Where(e => e.UserName == HttpContext.User.Identity.Name)
                            .FirstOrDefaultAsync();

                        ViewData["IsConfimEmail"] = user.EmailConfirmed;
                    }
                }

                var film = await dBContext.Films
                    .Include(e => e.FilmsToCountrys)
                    .ThenInclude(e => e.Country)
                    .Include(e => e.FilmsToGenres)
                    .ThenInclude(e => e.Genre)
                    .Include(e => e.MPAA)
                    .Include(e => e.Reting)
                    .Include(e => e.Year)
                    .Include(e => e.ParticipantsBuffers)
                    .ThenInclude(e => e.StatusParticipants)
                    .Include(e => e.ParticipantsBuffers)
                    .ThenInclude(e => e.Participant)
                    .Where(e => e.Id == Convert.ToInt32(RouteData.Values["Id"])).FirstOrDefaultAsync();

                var coments = await dBContext.Coment.Include(e => e.User).ToListAsync();

                model.Film = film;
                model.Coments = coments;
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");

            }

            return View(model);
        }
    }
}