using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SisCad.Properties;
using System.Configuration.Assemblies;
using System.Configuration;

namespace SisCad.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetor form = new frmSetor();
            form.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa form = new frmEmpresa();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.labelHora.Text = string.Format("Prefeitura Municipal de Mirante: {0}", DateTime.Now.ToString("HH:mm:ss"));
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamento form = new frmDepartamento();
            form.Show();
        }

        private void centroDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCentroCusto form = new frmCentroCusto();
            form.Show();
        }

        private void fériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFerias form = new frmFerias();
            form.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario form = new frmFuncionario();
            form.Show();
        }
    }
}
