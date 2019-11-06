using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class Reting
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public float UserStar { get; set; }
        public float AllStar { get; set; }
        public string Discription { get; set; }
        public List<Film> Films { get; set; }
    }
}
