using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Data.Entidades
{
    [MetadataType(typeof(Dependente_Metadata))]
    public class dependente
    {
        public int dependente_id { get; set; }
        public string nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public int parentesco { get; set; }
        public int funcionario_id { get; set; }
        public List<funcionario> funcionario { get; internal set; }
    }

    public class Dependente_Metadata
    {
        [Key]
        public int dependente_id { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        [Display(Name="Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Data de Nascimento é obrigatório.")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime data_nascimento { get; set; }

        [Required(ErrorMessage = "Campo Grau de Parentesco é obrigatório.")]
        [Display(Name = "Grau de Parentesco")]
        public int parentesco { get; set; }

        [Required(ErrorMessage = "Campo Funcionário é obrigatório.")]
        [Display(Name = "Funcionário")]
        public int funcionario_id { get; set; }
    }
}
