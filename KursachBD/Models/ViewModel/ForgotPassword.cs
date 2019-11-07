using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.ViewModel
{
    public class ForgotPassword
    {
        [Required(ErrorMessage = "Заполните поле")]
        [EmailAddress(ErrorMessage = "Некоректный Email")]
        public string Email { get; set; }
    }
}
