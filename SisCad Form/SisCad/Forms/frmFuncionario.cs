﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Data.Entidades;

namespace SisCad.Forms
{
    public partial class frmFuncionario : frmBase, ISelecteObject
    {
        public frmFuncionario()
        {
            InitializeComponent();
            this.pesquisaMunicipio.Bind(this.DataContext, this.funcionarioBindingSource,this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(openFileDialog1.FileName, @"c:\video\tech01.conf");
            }
        }

        void ISelecteObject.OnSelected(object obj)
        {
            funcionario funcionario = this.funcionarioBindingSource.Current as funcionario;
            if (funcionario != null)
            {
                funcionario.municipio = (municipio)obj;
            }
        }
    }
}
