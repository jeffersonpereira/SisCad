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
    public partial class frmUsuario : frmBase
    {
        public frmUsuario()
        {
            InitializeComponent();
            base.Configure(usuarioBindingSource);
        }

        public override void DoPesquisa()
        {
            frmPesquisa form = new frmPesquisa();
            form.Bind<usuario>(DataContext, new Search[] { 
                new Search { Campo = "nome", Tipo = typeof(string), Titulo = "Nome" }, 
                new Search { Campo = "login", Tipo = typeof(string), Titulo = "login" } });
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.usuarioBindingSource.DataSource = form.Selected;
            }
        }
    }
}
