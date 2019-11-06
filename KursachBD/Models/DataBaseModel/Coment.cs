using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class Coment
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;
        public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}
