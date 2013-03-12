using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Model.Data;
using System.Data.Objects;

namespace SisCad.Forms
{
    public partial class frmFuncionario : frmBase
    {
        public frmFuncionario()
        {
            InitializeComponent();
            base.Configure(funcionarioBindingSource);
            loadPicture.Bind<funcionario>(funcionarioBindingSource, "foto");
            ConfigureBindigSource();
        }

        private void ConfigureBindigSource()
        {
            SetValue<municipio> setMunicipio = delegate(object dataSource, municipio value)
            {
                ((funcionario)dataSource).municipio = value;
                if (this.IsContext())
                {
                    this.SetModified("municipio_id");
                }
            };
            this.municipioLookup.Bind<municipio>(this.DataContext, setMunicipio, this.funcionarioBindingSource, "Município", "municipio",
                new Search { Campo = "nome", Tipo = typeof(string), Titulo = "Nome" },
                new Search { Campo = "uf", Tipo = typeof(string), Titulo = "UF" });


            SetValue<municipio> setNaturalidade = delegate(object dataSource, municipio value)
            {
                ((funcionario)dataSource).naturalidade = value;
                if (this.IsContext())
                {
                    this.SetModified("municipio_id_naturalidade");
                }
            };
            this.naturalidadeLookup.Bind<municipio>(this.DataContext, setNaturalidade, this.funcionarioBindingSource, "Naturalidade","naturalidade",
                new Search { Campo = "nome", Tipo = typeof(string), Titulo = "Nome" },
                new Search { Campo = "uf", Tipo = typeof(string), Titulo = "UF" });

            SetValue<setor> setSetor = delegate(object dataSource, setor value)
            {
                ((funcionario)dataSource).setor = value;
                if (this.IsContext())
                {
                    this.SetModified("setor_id");
                }
            };
            this.setorLookup.Bind<setor>(this.DataContext, setSetor, this.funcionarioBindingSource, "Setor",
                new Search { Campo = "descricao", Tipo = typeof(string), Titulo = "Nome" },
                new Search { Campo = "codigo", Tipo = typeof(int), Titulo = "Código" }
                );

            SetValue<cargo> setCargo = delegate(object dataSource, cargo value)
            {
                ((funcionario)dataSource).cargo = value;
                if (this.IsContext())
                {
                    this.SetModified("cargo_id");
                }
            };
            this.cargoLookup.Bind<cargo>(this.DataContext, setCargo, this.funcionarioBindingSource, "Cargo", "cargo",
                new Search { Campo = "descricao", Tipo = typeof(string), Titulo = "Descrição" },
                new Search { Campo = "cbo", Tipo = typeof(string), Titulo = "CBO" }
                );

            SetValue<cargo> setCargoContratacao = delegate(object dataSource, cargo value)
            {
                ((funcionario)dataSource).cargo_contratacao = value;
                if (this.IsContext())
                {
                    this.SetModified("cargo_contratacao_id");
                }
            };
            this.cargoContratacaoLookup.Bind<cargo>(this.DataContext, setCargoContratacao, this.funcionarioBindingSource, "Cargo de Contratação","cargo_contratacao",
                new Search { Campo = "descricao", Tipo = typeof(string), Titulo = "Descrição" },
                new Search { Campo = "cbo", Tipo = typeof(string), Titulo = "CBO" }
                );
        }

        public override void DoPesquisa()
        {
            frmPesquisa form = new frmPesquisa();
            string defaultFilter = string.Format("and empresa_id={0}",DataContext.EmpresaAtual.empresa_id);
            form.Bind<funcionario>(DataContext, new Search[] { 
                new Search { Campo = "nome", Tipo = typeof(string), Titulo = "Nome" }, 
                new Search { Campo = "matricula", Tipo = typeof(int), Titulo = "Matrícula" } }, defaultFilter);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.funcionarioBindingSource.DataSource = form.Selected;
            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (this.funcionarioBindingSource.Current != null)
            {
                frmFerias form = new frmFerias(this.funcionarioBindingSource.Current as funcionario);
                form.ShowDialog();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.funcionarioBindingSource.Current != null)
            {
                frmDependente form = new frmDependente(this.funcionarioBindingSource.Current as funcionario);
                form.FormClosed += (s, o) => { this.dependenteBindingSource.ResetCurrentItem(); };
                form.ShowDialog();
            }
        }

        private void funcionarioBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            //if (this.funcionarioBindingSource.Current != null)
            //{
            //    ObjectStateEntry obj;
            //    if (DataContext.ObjectStateManager.TryGetObjectStateEntry(this.funcionarioBindingSource.Current, out obj))
            //    {
            //        ObjectStateEntry entry = DataContext.ObjectStateManager.GetObjectStateEntry(this.funcionarioBindingSource.Current);
            //        if (entry != null && entry.State != EntityState.Added)
            //        {
            //            DataContext.LoadProperty(this.funcionarioBindingSource.Current, "empresa");
            //            DataContext.LoadProperty(this.funcionarioBindingSource.Current, "setor");
            //            DataContext.LoadProperty(this.funcionarioBindingSource.Current, "cargo_contratacao");
            //            DataContext.LoadProperty(this.funcionarioBindingSource.Current, "cargo");
            //            DataContext.LoadProperty(this.funcionarioBindingSource.Current, "municipio");
            //            DataContext.LoadProperty(this.funcionarioBindingSource.Current, "naturalidade");
            //            DataContext.LoadProperty(this.funcionarioBindingSource.Current, "ferias");
            //            DataContext.LoadProperty(this.funcionarioBindingSource.Current, "dependente");
            //            DataContext.LoadProperty(this.funcionarioBindingSource.Current, "movimentacao");
            //        }
            //    }
            //}

            if (this.IsContext())
            {
                DataContext.LoadProperty(this.funcionarioBindingSource.Current, "empresa");
                DataContext.LoadProperty(this.funcionarioBindingSource.Current, "setor");
                DataContext.LoadProperty(this.funcionarioBindingSource.Current, "cargo_contratacao");
                DataContext.LoadProperty(this.funcionarioBindingSource.Current, "cargo");
                DataContext.LoadProperty(this.funcionarioBindingSource.Current, "municipio");
                DataContext.LoadProperty(this.funcionarioBindingSource.Current, "naturalidade");
                DataContext.LoadProperty(this.funcionarioBindingSource.Current, "ferias");
                DataContext.LoadProperty(this.funcionarioBindingSource.Current, "dependente");
                DataContext.LoadProperty(this.funcionarioBindingSource.Current, "movimentacao");
            }
        }

        private void feriasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ferias ferias = feriasDataGridView.SelectedRows[e.RowIndex].DataBoundItem as ferias;
            if(ferias != null)
            {
                frmFerias form = new frmFerias(ferias);
                form.ShowDialog();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.funcionarioBindingSource.Current != null)
            {
                frmMovimentacao form = new frmMovimentacao(this.funcionarioBindingSource.Current as funcionario);
                form.ShowDialog();
            }
        }

        private void movimentacaoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            movimentacao movimentacao = movimentacaoDataGridView.SelectedRows[e.RowIndex].DataBoundItem as movimentacao;
            if (movimentacao != null)
            {
                frmMovimentacao form = new frmMovimentacao(movimentacao);
                form.ShowDialog();
            }
        }
    }
}
