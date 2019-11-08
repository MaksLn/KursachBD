using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KursachBD.Models;
using KursachBD.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace KursachBD.Controllers
{
    public class HomeController : Controller
    {
        private DBContext dBContext { get; set; }

        public HomeController (DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public IActionResult Index()
        {
            var db = dBContext.Films.Include(e => e.Reting).Include(e=>e.Year).Include(e=>e.FilmsToCountrys).ThenInclude(e=>e.Country);
            List<ListFilmModel> model = new List<ListFilmModel>();

            foreach(var i in db)
            {
                model.Add(new ListFilmModel() { Id = i.Id, Name = i.Name, Photo = i.Photo, Star = i.Reting.AllStar, Year = i.Year.Year,
                    Country = i.FilmsToCountrys.Where(e=>e.FilmId==i.Id).FirstOrDefault().Country.Name});
                model.Add(new ListFilmModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Photo = i.Photo,
                    Star = i.Reting.AllStar,
                    Year = i.Year.Year,
                    Country = i.FilmsToCountrys.Where(e => e.FilmId == i.Id).FirstOrDefault().Country.Name
                });
                model.Add(new ListFilmModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Photo = i.Photo,
                    Star = i.Reting.AllStar,
                    Year = i.Year.Year,
                    Country = i.FilmsToCountrys.Where(e => e.FilmId == i.Id).FirstOrDefault().Country.Name
                });
                model.Add(new ListFilmModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Photo = i.Photo,
                    Star = i.Reting.AllStar,
                    Year = i.Year.Year,
                    Country = i.FilmsToCountrys.Where(e => e.FilmId == i.Id).FirstOrDefault().Country.Name
                });
                model.Add(new ListFilmModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Photo = i.Photo,
                    Star = i.Reting.AllStar,
                    Year = i.Year.Year,
                    Country = i.FilmsToCountrys.Where(e => e.FilmId == i.Id).FirstOrDefault().Country.Name
                });
                model.Add(new ListFilmModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Photo = i.Photo,
                    Star = i.Reting.AllStar,
                    Year = i.Year.Year,
                    Country = i.FilmsToCountrys.Where(e => e.FilmId == i.Id).FirstOrDefault().Country.Name
                });
                model.Add(new ListFilmModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Photo = i.Photo,
                    Star = i.Reting.AllStar,
                    Year = i.Year.Year,
                    Country = i.FilmsToCountrys.Where(e => e.FilmId == i.Id).FirstOrDefault().Country.Name
                }); model.Add(new ListFilmModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Photo = i.Photo,
                    Star = i.Reting.AllStar,
                    Year = i.Year.Year,
                    Country = i.FilmsToCountrys.Where(e => e.FilmId == i.Id).FirstOrDefault().Country.Name
                });
                model.Add(new ListFilmModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Photo = i.Photo,
                    Star = i.Reting.AllStar,
                    Year = i.Year.Year,
                    Country = i.FilmsToCountrys.Where(e => e.FilmId == i.Id).FirstOrDefault().Country.Name
                });


            }

            return View(model);
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
