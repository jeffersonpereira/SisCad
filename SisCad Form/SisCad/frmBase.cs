using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.Data;

namespace SisCad
{
    public partial class frmBase : Form
    {
        protected frmBase()
        {
            InitializeComponent();
        }

        BindingSource bindingSource;
        public void Configure(BindingSource bindingSource)
        {
            this.bindingSource = bindingSource;
            this.BindingNavigator.BindingSource = bindingSource;
            _dataContext = Context.GetDataContext();
            bindingSource.AddingNew += AddNew;
        }

        private void AddNew(object sender, AddingNewEventArgs e)
        {
            this.btnSalvar.Enabled = true;
        }

        private DataContext _dataContext;
        protected DataContext DataContext
        {
            get { return _dataContext; }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Inserir();
            if (this.DataContext.SaveChanges() > 0)
            {
                MessageBox.Show("Registro salvo com sucesso.","Salvar",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.btnSalvar.Enabled = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.bindingSource.CancelEdit();
        }

        protected virtual void Inserir()
        { }

        protected virtual void Excluir()
        {}

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Excluir();
                if (this.DataContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
