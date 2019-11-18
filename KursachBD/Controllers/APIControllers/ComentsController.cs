using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachBD.Models;
using KursachBD.Models.DataBaseModel;
using KursachBD.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KursachBD.Controllers.APIControllers
{
    public class ComentsController : Controller
    {
        private DBContext dBContext { get; set; }

        public ComentsController(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddComents(AddComentModel comentModel)
        {
            if (ModelState.IsValid)
            {
                dBContext.Coment.Add(new Coment()
                {
                    DateTime = DateTime.Now,
                    FilmId = comentModel.FilmId,
                    Text = comentModel.Text,
                    User = dBContext.Users.Where(e => e.UserName == comentModel.Name).FirstOrDefault()
                });

                await dBContext.SaveChangesAsync();
            }

            return RedirectToAction("Film", "Films", new {Id = comentModel.FilmId });
        }
    }
}