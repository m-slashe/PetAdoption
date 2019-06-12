using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    [MetadataType(typeof(PorteMetadado))]
    public partial class Porte { }

    public class PorteMetadado
    {

        [Required(ErrorMessage = "O nome do Porte é obrigatório.")]
        [StringLength(20, ErrorMessage = "O nome do Porte só pode ter 20 caracteres")]
        public string Nome { get; set; }

    }
}