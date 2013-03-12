using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.Data;
using System.Data.Objects;

namespace SisCad.Forms
{
    public partial class frmEmpresa : frmBase
    {
        public frmEmpresa()
        {
            InitializeComponent();
            base.Configure(empresaBindingSource);
            ConfigureBindigSource();
            this.loadPicture.Bind<empresa>(this.empresaBindingSource, "Imagem");
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            if (DataContext.EmpresaAtual != null)
            {
                this.empresaBindingSource.DataSource = DataContext.EmpresaAtual;
            }
        }

        private void ConfigureBindigSource()
        {
            SetValue<municipio> setMunicipio = delegate(object dataSource, municipio value)
            {
                ((empresa)dataSource).municipio = value;
                if (this.IsContext())
                {
                    this.SetModified("municipio_id");
                }
            };
            this.municipioLookup.Bind<municipio>(this.DataContext, setMunicipio, this.empresaBindingSource, "Município",
                new Search { Campo = "nome", Tipo = typeof(string), Titulo = "Nome" },
                new Search { Campo = "uf", Tipo = typeof(string), Titulo = "UF" });

            SetValue<gestor> setGestor = delegate(object dataSource, gestor value)
            {
                ((empresa)dataSource).gestor = value;
                if (this.IsContext())
                {
                    this.SetModified("gestor_id");
                }
            };
            this.gestorLookup.Bind<gestor>(this.DataContext, setGestor, this.empresaBindingSource, "Gestor",
                new Search { Campo = "nome", Tipo = typeof(string), Titulo = "Nome" },
                new Search { Campo = "cpf", Tipo = typeof(string), Titulo = "CNPJ / CPF" }
                );
        }

        private void empresaBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            //if (this.empresaBindingSource.Current != null)
            //{
            //    ObjectStateEntry obj;
            //    if (DataContext.ObjectStateManager.TryGetObjectStateEntry(this.empresaBindingSource.Current, out obj))
            //    {
            //        DataContext.LoadProperty(this.empresaBindingSource.Current, "municipio");
            //        DataContext.LoadProperty(this.empresaBindingSource.Current, "gestor");
            //    }
            //}
            if (this.IsContext())
            {
                DataContext.LoadProperty(this.empresaBindingSource.Current, "municipio");
                DataContext.LoadProperty(this.empresaBindingSource.Current, "gestor");
            }
        }
    }
}
