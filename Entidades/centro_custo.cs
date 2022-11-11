using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public partial class centro_custo : classe_base
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
    }
}