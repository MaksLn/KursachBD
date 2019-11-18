using KursachBD.Models.DataBaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.ViewModel
{
    public class FilmViewModel
    {
        public Film Film { get; set; }
        public List<Coment> Coments { get; set; }
        public StatusComent StatusComent { get; set; }
    }
}
