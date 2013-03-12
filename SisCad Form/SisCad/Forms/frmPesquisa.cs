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
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        SisCadEntities _dataContext;
        public void Bind<T>(SisCadEntities dataContext, Search[] search,string defaultFilter = null)
        {
            PreencheComboBox(search);
            _dataContext = dataContext;

            this.button1.Click += (s, e) =>
                {
                    DoPesquisa<T>(defaultFilter);
                };
        }

        private void PreencheComboBox(Search[] search)
        {
            filtroComboBox.DataSource = search;
            filtroComboBox.DisplayMember = "Titulo";
            foreach (var s in search)
            {
                ConfiguraListView(s);
            }
        }

        private void ConfiguraListView(Search search)
        {
            resultadoListView.Columns.Add(search.Titulo, 100, HorizontalAlignment.Left);
        }

        public object Selected { get; set; }

        private void filtroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search search = this.filtroComboBox.SelectedItem as Search;
            this.stringPanel.Visible    = typeof(string) == search.Tipo;
            this.intPanel.Visible       = typeof(int) == search.Tipo;
            this.datetimePanel.Visible  = typeof(DateTime) == search.Tipo;
        }

        void DoPesquisa<T>(string defaultFilter = null)
        {
            Search search = this.filtroComboBox.SelectedItem as Search;
            dynamic lista = null;
            if (typeof(string) == search.Tipo)
            {
                lista = GetEntitys<T>(search.Campo, this.descricao.Text, defaultFilter);
            }
            else if (typeof(int) == search.Tipo || typeof(DateTime) == search.Tipo)
            {
                object valueI = typeof(int) == search.Tipo ? (object)this.valueI.Value : (object)this.dataI.Value;
                object valueF = typeof(int) == search.Tipo ? (object)this.valueF.Value : (object)this.dataF.Value;
                lista = GetEntitys<T>(search.Campo, valueI, valueF, defaultFilter);
            }
            PreencherListView(lista);
        }

        private void PreencherListView(dynamic lista)
        {
            ListViewItem item = null;
            resultadoListView.Items.Clear();
            foreach (dynamic entity in lista)
            {
                for (int i = 0; i <= filtroComboBox.Items.Count - 1; i++)
                {
                    Search search = this.filtroComboBox.Items[i] as Search;
                    var value = entity.GetType().GetProperty(search.Campo).GetValue(entity, null).ToString();
                    if (i == 0)
                    {
                        item = resultadoListView.Items.Add(value);
                    }
                    else
                    {
                        item.SubItems.Add(value);
                    }
                }
                item.Tag = entity;
            }
        }

        private dynamic GetEntitys<T>(string campo, object valueI, object valueF,string defaultFilter = null)
        {
            string sql = string.Format("select * from {0} where {1}>={2} and {3}<={4}", typeof(T).Name, campo, valueI, campo, valueF);
            if (!string.IsNullOrWhiteSpace(defaultFilter))
            {
                sql += " " + defaultFilter;
            }
            return _dataContext.ExecuteStoreQuery<T>(sql, typeof(T).Name, System.Data.Objects.MergeOption.AppendOnly).ToList();
        }

        private dynamic GetEntitys<T>(string campo, string value, string defaultFilter = null)
        {
            string sql = string.Format("select * from {0} where {1} like '%{2}%'", typeof(T).Name, campo, value);
            if (!string.IsNullOrWhiteSpace(defaultFilter))
            {
                sql += " " + defaultFilter;
            }
            return _dataContext.ExecuteStoreQuery<T>(sql, typeof(T).Name, System.Data.Objects.MergeOption.AppendOnly).ToList();
        }

        private void resultadoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.resultadoListView.SelectedItems.Count == 1)
            {
                this.Selected = this.resultadoListView.SelectedItems[0].Tag;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultadoListView_SelectedIndexChanged(sender, e);
        }
    }
}
