using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public interface IValidade
    {
        List<ValidationResult> GetValidationResult();
    }
}
