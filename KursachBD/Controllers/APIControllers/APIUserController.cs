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
using OfficeOpenXml;
using OfficeOpenXml.Style;

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
                        user.UserStars.Add(new UserStar()
                        {
                            Star = null,
                            UserFilm = new UserFilm()
                            { FilmId = Convert.ToInt32(filmId), StatusViewId = status.GetIdStatus() }
                        });

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

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UpdateDiscription(string filmId, string text)
        {
            var userId = RouteData.Values["id"].ToString();

            var user = await dBContext.Users.Include(e => e.UserStars)
                .ThenInclude(e => e.UserFilm)
                .Where(e => e.UserName == userId)
                .FirstOrDefaultAsync();

            try
            {
                user.UserStars.Where(e => e.UserFilm.FilmId == Convert.ToInt32(filmId)).FirstOrDefault().UserFilm.Discription = text;
                dBContext.Users.Update(user);
                await dBContext.SaveChangesAsync();

            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return Ok();
        }

        public async Task<IActionResult> GetExcelFilms()
        {
            var userInfo = await dBContext.Users.Include(e => e.UserStars).ThenInclude(e => e.UserFilm)
  .ThenInclude(e => e.StatusView).ThenInclude(e => e.UserFilms).ThenInclude(e => e.Film).ThenInclude(e => e.Reting)
  .Where(e => e.UserName == HttpContext.User.Identity.Name).FirstOrDefaultAsync();

            byte[] result;

            using(var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("List");

                worksheet.Cells[1, 1].Value = "Название";
                worksheet.Cells[1, 2].Value = "Заметка";
                worksheet.Cells[1, 3].Value = "Продолжительность";
                worksheet.Cells[1, 4].Value = "Рейтинг пользователей";
                worksheet.Cells[1, 5].Value = "Рейтинг в мире";

                int count = 2;

                foreach(var i in userInfo.UserStars)
                {
                    worksheet.Cells[count, 1].Value = i.UserFilm.Film.Name;
                    worksheet.Cells[count, 2].Value = i.UserFilm.Discription;
                    worksheet.Cells[count, 3].Value = i.UserFilm.Film.Time.Minute + i.UserFilm.Film.Time.Hour * 60+" мин";
                    worksheet.Cells[count, 4].Value = i.UserFilm.Film.Reting.UserStar;
                    worksheet.Cells[count, 5].Value = i.UserFilm.Film.Reting.AllStar;

                    count++;
                }

                worksheet.DefaultColWidth = 25;

                package.DoAdjustDrawings = false;

                result = package.GetAsByteArray();
            }

            return File(result, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Фильмы.xlsx");
        }

    }
}