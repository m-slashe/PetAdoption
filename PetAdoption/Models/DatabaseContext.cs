using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(): base("name=DatabaseContext"){}
        public DbSet<Usuario> Usuario { get; set; }
    }
}