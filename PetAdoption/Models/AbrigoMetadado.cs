using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    [MetadataType(typeof(AbrigoMetadado))]
    public partial class Abrigo { }

    public class AbrigoMetadado
    {
        [Required(ErrorMessage = "O nome do Abrigo é obrigatório.")]
        [StringLength(20, ErrorMessage = "O nome do Abrigo só pode ter 20 caracteres")]
        public string Nome { get; set; }
    }
}