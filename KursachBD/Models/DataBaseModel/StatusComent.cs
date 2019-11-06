using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class StatusComent
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Status { get; set; }
        public List<User> Users { get; set; }
    }
}
