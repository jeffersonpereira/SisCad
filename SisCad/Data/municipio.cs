using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SisCadLibrary.Data
{
    [MetadataType(typeof(Municipio_Metadata))]
    public class municipio
    {
        public override string ToString()
        {
            return string.Format("({0}{1})",this.uf,this.nome);
        }
        public int municipio_id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }
        public virtual ICollection<empresa> empresa { get; internal set; }
        public virtual ICollection<funcionario> funcionario { get; internal set; }
        public virtual ICollection<funcionario> funcionario_naturalidade { get; internal set; }
    }

    public class Municipio_Metadata
    {
        [Key]
        public int municipio_id { get; set; }

        [Required(ErrorMessage="Campo Nome é obrigatório.")]
        [Display(Name="Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo UF é obrigatório.")]
        [Display(Name = "UF")]
        [StringLength(2,ErrorMessage="Tamanho máximo é de 2 caracteres.")]
        public string uf { get; set; }
    }
}
