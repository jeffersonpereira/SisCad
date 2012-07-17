using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Entidades
{
    public partial class gestor
    {
        public int gestor_id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime nascimento { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public DateTime inicio_gestao { get; set; }
        public DateTime fim_gestao { get; set; }
        public ICollection<empresa> empresa { get; set; }
    }
}
