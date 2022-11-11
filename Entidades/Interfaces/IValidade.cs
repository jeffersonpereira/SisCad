using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Interfaces
{
    public interface IValidade
    {
        List<ValidationResult> GetValidationResult();
    }
}