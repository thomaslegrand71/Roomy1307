using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Models
{
    public class User
    {
        [Display]
        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public string Mail { get; set; }

        public DateTime BirthDate { get; set; }

        public string Password { get; set; }

        public string ConfirmedPassword { get; set; }
    }
}