using Roomy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Roomy.Areas.BackOffice.Models
{
    public class Categorie : BaseModel
    {

        [Required(ErrorMessage ="Le champ{0} est obligatoire")]
        [Display(Name ="Catégorie")]
        public string Name { get; set; }

        
    }
}