using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.ViewModel
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage = "Заполните поле")]
        [EmailAddress(ErrorMessage = "Некоректный Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Заполните поле")]
        [DataType(DataType.Password)]
        [Display(Name = "Новый пароль")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердите пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
