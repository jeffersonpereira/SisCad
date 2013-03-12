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
    public partial class frmCentroCusto : frmBase
    {
        public frmCentroCusto()
        {
            InitializeComponent();
            Configure(this.centro_custoBindingSource);
        }

        public override void DoPesquisa()
        {
            frmPesquisa form = new frmPesquisa();
            form.Bind<centro_custo>(DataContext, new Search[] { 
                new Search { Campo = "descricao", Tipo = typeof(string), Titulo = "Descrição" }, 
                new Search { Campo = "codigo", Tipo = typeof(int), Titulo = "Código" } });
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.centro_custoBindingSource.DataSource = form.Selected;
            }
        }
    }
}
