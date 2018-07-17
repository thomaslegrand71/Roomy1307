﻿using Roomy.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Roomy.Migrations
{
    public class Configuration : DbMigrationsConfiguration<RoomyDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RoomyDbContext context)
        {
            context.Civilities.AddOrUpdate(
                new Models.Civility { Label = "Madame" },
                new Models.Civility { Label = "Mademoiselle" },
                new Models.Civility { Label = "Monsieur" });



        }
    }

    
}