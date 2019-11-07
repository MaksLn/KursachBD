using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KursachBD.Models;
using KursachBD.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KursachBD.Controllers.AccountControllers
{
    public class AvatarController : Controller
    {
        [HttpGet]
        public IActionResult Photo([FromServices] DBContext dBContext)
        {
            try
            {
                var Name = RouteData.Values["Id"].ToString() == null ? "" : RouteData.Values["Id"].ToString();

                    try
                    {
                        var result = dBContext.Users.Where(e => e.UserName == Name).FirstOrDefault().Photo;

                        if (result != null)
                        {
                            return PartialView(new Avatar(result, Name));
                        }
                    }
                    catch
                    {
                        return PartialView(new Avatar(System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + @"\wwwroot\image\def.png"), Name));
                    }
            }
            catch
            {
                return PartialView(new Avatar(System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + @"\wwwroot\image\def.png"), "anonim"));
            }

            return PartialView(new Avatar(System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + @"\wwwroot\image\def.png"), "anonim"));
        }
    }
}