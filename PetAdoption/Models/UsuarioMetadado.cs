using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{

    [MetadataType(typeof(UsuarioMetadado))]
    public partial class Usuario { }

    public class UsuarioMetadado
    {

        [Required(ErrorMessage = "O nome do Usuario é obrigatório.")]
        [StringLength(30, ErrorMessage = "O nome do Usuario só pode ter 30 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email do Usuario é obrigatório.")]
        [StringLength(50, ErrorMessage = "O email do Usuario só pode ter 50 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O email do Usuario é obrigatório.")]
        [StringLength(15, ErrorMessage = "A senha do Usuario só pode ter 15 caracteres")]
        public string Senha { get; set; }

    }
}