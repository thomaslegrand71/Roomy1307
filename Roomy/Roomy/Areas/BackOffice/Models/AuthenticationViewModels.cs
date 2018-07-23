﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Areas.BackOffice.Models
{
    public class AuthenticationLoginViewModel //View de l'action login sur le controller authentication
    {
        [Display(Name ="Adresse Mail")]
        [Required(ErrorMessage ="Le champ {0} est requis")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = "L'adresse mail n'est pas au bon format")]
        public string Login { get; set; }

        [Display(Name = "Mot de passe")]
        [Required(ErrorMessage = "Le champ {0} est requis")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }


}