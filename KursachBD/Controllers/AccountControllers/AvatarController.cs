using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursachBD.Models;
using KursachBD.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
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
                        return base.File(result, "image/png");
                    }
                }
                catch
                {
                    return base.File(System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + @"\wwwroot\image\def.png"), "image/png");
                }
            }
            catch
            {
                return base.File(System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + @"\wwwroot\image\def.png"), "image/png"); ;
            }

            return base.File(System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + @"\wwwroot\image\def.png"), "image/png");
        }
    }
}