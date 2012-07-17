using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SisCadLibrary.Data
{
    [MetadataType(typeof(Usuario_Metadata))]
    public class usuario
    {
        public int usuario_id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
    }

    public class Usuario_Metadata
    {
        [Key]
        public int usuario_id { get; set; }

        [Required(ErrorMessage="Campo Nome é obrigatório.")]
        [Display(Name="Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Login é obrigatório.")]
        [Display(Name = "Login")]
        public string login { get; set; }

        [Required(ErrorMessage = "Campo Senha é obrigatório.")]
        [Display(Name = "Senha")]
        public string senha { get; set; }
    }
}
