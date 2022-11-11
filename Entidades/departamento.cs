using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public partial class departamento : classe_base
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

    }
}