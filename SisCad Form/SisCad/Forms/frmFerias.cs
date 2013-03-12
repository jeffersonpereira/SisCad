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
    public partial class frmFerias : frmBase
    {
        public frmFerias()
        {
            InitializeComponent();
            base.Configure(feriasBindingSource);
            ConfigureBindigSource();
        }

        public frmFerias(funcionario funcionario)
            : this()
        {
            this.AddNew();
            ((ferias)this.feriasBindingSource.Current).funcionario = funcionario;
            this.funcionarioLookup.Enabled = false;
        }

        public frmFerias(ferias ferias)
            : this()
        {
            this.funcionarioLookup.Enabled = false;
            feriasBindingSource.DataSource = ferias;
        }

        private void ConfigureBindigSource()
        {
            SetValue<funcionario> setFuncionario = delegate(object dataSource, funcionario value)
            {
                ((ferias)dataSource).funcionario = value;
                if (this.IsContext())
                {
                    this.SetModified("funcionario_id");
                }
            };
            this.funcionarioLookup.Bind<funcionario>(this.DataContext, setFuncionario, this.feriasBindingSource, "Funcionário", "funcionario",
                new Search { Campo = "nome", Tipo = typeof(string), Titulo = "Nome" },
                new Search { Campo = "matricula", Tipo = typeof(int), Titulo = "Mátricula" });
        }

        private void feriasBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.IsContext())
            {
                DataContext.LoadProperty(this.feriasBindingSource.Current, "funcionario");
            }
        }
    }
}
