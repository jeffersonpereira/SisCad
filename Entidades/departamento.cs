using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public partial class departamento : IValidade
    {

        public override string ToString()
        {
            return this.descricao;
        }

        [Key]
        public int departamento_id { get; set; }
        public int codigo { get; set; }

        [Required(ErrorMessage = "Campo Descrição é obrigatório.")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo Empresa é obrigatório.")]
        public empresa empresa { get; set; }
        public int empresa_id { get; set; }
        IList<setor> setor { get; set; }

        public List<ValidationResult> GetValidationResult()
        {
            ValidationContext context = new ValidationContext(this, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(this, context, result, true);
            return result;
        }
    }
}
