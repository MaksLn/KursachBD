using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.ViewModel
{
    public class RegistrModel
    {
        [Required(ErrorMessage ="Заполните поле")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Некоректный Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [Display(Name = "Имя")]
        [MinLength(4, ErrorMessage = "Имя должно состаять из 4-14 символов")]
        [MaxLength(14, ErrorMessage = "Имя должно состаять из 4-14 символов")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [Display(Name = "Год рождения")]
        [Range(1950, 2010, ErrorMessage = "1950 - 2010")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [MinLength(6, ErrorMessage = "Пароль должен состоять мининмум из 6 символов")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
        [Display(Name = "Аватар")]
        public IFormFile Avatar { get; set; }

    }
}
