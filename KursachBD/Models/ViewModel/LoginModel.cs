﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.ViewModel
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Заполните поле")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Некоректный Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Заполните поле")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
