using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SisCad.Forms
{
    public partial class frmSetor : frmBase
    {
        public frmSetor()
        {
            InitializeComponent();

        }

        private void frmSetor_Load(object sender, EventArgs e)
        {
            this.lookupCentroCusto.Bind("Centro de Custo");
            this.lookupDepartamento.Bind("Departamento");
        }

    }
}
