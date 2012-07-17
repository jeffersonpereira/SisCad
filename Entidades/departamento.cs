using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Data.Entidades
{
    [MetadataType(typeof(Departamento_Metadata))]
    public partial class departamento
    {
        public int departamento_id { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public int empresa_id { get; set; }
        IList<setor> setor { get; set; }
    }

    public class Departamento_Metadata
    {
        [Key]
        public int departamento_id { get; set; }

        [Required(ErrorMessage = "Campo Descrição é obrigatório.")]
        [Display(Name="Descrição")]
        public string descricao { get; set; }
    }
}
