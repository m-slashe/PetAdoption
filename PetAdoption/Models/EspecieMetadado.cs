using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    [MetadataType(typeof(EspecieMetadado))]
    public partial class Especie { }

    public class EspecieMetadado
    {

        [Required(ErrorMessage = "O nome do Especie é obrigatório.")]
        [StringLength(30, ErrorMessage = "O nome do Especie só pode ter 30 caracteres")]
        public string Nome { get; set; }

    }
}