using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class Genre
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string GenersName { get; set; }
        public List<FilmsToGenres> FilmsToGenres { get; set; }
    }
}
