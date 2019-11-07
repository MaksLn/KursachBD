using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.ViewModel
{
    public class Avatar
    {
        public Avatar(byte[] photo, string name)
        {
            Photo = photo;
            Name = name;
        }

        public byte[] Photo { get; set; }
        public string Name { get; set; }
    }
}
