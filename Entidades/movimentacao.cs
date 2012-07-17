using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Data.Entidades
{
    [MetadataType(typeof(Movimentacao_Metadata))]
    public partial class movimentacao
    {
        public int movimentacao_id { get; set; }
        public string descricao { get; set; }
        public DateTime data_saida { get; set; }
        public DateTime? data_retorno { get; set; }
        public int funcionario_id { get; set; }
        public funcionario funcionario { get; set; }
        public int tipo_movimentacao { get; set; }
    }

    public class Movimentacao_Metadata
    {
        [Key]
        public int movimentacao_id { get; set; }
        
        [Required(ErrorMessage="Campo Descrição é obrigatório")]
        [Display(Name="Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo Data de Saída é obrigatório")]
        [Display(Name = "Data de Saída")]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime data_saida { get; set; }

        [Display(Name = "Data de Retorno")]
        public DateTime? data_retorno { get; set; }

        [Required(ErrorMessage = "Campo Funcionário é obrigatório")]
        [Display(Name = "Funcionário")]
        public int funcionario_id { get; set; }

        [Required(ErrorMessage = "Campo Tipo de Movimentação é obrigatório")]
        [Display(Name = "Tipo de Movimentação")]
        public int tipo_movimentacao { get; set; }
    }
}
