using Model.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public abstract class classe_base : IValidade
    {
        public virtual List<ValidationResult> GetValidationResult()
        {
            ValidationContext context = new ValidationContext(this, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            Validator.TryValidateObject(this, context, result);
            return result;
        }
    }
}