using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.ViewModel
{
    public class AddComentModel
    {
        [Required]
        public int FilmId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required()]
        public string Text { get; set; }
    }
}
