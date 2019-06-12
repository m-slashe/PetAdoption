using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    [MetadataType(typeof(RacaMetadado))]
    public partial class Raca { }

    public class RacaMetadado
    {

        [Required(ErrorMessage = "O nome da Raça é obrigatório.")]
        [StringLength(30, ErrorMessage = "O nome da Raça só pode ter 30 caracteres")]
        public string Nome { get; set; }

    }
}