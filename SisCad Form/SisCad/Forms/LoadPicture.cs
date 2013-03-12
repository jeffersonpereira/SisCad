using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace SisCad.Forms
{
    public partial class LoadPicture : UserControl
    {
        public LoadPicture()
        {
            InitializeComponent();
        }

        public void Bind<T>(BindingSource bindingSource, string dataMember)
        {
            this.bindingSource = bindingSource;
            this.pictureBox.DataBindings.Add("Image", bindingSource, "Imagem");
            this.btnLoad.Click += (o, s) =>
            {
                if (this.bindingSource.Current != null)
                {
                    byte[] imageOfBytes = GetBytes();
                    if (imageOfBytes != null)
                    {
                        long tamanho = imageOfBytes.Length / 1048576;
                        if (tamanho > 2)
                        {
                            MessageBox.Show("Tamanho máximo da imagem deve ser de 2 MB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        SetValue<T>(dataMember, imageOfBytes);
                    }
                }
            };
        }

        private byte[] GetBytes()
        {
            byte[] imageOfBytes = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(openFileDialog1.FileName, FileMode.Open);
                imageOfBytes = new Byte[stream.Length];
                stream.Read(imageOfBytes, 0, imageOfBytes.Length);
                stream.Close();
            }
            return imageOfBytes;
        }

        private void SetValue<T>(string property,byte[] value)
        {
            if (bindingSource.Current != null)
            { 
                PropertyInfo info = typeof(T).GetProperty(property);
                info.SetValue(bindingSource.Current, value, null);
                bindingSource.ResetBindings(true);
            }
        }
    }
}
