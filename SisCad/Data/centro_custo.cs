using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SisCadLibrary.Data
{
    [MetadataType(typeof(CentroCusto_Metadata))]
    public partial class centro_custo
    {
        public int centro_custo_id { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public IList<setor> setor { get; set; }
    }

    public class CentroCusto_Metadata
    {
        [Key]
        public int centro_custo_id { get; set; }

        [Required(ErrorMessage="Campo Descrição é obrigatório.")]
        [Display(Name="Descrição")]
        public string descricao { get; set; }
    }
}
