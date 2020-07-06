using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class AvtorComent
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;
        public int AvtorId { get; set; }
        public Participants Avtor { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
