//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetAdoption.Models
{
    using System;

    public partial class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Nullable<System.DateTime> DataDeNascimento { get; set; }
        public string Sexo { get; set; }
        public string Historia { get; set; }
        public Nullable<int> IdRaca { get; set; }
        public Nullable<int> IdEspecie { get; set; }
        public Nullable<int> IdPorte { get; set; }
        public Nullable<int> IdAbrigo { get; set; }
    
        public virtual Abrigo Abrigo { get; set; }
        public virtual Especie Especie { get; set; }
        public virtual Porte Porte { get; set; }
        public virtual Raca Raca { get; set; }
    }
}
