using Roomy.Areas.BackOffice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Roomy.Models
{
    public class Room : BaseModel
    {
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name = "Nombre de place")]
        [Range(0, 50)]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [StringLength(50)]
        [Display(Name = "Libellé")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name = "Tarif")]
        [DataType(DataType.Currency)]
        public string Price { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name = "Date de création")]
        [DisplayFormat(DataFormatString = "{0:dddd dd MMMM yyyy}")]
        public string CreatedAt { get; set; }

        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }

        [Display(Name="Categorie")]
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Categorie Category { get; set; }

        public ICollection<RoomFile> Files { get; set; }
    }
}