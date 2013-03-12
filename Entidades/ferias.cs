using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public partial class ferias : IValidade
    {
        public ferias()
        {
            this.inicio_aquisicao = DateTime.Today;
            this.fim_aquisicao = DateTime.Today;
            this.inicio_gozo = DateTime.Today;
            this.fim_gozo = DateTime.Today;
        }
        [Key]
        public int ferias_id { get; set; }
        [Required(ErrorMessage = "Campo Inicio do Período Aquisitivo é obrigatório.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Inicio do Período Aquisitivo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime inicio_aquisicao { get; set; }

        [Required(ErrorMessage = "Campo Fim do Período Aquisitivo é obrigatório.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fim do Período Aquisitivo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
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
        public bool abono_pecuniario { get; set; }
        public DateTime? inicio_abono { get; set; }
        public DateTime? fim_abono { get; set; }

        public int funcionario_id { get; set; }

        [Required(ErrorMessage = "Campo funcionário é obrigatório.")]
        public funcionario funcionario { get; set; }

        public List<ValidationResult> GetValidationResult()
        {
            ValidationContext context = new ValidationContext(this, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            Validator.TryValidateObject(this, context, result);
            return result;
        }

    }
 }
