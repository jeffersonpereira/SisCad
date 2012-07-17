using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SisCadLibrary.Data
{
    [MetadataType(typeof(Empresa_Metadata))]
    public partial class empresa
    {
        public int empresa_id { get; set; }
        public string razao_social { get; set; }
        public string caminho_logo { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public municipio municipio { get; set; }
        public int municipio_id { get; set; }
        public virtual List<funcionario> funcionario { get; set; }
    }

    public class Empresa_Metadata
    {
        [Key]
        public int empresa_id { get; set; }

        [Required(ErrorMessage="Campo Razão Social é obrigatório.")]
        [Display(Name="Razão Social")]
        public string razao_social { get; set; }
        
        [Required(ErrorMessage="Campo CNPJ é obrigatório.")]
        [Range(11,14,ErrorMessage="O campo deve possuir mínimo de 11 e máximo de 14 caracteres.")]
        [Display(Name = "CNPJ/CEI/CPF")]
        public string cnpj { get; set; }

        [Required(ErrorMessage = "Campo Município é obrigatório.")]
        [Display(Name = "Município")]
        public municipio municipio { get; set; }
        public int municipio_id { get; set; }
    }
}
