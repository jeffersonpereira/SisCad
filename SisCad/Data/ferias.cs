using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SisCadLibrary.Data
{
    [MetadataType(typeof(Ferias_Metadata))]
    public partial class ferias
    {
        public int ferias_id { get; set; }
        public DateTime inicio_aquisicao { get; set; }
        public DateTime fim_aquisicao { get; set; }
        public DateTime inicio_gozo { get; set; }
        public DateTime fim_gozo { get; set; }
        public bool abono_pecuniario { get; set; }
        public int funcionario_id { get; internal set; }
        public funcionario funcionario { get; set; }

    }

    public class Ferias_Metadata
    {
        [Key]
        public int ferias_id { get; set; }

        [Required(ErrorMessage = "Campo Inicio do Período Aquisitivo é obrigatório.")]
        [DataType(DataType.DateTime)]
        [Display(Name="Inicio do Período Aquisitivo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime inicio_aquisicao { get; set; }

        [Required(ErrorMessage = "Campo Fim do Período Aquisitivo é obrigatório.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fim do Período Aquisitivo")]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime fim_aquisicao { get; set; }

        [Required(ErrorMessage = "Campo Inicio do Gozo é obrigatório.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Inicio do Gozo Aquisitivo")]
        public DateTime inicio_gozo { get; set; }

        [Required(ErrorMessage = "Campo Fim do Gozo é obrigatório.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fim do Gozo Aquisitivo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fim_gozo { get; set; }

        [Display(Name = "Funcionário")]
        [ForeignKey("funcionario_id")]
        public funcionario funcionario { get; set; }
    }
 }
