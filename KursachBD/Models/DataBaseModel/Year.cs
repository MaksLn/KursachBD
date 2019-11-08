using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class CreateYear
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int Year { get; set; }
        public List<Film> Films { get; set; }
    }
}
