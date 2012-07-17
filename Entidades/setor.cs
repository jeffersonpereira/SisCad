using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Data.Entidades
{
    [MetadataType(typeof(Setor_Metadata))]
    public partial class setor
    {
        public int setor_id { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public int departamento_id { get; set; }
        public departamento departamento { get; set; }
        public int centro_custo_id { get; set; }
        public centro_custo centro_custo { get; set; }
        public List<funcionario> funcionario { get; set; }
    }

    public class Setor_Metadata
    {
        [Key]
        public int setor_id { get; set; }

        [Required(ErrorMessage="Campo Descrição é obrigatório.")]
        [Display(Name="Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo Departamento é obrigatório.")]
        [Display(Name = "Departamento")]
        public departamento departamento { get; set; }

        [Required(ErrorMessage = "Campo Centro de Custo é obrigatório.")]
        [Display(Name = "Centro de Custo")]
        public centro_custo centro_custo { get; set; }
    }
}
