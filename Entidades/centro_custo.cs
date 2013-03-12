using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public partial class centro_custo : IValidade
    {
        public centro_custo()
        {
            
        }

        public override string ToString()
        {
            return this.descricao;
        }

        [Key]
        public int centro_custo_id { get; set; }
        public int codigo { get; set; }

        [Required(ErrorMessage = "Campo Descrição é obrigatório.")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }
        public ICollection<setor> setor { get; set; }

        public List<ValidationResult> GetValidationResult()
        {
            ValidationContext context = new ValidationContext(this, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            Validator.TryValidateObject(this, context, result);
            return result;
        }
    }
}
