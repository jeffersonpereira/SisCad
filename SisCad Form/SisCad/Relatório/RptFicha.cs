using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.IO;
using Model.Data;

namespace SisCad
{
    public partial class RptFicha : DevExpress.XtraReports.UI.XtraReport
    {
        public RptFicha()
        {
            InitializeComponent();
        }

        public RptFicha(SisCadEntities context, IList<funcionario> funcionarios,bool marcaDaAgua = true)
            :this()
        {
            if (marcaDaAgua && context.EmpresaAtual.logo != null)
            {
                this.Watermark.Image = Bitmap.FromStream(new MemoryStream(context.EmpresaAtual.logo));
                this.Watermark.ImageTransparency = 90;
                this.Watermark.ImageAlign = ContentAlignment.MiddleCenter;
                this.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch;

            }
            foreach (var f in funcionarios)
            {
                context.LoadProperty(f, "empresa");
                context.LoadProperty(f.empresa, "municipio");
                context.LoadProperty(f, "ferias");
                context.LoadProperty(f, "municipio");
                context.LoadProperty(f, "dependente");
                context.LoadProperty(f, "movimentacao");
                context.LoadProperty(f, "setor");
                context.LoadProperty(f.setor, "departamento");
                context.LoadProperty(f.setor, "centro_custo");
                context.LoadProperty(f, "cargo");
                context.LoadProperty(f, "cargo_contratacao");
            }
            this.bindingSource1.DataSource = funcionarios;
        }

    }
}
