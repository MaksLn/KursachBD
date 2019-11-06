using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class Country
    {
        public Country()
        {
            FilmsToCountrys = new List<FilmsToCountrys>();
        }

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<FilmsToCountrys> FilmsToCountrys { get; set; }
    }
}
