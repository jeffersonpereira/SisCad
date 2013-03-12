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
            form.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa form = new frmEmpresa();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.labelHora.Text = string.Format("Prefeitura Municipal de Mirante: {0}", DateTime.Now.ToString("HH:mm:ss"));
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamento form = new frmDepartamento();
            form.ShowDialog();
        }

        private void centroDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCentroCusto form = new frmCentroCusto();
            form.ShowDialog();
        }

        private void fériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFerias form = new frmFerias();
            form.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario form = new frmFuncionario();
            form.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmSelecaoEmpresa form = new frmSelecaoEmpresa();
            form.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario form = new frmUsuario();
            form.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGestor form = new frmGestor();
            form.ShowDialog();
        }

        private void dependenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDependente form = new frmDependente();
            form.ShowDialog();
        }

        private void fichaFuncionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptFicha form = new frmRptFicha();
            form.ShowDialog();
        }
    }
}
