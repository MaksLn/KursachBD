using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class ParticipantsBuffer
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int StatusParticipantsId { get; set; }
        public StatusParticipants StatusParticipants { get; set; }
        public int ParticipantsId { get; set; }
        public Participants Participant { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}
