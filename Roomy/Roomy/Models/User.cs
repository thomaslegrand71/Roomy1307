using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Roomy.Models
{
    public class User : BaseModel
    {
        
        [Required(ErrorMessage = "Le champ civilité est obligatoire")]
        [Display(Name = "Civilité")]
        public int CivilityID { get; set; }
        [ForeignKey("CivilityID")]
        public Civility Civility { get; set; }

        [Required(ErrorMessage = "Le champ nom est obligatoire")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le champ {0} doit contenir entre {2} et {1} caractères")]
        [Display(Name = "Name")]
        public string Lastname { get; set; }

        [Display(Name = "Firstname")]
        public string Firstname { get; set; }

        [Display(Name = "Mail")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = "L'adresse mail n'est pas au bon format")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name = "BirthDate")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name = "Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}",
                           ErrorMessage = "Le mot de passe n'est pas au bon format")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "ConfirmedPassword")]
        [Compare("Password", ErrorMessage = "Erreur sur la confirmation du mot de passe")]
        [DataType(DataType.Password)]
        public string ConfirmedPassword { get; set; }
    }
}