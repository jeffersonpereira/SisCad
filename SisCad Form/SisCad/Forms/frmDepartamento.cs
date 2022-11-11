using System;
using System.Windows.Forms;
using Model.Data;

namespace SisCad.Forms
{
    public partial class frmDepartamento : frmBase
    {
        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            base.Configure(this.bindingSourceDepartamento);
        }

        public override void DoPesquisa()
        {
            frmPesquisa form = new frmPesquisa();
            string defaultFilter = string.Format("and empresa_id={0}", DataContext.EmpresaAtual.empresa_id);
            form.Bind<departamento>(DataContext, new Search[] {
                new Search { Campo = "descricao", Tipo = typeof(string), Titulo = "Descrição" },
                new Search { Campo = "codigo", Tipo = typeof(int), Titulo = "Código" } }, defaultFilter);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.bindingSourceDepartamento.DataSource = form.Selected;
                this.DataSource = form.Selected;
            }
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
            if (Adicao)
            {
                this.codigoTextBox.Text = "0";
                this.descricaoTextBox.Text = "";
            }
        }

    }
}