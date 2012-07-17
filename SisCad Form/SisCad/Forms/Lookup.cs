using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SisCad.Forms
{
    public partial class Lookup : UserControl
    {
        public Lookup()
        {
            InitializeComponent();
        }

        public void Bind(string titulo)
        {
            this.labelTitulo.Text = titulo;
        }
    }
}
