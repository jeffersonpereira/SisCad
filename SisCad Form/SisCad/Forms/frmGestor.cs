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
    public partial class frmGestor : frmBase
    {
        public frmGestor()
        {
            InitializeComponent();
            base.Configure(gestorBindingSource);
        }

        public override void DoPesquisa()
        {
            frmPesquisa form = new frmPesquisa();
            form.Bind<gestor>(DataContext, new Search[] { 
                new Search { Campo = "nome", Tipo = typeof(string), Titulo = "nome" }});
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.gestorBindingSource.DataSource = form.Selected;
            }
        }
    }
}
