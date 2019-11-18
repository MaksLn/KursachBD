using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachBD.Models;
using KursachBD.Models.DataBaseModel;
using KursachBD.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KursachBD.Controllers.APIControllers
{
    public class APIUserController : Controller
    {
        private DBContext dBContext { get; set; }

        public APIUserController(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddFilm(string filmId, string status)
        {
            var userId = RouteData.Values["id"].ToString();

            var user = await dBContext.Users.Include(e => e.UserStars)
                .ThenInclude(e => e.UserFilm)
                .ThenInclude(e => e.StatusView)
                .Where(e => e.UserName == userId)
                .FirstOrDefaultAsync();

            if (user != null)
            {
                try
                {
                    if (user.UserStars.Where(e => e.UserFilm.FilmId == Convert.ToInt32(filmId)).Count() > 0)
                    {
                        user.UserStars.Where(e => e.UserFilm.FilmId == Convert.ToInt32(filmId)).FirstOrDefault()
                            .UserFilm.StatusViewId = status.GetIdStatus();

                        dBContext.Users.Update(user);
                        await dBContext.SaveChangesAsync();
                    }
                    else
                    {
                        user.UserStars.Add(new UserStar() { Star = null, UserFilm = new UserFilm()
                        { FilmId = Convert.ToInt32(filmId), StatusViewId = status.GetIdStatus()} });

                        dBContext.Users.Update(user);
                        await dBContext.SaveChangesAsync();
                    }

                }
                catch (Exception e)
                {
                    return BadRequest();
                }
            }
            else
            {
                return NotFound();
            }

            return Ok();
        }
    }
}