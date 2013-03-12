using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public class usuario : IValidade
    {
        public int usuario_id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        string _senha = "***************";
        public string SenhaProtegida
        {
            get { return _senha; }
            set { senha = Security.GetHashMD5(value); }
        }

        public List<ValidationResult> GetValidationResult()
        {
            ValidationContext context = new ValidationContext(this, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            Validator.TryValidateObject(this, context, result);
            return result;
        }
    }
}
