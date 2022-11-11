using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public class municipio : classe_base
    {
        public override string ToString()
        {
            return string.Format("({0}){1}", this.uf, this.nome);
        }
        [Key]
        public int municipio_id { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Campo UF é obrigatório.")]
        [Display(Name = "UF")]
        [StringLength(2, ErrorMessage = "Tamanho máximo é de 2 caracteres.")]
        public string uf { get; set; }
        public virtual ICollection<empresa> empresa { get; set; }
        public virtual ICollection<funcionario> funcionario { get; set; }
        public virtual ICollection<funcionario> funcionario_naturalidade { get; set; }

    }
}