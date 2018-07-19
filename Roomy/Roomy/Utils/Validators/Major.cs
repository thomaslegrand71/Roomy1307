﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Utils.Validators
{
    public class Major : ValidationAttribute
    {
        public int years;

        public Major (int years)
        {
            this.years = years;
        }

        public override bool IsValid(object value)
        {
            if (value is DateTime)
            {
                DateTime dt = (DateTime)value;
                return dt.AddYears(18) <= DateTime.Now;
            }

            return false;
        }
    }
}