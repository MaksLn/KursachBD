using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class Participants
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Year { get; set; }
        public string Photo { get; set; }
        public string Home { get; set; }
        public string WriteYear { get; set; }
        public string Title { get; set; }
        public string Href { get; set; }
        public List<ParticipantsBuffer> ParticipantsBuffers { get; set; }
        public List<AvtorComent> AvtorComents { get; set; }
    }
}
