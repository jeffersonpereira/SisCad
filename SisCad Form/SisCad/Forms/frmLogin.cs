using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.Data;

namespace SisCad.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(loginTextBox.Text) && !string.IsNullOrWhiteSpace(senhaTextBox.Text))
            {
                SisCadEntities context = Context.GetDataContext();
                //usuario u = new usuario {nome = "Jefferson", login = "demo", senha = "1" };
                //context.AddToUsuario(u);
                //context.SaveAll();
                if (context.Autenticate(loginTextBox.Text, senhaTextBox.Text))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }
                else
                {
                    if (count == 3)
                    {
                        MessageBox.Show("O sistema será encerrado, pois excedeu o limite de tentativas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                    count++;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(loginTextBox.Text))
                {
                    MessageBox.Show("Login deve ser preenchido.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                if (string.IsNullOrWhiteSpace(senhaTextBox.Text))
                {
                    MessageBox.Show("Senha deve ser preenchida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
