using Roomy.Areas.BackOffice.Models;
using Roomy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Roomy.Data
{
    public class RoomyDbContext :DbContext
    {
        public RoomyDbContext() : base("roomydb")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Civility> Civilities { get; set; }

        public System.Data.Entity.DbSet<Roomy.Models.Room> Rooms { get; set; }

        public System.Data.Entity.DbSet<Roomy.Areas.BackOffice.Models.Categorie> Categories { get; set; }

        //public DbSet<Categorie> Categories { get; set; }
    }
}