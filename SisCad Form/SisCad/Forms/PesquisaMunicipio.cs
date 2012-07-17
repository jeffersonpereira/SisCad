using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Windows.Forms;
using Model.Data;

namespace SisCad.Forms
{
    public partial class PesquisaMunicipio : UserControl
    {
        public PesquisaMunicipio()
        {
            InitializeComponent();
        }

        DataContext _dataContext;
        BindingSource bindingSource;
        ISelecteObject pesquisa;
        public void Bind(DataContext dataContext, BindingSource bindingSource,ISelecteObject pesquisa)
        {
            this.pesquisa = pesquisa;
            _dataContext = dataContext;
            this.bindingSource = bindingSource;
            this.editPesquisa.DataBindings.Add("Text",bindingSource,"municipio");
        }

        private void editPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(this.editPesquisa.Text))
                {
                    Pesquisar(this.editPesquisa.Text);
                    this.bindingSource.ResetBindings(true);
                }
            }
        }

        private void Pesquisar(string nome)
        {
            var municipio = _dataContext.municipio.Where(m => m.nome.StartsWith(nome)).ToList();
            if (municipio.Count > 0)
            {
                if (municipio.Count == 1)
                {
                    pesquisa.OnSelected(municipio[0]);
                }
                else
                { }
            }
        }
    }
}
