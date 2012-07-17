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
    public partial class frmCentroCusto : frmBase
    {
        public frmCentroCusto()
        {
            InitializeComponent();
            Configure(this.centro_custoBindingSource);
        }

        protected override void Inserir()
        {
            centro_custo centro = this.centro_custoBindingSource.Current as centro_custo;
            DataContext.AddToCentroCusto(centro);
        }

        protected override void Excluir()
        {
            centro_custo centro = this.centro_custoBindingSource.Current as centro_custo;
            DataContext.centro_custo.AddObject(centro);
        }
    }
}
