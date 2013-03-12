using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.Data;

namespace SisCad.Forms
{
    public partial class frmDependente : frmBase
    {
        public frmDependente()
        {
            InitializeComponent();
            base.Configure(this.dependenteBindingSource);
            ConfigureBindigSource();
        }

        public frmDependente(funcionario funcionario)
            : this()
        {
            AddNew();
            this.funcionarioLookup.Enabled = false;
            ((dependente)this.dependenteBindingSource.Current).funcionario = funcionario;
        }

        private void ConfigureBindigSource()
        {
            SetValue<funcionario> setFuncionario = delegate(object dataSource, funcionario value)
            {
                ((dependente)dataSource).funcionario = value;
            };
            this.funcionarioLookup.Bind<funcionario>(this.DataContext, setFuncionario, this.dependenteBindingSource, "Funcionário", "funcionario",
                new Search { Campo = "nome", Tipo = typeof(string), Titulo = "Nome" },
                new Search { Campo = "matricula", Tipo = typeof(int), Titulo = "Mátricula" });
        }
    }
}
