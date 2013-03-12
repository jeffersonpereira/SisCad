using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public partial class setor : IValidade
    {

        public override string ToString()
        {
            return this.descricao;
        }

        [Key]
        public int setor_id { get; set; }
        public int codigo { get; set; }

        [Required(ErrorMessage = "Campo Descrição é obrigatório.")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }
        public int departamento_id { get; set; }

        [Required(ErrorMessage = "Campo Departamento é obrigatório.")]
        [Display(Name = "Departamento")]
        [Association("fk_departamento_to_setor", "departamento_id", "departamento_id")]
        public departamento departamento { get; set; }
        public int centro_custo_id { get; set; }

        [Required(ErrorMessage = "Campo Centro de Custo é obrigatório.")]
        [Display(Name = "Centro de Custo")]
        public centro_custo centro_custo { get; set; }
        public List<funcionario> funcionario { get; set; }

        public List<ValidationResult> GetValidationResult()
        {
            ValidationContext context = new ValidationContext(this, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            Validator.TryValidateObject(this, context, result);
            return result;
        }
    }
}
