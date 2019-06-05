using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    public class Pet
    {

        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public String Historia { get; set; }
        public int IdSexo { get; set; }
        [ForeignKey("IdSexo")]
        public Sexo Sexo { get; set; }
        public int IdRaca { get; set; }
        [ForeignKey("IdRaca")]
        public Raca Raca { get; set; }
        public int IdEspecie { get; set; }
        [ForeignKey("IdEspecie")]
        public Especie Especie { get; set; }
        public int IdPorte { get; set; }
        [ForeignKey("IdPorte")]
        public Porte Porte { get; set; }
        public int IdAbrigo { get; set; }
        [ForeignKey("IdAbrigo")]
        public Abrigo Abrigo { get; set; }

    }
}