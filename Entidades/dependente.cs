using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public class dependente : classe_base
    {
        [Key]
        public int dependente_id { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Campo Data de Nascimento é obrigatório.")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime data_nascimento { get; set; }
        [Required(ErrorMessage = "Campo Grau de Parentesco é obrigatório.")]
        [Display(Name = "Grau de Parentesco")]
        public string parentesco { get; set; }
        public int funcionario_id { get; set; }
        [Required(ErrorMessage = "Campo Funcionário é obrigatório.")]
        [Display(Name = "Funcionário")]
        public funcionario funcionario { get; set; }
    }
}