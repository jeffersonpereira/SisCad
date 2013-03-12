using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Model.Data;

namespace SisCad.Forms
{
    public partial class frmRptFicha : Form
    {
        public frmRptFicha()
        {
            InitializeComponent();
            context = Context.GetDataContext();
        }

        SisCadEntities context;
        private void button1_Click(object sender, EventArgs e)
        {
            ReportPrintTool tool = new ReportPrintTool(new RptFicha(context,this.bindingSource.List as List<funcionario>));
            tool.ShowPreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSelecaoFuncionario form = new frmSelecaoFuncionario(context);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.bindingSource.DataSource = form.Funcionarios;
            }
        }
    }
}
