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
    public partial class frmSelecaoEmpresa : Form
    {
        public frmSelecaoEmpresa()
        {
            InitializeComponent();
        }

        private void frmSelecaoEmpresa_Load(object sender, EventArgs e)
        {
            LoadEmpresas();
        }

        private void LoadEmpresas()
        {
            SisCadEntities context = Context.GetDataContext();
            this.empresaComboBox.DataSource = context.empresa.ToList().OrderBy<empresa, string>(e => e.razao_social).ToList();
            empresaComboBox.DisplayMember = "razao_social";

            this.btnEmpresa.Visible = false;
            this.btnGestor.Visible = this.empresaComboBox.Items.Count == 1;
            this.btnOK.Visible = this.empresaComboBox.Items.Count > 0;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (empresaComboBox.SelectedItem != null)
            {
                GlobalVar.EmpresaAtual = empresaComboBox.SelectedItem as empresa;
                Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            frmGestor form = new frmGestor();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnEmpresa_Click(sender, e);
            }
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa form = new frmEmpresa();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadEmpresas();
            }
        }
    }
}
