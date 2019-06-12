using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    [MetadataType(typeof(PetMetadado))]
    public partial class Pet { }

    public class PetMetadado
    {

        [Required(ErrorMessage = "O nome do Pet é obrigatório.")]
        [StringLength(30, ErrorMessage = "O nome do Pet só pode ter 30 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O nome do Pet é obrigatório.")]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "O nome do Pet é obrigatório.")]
        [StringLength(1, ErrorMessage = "O sexo do Pet só pode ter 1 caracteres")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "A História do Pet é obrigatório.")]
        [StringLength(400, ErrorMessage = "A História do Pet só pode ter 400 caracteres")]
        public string Historia { get; set; }

        [Required(ErrorMessage = "A Raça do Pet é obrigatório.")]
        public int IdRaca { get; set; }

        [Required(ErrorMessage = "A Especie do Pet é obrigatório.")]
        public int IdEspecie { get; set; }

        [Required(ErrorMessage = "O Porte do Pet é obrigatório.")]
        public int IdPorte { get; set; }

        [Required(ErrorMessage = "O Abrigo do Pet é obrigatório.")]
        public int IdAbrigo { get; set; }
    }
}