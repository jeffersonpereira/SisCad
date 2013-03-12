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
    public partial class frmMovimentacao : frmBase
    {
        public frmMovimentacao()
        {
            InitializeComponent();
            Configure(this.movimentabindingcaoBource);
            ConfigureBindigSource();
        }

        public frmMovimentacao(funcionario funcionario)
            : this()
        {
            this.AddNew();
            ((movimentacao)this.movimentabindingcaoBource.Current).funcionario = funcionario;
            this.funcionarioLookup.Enabled = false;
        }

        public frmMovimentacao(movimentacao movimentacao)
            : this()
        {
            this.movimentabindingcaoBource.DataSource = movimentacao;
        }

        private void ConfigureBindigSource()
        {
            SetValue<funcionario> setFuncionario = delegate(object dataSource, funcionario value)
            {
                ((movimentacao)dataSource).funcionario = value;
                if (this.IsContext())
                {
                    this.SetModified("funcionario_id");
                }
            };
            this.funcionarioLookup.Bind<funcionario>(this.DataContext, setFuncionario, this.movimentabindingcaoBource, "Funcionário", "funcionario",
                new Search { Campo = "nome", Tipo = typeof(string), Titulo = "Nome" },
                new Search { Campo = "matricula", Tipo = typeof(int), Titulo = "Mátricula" });
        }

        private void movimentabindingcaoBource_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.IsContext())
            {
                DataContext.LoadProperty(this.movimentabindingcaoBource.Current, "funcionario");
            }
        }
    }
}
