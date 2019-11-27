using KursachBD.Models;
using KursachBD.Models.DataBaseModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Service
{
    public class GetAllGanre
    {
        private DBContext dBContext { get; set; }

        public GetAllGanre(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public async Task<List<Genre>> GetGenresAsync()
        {
            return await dBContext.Genre.ToListAsync();
        }
    }
}
