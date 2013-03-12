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
    public partial class frmSelecaoFuncionario : Form
    {
        SisCadEntities context;
        public frmSelecaoFuncionario()
        {
            InitializeComponent();
            
        }

        public frmSelecaoFuncionario(SisCadEntities context)
            :this()
        {
            this.context = context;
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tituloLabel.Text = this.comboBox1.SelectedItem as string;
            if (this.tituloLabel.Text.Equals("Nome") || this.tituloLabel.Text.Equals("Matrícula"))
            {
                this.valueComboBox.Visible = false;
                this.valueTextBox.Visible = true;
            }
            else
            {
                this.valueComboBox.Visible = true;
                this.valueTextBox.Visible = false;
                if (this.tituloLabel.Text.Equals("Departamento"))
                {
                    this.valueComboBox.DataSource = context.departamento.Where(d => d.empresa_id == context.EmpresaAtual.empresa_id).ToList();
                    this.valueComboBox.DisplayMember = "descricao";
                }
                else if (this.tituloLabel.Text.Equals("Setor"))
                {
                    this.valueComboBox.DataSource = context.setor.Where(d => d.departamento.empresa_id == context.EmpresaAtual.empresa_id).ToList();
                    this.valueComboBox.DisplayMember = "descricao";
                }
                else if (this.tituloLabel.Text.Equals("Centro de Custo"))
                {
                    this.valueComboBox.DataSource = context.centro_custo.ToList();
                    this.valueComboBox.DisplayMember = "descricao";
                }
                else if (this.tituloLabel.Text.Equals("Vículo"))
                {
                    this.valueComboBox.DataSource = context.centro_custo.ToList();
                    this.valueComboBox.DisplayMember = "descricao";
                }
                LoadFuncionarios();
            }
        }

        List<funcionario> _funcionarios;
        private void LoadFuncionarios()
        {
            dynamic entity = this.valueComboBox.SelectedItem;
            if (entity.GetType().Equals(typeof(departamento)))
            {
                int id = entity.departamento_id;
                _funcionarios = context.funcionario.Where(f => f.setor.departamento_id == id).ToList();
            }
            else if (entity.GetType().Equals(typeof(setor)))
            {
                int id = entity.departamento_id;
                _funcionarios = context.funcionario.Where(f => f.setor.departamento_id == id).ToList();
            }
            else if (entity.GetType().Equals(typeof(setor)))
            {
                int id = entity.setor_id;
                _funcionarios = context.funcionario.Where(f => f.setor_id == id).ToList();
            }
            else if (entity.GetType().Equals(typeof(centro_custo)))
            {
                int id = entity.centro_custo_id;
                _funcionarios = context.funcionario.Where(f => f.setor.centro_custo_id == id).ToList();
            }
            else
            {
                _funcionarios = null;
                this.origemBindingSource.ResetBindings(true);
            }
            if (_funcionarios != null)
            {
                _funcionarios = _funcionarios.OrderBy(f => f.nome).ToList();
            }
            this.origemBindingSource.DataSource = _funcionarios;
        }

        public IList<funcionario> Funcionarios
        {
            get
            {
                _funcionarios = new List<funcionario>();
                foreach (DataGridViewRow row in destinoDataGridView.Rows)
                {
                    _funcionarios.Add(row.DataBoundItem as funcionario);
                }
                return _funcionarios;
            }
        }

        private void btnAddTodos_Click(object sender, EventArgs e)
        {
            this.destinoBindingSource.DataSource = _funcionarios;
            this.origemBindingSource.DataSource = null;
        }

        private void btnRemoveTodos_Click(object sender, EventArgs e)
        {
            this.origemBindingSource.DataSource = _funcionarios;
            this.destinoBindingSource.DataSource = null;
        }

        List<funcionario> funcionarios = new List<funcionario>();
        private void btnAddUm_Click(object sender, EventArgs e)
        {
            if (this.origemDataGridView.SelectedRows.Count > 0)
            {
                
                foreach (DataGridViewRow row in this.origemDataGridView.SelectedRows)
                {
                    funcionarios.Add(row.DataBoundItem as funcionario);
                    _funcionarios.Remove(row.DataBoundItem as funcionario);
                }
                this.origemBindingSource.DataSource = _funcionarios;
                this.destinoBindingSource.DataSource = funcionarios;

                origemBindingSource.ResetBindings(true);
                destinoBindingSource.ResetBindings(true);
            }
        }

        private void btnRemoveUm_Click(object sender, EventArgs e)
        {
            if (this.destinoDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.destinoDataGridView.SelectedRows)
                {
                    _funcionarios.Add(row.DataBoundItem as funcionario);
                    funcionarios.Remove(row.DataBoundItem as funcionario);
                }
                this.destinoBindingSource.DataSource = funcionarios;
                this.origemBindingSource.DataSource = _funcionarios;

                origemBindingSource.ResetBindings(true);
                destinoBindingSource.ResetBindings(true);
            }
        }

        private void origemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddUm_Click(sender, e);
        }

        private void destinoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemoveUm_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

    }
}
