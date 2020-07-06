using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachBD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KursachBD.Controllers.FilmControllers
{
    public class AvtorController : Controller
    {
        private DBContext dBContext { get; set; }

        public AvtorController(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var user = dBContext.Users
                           .Where(e => e.UserName == HttpContext.User.Identity.Name)
                           .FirstOrDefault();

                ViewData["IsConfimEmail"] = user.EmailConfirmed;
            }
            var result = await dBContext.Participants
                .Include(e => e.ParticipantsBuffers).ThenInclude(e=>e.Film).Where(e=>e.Id==id).FirstOrDefaultAsync();
            var coments = await dBContext.AvtorComent.Include(e => e.User).Where(e =>e.Id == result.Id).ToListAsync();
            result.AvtorComents = coments;
            
            return View("Views/Avtor/View.cshtml",result);
        }
    }
}