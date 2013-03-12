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
            _dataContext = Context.GetDataContext();
            bindingSource.CurrentItemChanged += BindingSource_CurrentItemChanged;
            this.bindingSource = bindingSource;
            this.BindingNavigator.BindingSource = bindingSource;
            this.BindingNavigator.AddNewItem.Click += btnNovo_Click;
            
        }

        protected bool IsContext()
        {
            if (bindingSource.Current == null)
            {
                return false;
            }
            ObjectStateEntry obj;
            if (DataContext.ObjectStateManager.TryGetObjectStateEntry(this.bindingSource.Current, out obj))
            {
                ObjectStateEntry entry = DataContext.ObjectStateManager.GetObjectStateEntry(this.bindingSource.Current);
                if (entry != null && entry.State != EntityState.Added)
                {
                    return true;
                }
            }
            return false;
        }

        protected void SetModified(string property)
        {
            if (this.bindingSource.Current != null)
            {
                ObjectStateEntry entry = DataContext.ObjectStateManager.GetObjectStateEntry(this.bindingSource.Current);
                entry.SetModifiedProperty(property);
            }
        }

        private void BindingSource_CurrentItemChanged(object sender,EventArgs e)
        {
            if (this.bindingSource.Current != null)
            {
                dynamic entity = bindingSource.Current;
                ObjectStateEntry obj;
                /*Verifico se o objeto está no contexto*/
                if (DataContext.ObjectStateManager.TryGetObjectStateEntry(entity,out obj))
                {
                    ObjectStateEntry entry = DataContext.ObjectStateManager.GetObjectStateEntry(entity);
                    if (entry.State != EntityState.Added)
                    {
                        DataContext.ApplyOriginalValues(entry.EntitySet.Name, entity);
                    }
                    HabilitarBotoes();
                }
            }
        }

        protected virtual void AddNew()
        {
            this.bindingSource.AddNew();
            dynamic entity = this.bindingSource.Current;
            DataContext.AddObject(entity.GetType().Name, this.bindingSource.Current);
            SetCodigo();
            HabilitarBotoes();
        }

        private void SetCodigo()
        {
            dynamic entity = this.bindingSource.Current;
            if (entity.GetType() == typeof(funcionario))
            {
                entity.matricula = DataContext.GetProximoMatricula();
            }
            if (entity.GetType() == typeof(setor))
            {
                entity.codigo = DataContext.GetProximoCodigoSetor();
            }
            if (entity.GetType() == typeof(departamento))
            {
                entity.codigo = DataContext.GetProximoCodigoDepartamentor();
            }
        }

        private void SetEmpresaAtual()
        {
            dynamic entity = this.bindingSource.Current;
            if (entity.GetType() == typeof(funcionario) || entity.GetType() == typeof(departamento))
            {
                entity.empresa = DataContext.EmpresaAtual;
            }
        }

        private SisCadEntities _dataContext;
        protected SisCadEntities DataContext
        {
            get { return _dataContext; }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dynamic entity = this.bindingSource.Current;

            
            dynamic erros = entity.GetValidationResult();
            if (erros.Count == 0)
            {
                if (this.DataContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Registro salvo com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    HabilitarBotoes();
                }
            }
            else
            {
                foreach (dynamic erro in erros)
                {
                    MessageBox.Show(erro.ErrorMessage,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.bindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (this.DataContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void HabilitarBotoes()
        {
            if (this.bindingSource.Current != null)
            {
                ObjectStateEntry entry = DataContext.ObjectStateManager.GetObjectStateEntry(this.bindingSource.Current);
                if (entry.State == EntityState.Unchanged)
                {
                    this.btnExcluir.Enabled = true;
                    this.btnNovo.Enabled = true;
                    this.btnSalvar.Enabled = false;
                }
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    this.btnExcluir.Enabled = false;
                    this.btnNovo.Enabled = false;
                    this.btnSalvar.Enabled = true;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AddNew();
            SetEmpresaAtual();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DoPesquisa();
        }

        public virtual void DoPesquisa()
        {}
    }
}
