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
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Raca> Raca { get; set; }
        public DbSet<Especie> Especie { get; set; }
        public DbSet<Abrigo> Abrigo { get; set; }
        public DbSet<Porte> Porte { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
    }
}