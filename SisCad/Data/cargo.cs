using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SisCadLibrary.Data
{
    [MetadataType(typeof(Cargo_Metadata))]
    public partial class cargo
    {
        public override string ToString()
        {
            return string.Format("{0} - {1}",this.cbo,this.descricao);
        }

        public int cargo_id { get; set; }
        public string descricao { get; set; }
        public string cbo { get; set; }
        public virtual List<funcionario> funcionario { get; set; }
        public virtual List<funcionario> funcionario_contratacao { get; set; }
    }

    public partial class Cargo_Metadata
    {
        [Key]
        public int cargo_id { get; set; }

        [Required(ErrorMessage = "Campo Descrição é obrigatório.")]
        [Display(Name="Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo CBO é obrigatório.")]
        [Display(Name = "CBO")]
        public string cbo { get; set; }
    }
}
