using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public partial class gestor : IValidade
    {
        public override string ToString()
        {
            return this.nome;
        }
        [Key]
        public int gestor_id { get; set; }

        [Required(ErrorMessage = "Campo nome deve ser informado.")]
        public string nome { get; set; }

        public string cpf { get; set; }

        [Required(ErrorMessage = "Campo nascimento deve ser informado.")]
        public DateTime nascimento { get; set; }

        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public int municipio_id { get; set; }

        [Required(ErrorMessage = "Campo inicio da gestão deve ser informado.")]
        public DateTime inicio_gestao { get; set; }
        [Required(ErrorMessage = "Campo fim da gestão deve ser informado.")]
        public DateTime fim_gestao { get; set; }
        public ICollection<empresa> empresa { get; set; }

        public List<ValidationResult> GetValidationResult()
        {
            ValidationContext context = new ValidationContext(this, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            Validator.TryValidateObject(this, context, result);
            return result;
        }
    }
}
