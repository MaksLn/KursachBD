using KursachBD.Models;
using KursachBD.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Service
{
    public class GetAllYear
    {
        private DBContext dBContext { get; set; }

        public GetAllYear(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public async Task<List<CreateYear>> GetYearsAsync()
        {
            return await dBContext.CreateYear.ToListAsync();
        }
    }
}
