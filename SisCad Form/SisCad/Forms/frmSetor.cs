using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.Data;
using System.Data.Objects;

namespace SisCad.Forms
{
    public partial class frmSetor : frmBase
    {
        public frmSetor()
        {
            InitializeComponent();

        }

        private void frmSetor_Load(object sender, EventArgs e)
        {
            base.Configure(this.setorBindingSource);
            ConfigureBindigSource();
        }

        private void ConfigureBindigSource()
        {
            SetValue<departamento> setDepartamento = delegate(object dataSource, departamento value)
            {
                ((setor)dataSource).departamento = value;
                if (this.IsContext())
                {
                    this.SetModified("departamento_id");
                }
            };
            this.lookupDepartamento.Bind<departamento>(this.DataContext, setDepartamento, this.setorBindingSource, "Departamento",
                new Search { Campo = "descricao", Tipo = typeof(string), Titulo = "Descrição" },
                new Search { Campo = "codigo", Tipo = typeof(int), Titulo = "Código" });

            SetValue<centro_custo> setCentroCusto = delegate(object dataSource, centro_custo value)
            {
                ((setor)dataSource).centro_custo = value;
                if (this.IsContext())
                {
                    this.SetModified("centro_custo_id");
                }
            };
            this.lookupCentroCusto.Bind<centro_custo>(this.DataContext, setCentroCusto, this.setorBindingSource, "Centro de Custo",
                new Search { Campo = "descricao", Tipo = typeof(string), Titulo = "Descrição" },
                new Search { Campo = "codigo", Tipo = typeof(int), Titulo = "Código" });
        }

        public override void DoPesquisa()
        {
            frmPesquisa form = new frmPesquisa();
            string defaultFilter = string.Format("and departamento_id in (select departamento_id from departamento where empresa_id={0})", DataContext.EmpresaAtual.empresa_id);
            form.Bind<setor>(DataContext, new Search[] { 
                new Search { Campo = "descricao", Tipo = typeof(string), Titulo = "Descrição" }, 
                new Search { Campo = "codigo", Tipo = typeof(int), Titulo = "Código" } },defaultFilter);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.setorBindingSource.DataSource = form.Selected;
            }
        }

        private void setorBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.IsContext())
            {
                DataContext.LoadProperty(this.setorBindingSource.Current, "departamento");
                DataContext.LoadProperty(this.setorBindingSource.Current, "centro_custo");
                DataContext.LoadProperty(this.setorBindingSource.Current, "funcionario");
            }
        }

    }
}
