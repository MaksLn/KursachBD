using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.ViewModel
{
    public class ListFilmModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Star { get; set; }
        public string Photo { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
    }
}
