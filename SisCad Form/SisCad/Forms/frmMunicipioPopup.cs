using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Entidades;

namespace SisCad.Forms
{
    public partial class frmMunicipioPopup : Form
    {
        public frmMunicipioPopup()
        {
            InitializeComponent();
        }

        public void PopupShow(IList<municipio> municipios)
        {
            this.listView.Items.Clear();
            foreach (municipio m in municipios)
            {
                AddItem(m);
            }
        }

        private void AddItem(municipio municipio)
        {
            ListViewItem item = this.listView.Items.Add(municipio.nome);
            item.SubItems.Add(municipio.uf);
            item.Tag = municipio;
        }

    }
}
