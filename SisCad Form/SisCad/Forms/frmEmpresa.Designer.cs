﻿namespace SisCad.Forms
{
    partial class frmEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label razao_socialLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label complementoLabel;
            System.Windows.Forms.Label cepLabel;
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.razao_socialTextBox = new System.Windows.Forms.TextBox();
            this.cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pesquisaMunicipio1 = new SisCad.Forms.PesquisaMunicipio();
            this.lookup1 = new SisCad.Forms.Lookup();
            razao_socialLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            complementoLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // razao_socialLabel
            // 
            razao_socialLabel.AutoSize = true;
            razao_socialLabel.Location = new System.Drawing.Point(136, 39);
            razao_socialLabel.Name = "razao_socialLabel";
            razao_socialLabel.Size = new System.Drawing.Size(70, 13);
            razao_socialLabel.TabIndex = 1;
            razao_socialLabel.Text = "Razão Social";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(563, 39);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(34, 13);
            cnpjLabel.TabIndex = 3;
            cnpjLabel.Text = "CNPJ";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(136, 76);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(53, 13);
            enderecoLabel.TabIndex = 6;
            enderecoLabel.Text = "Endereço";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(393, 76);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(18, 13);
            numeroLabel.TabIndex = 8;
            numeroLabel.Text = "Nr";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(444, 76);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(34, 13);
            bairroLabel.TabIndex = 10;
            bairroLabel.Text = "Bairro";
            // 
            // complementoLabel
            // 
            complementoLabel.AutoSize = true;
            complementoLabel.Location = new System.Drawing.Point(136, 114);
            complementoLabel.Name = "complementoLabel";
            complementoLabel.Size = new System.Drawing.Size(71, 13);
            complementoLabel.TabIndex = 12;
            complementoLabel.Text = "Complemento";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(623, 77);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 14;
            cepLabel.Text = "CEP";
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(Data.Entidades.empresa);
            // 
            // razao_socialTextBox
            // 
            this.razao_socialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "razao_social", true));
            this.razao_socialTextBox.Location = new System.Drawing.Point(139, 55);
            this.razao_socialTextBox.Name = "razao_socialTextBox";
            this.razao_socialTextBox.Size = new System.Drawing.Size(421, 20);
            this.razao_socialTextBox.TabIndex = 2;
            // 
            // cnpjMaskedTextBox
            // 
            this.cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "cnpj", true));
            this.cnpjMaskedTextBox.Location = new System.Drawing.Point(566, 55);
            this.cnpjMaskedTextBox.Mask = "0.000.000/0000-00";
            this.cnpjMaskedTextBox.Name = "cnpjMaskedTextBox";
            this.cnpjMaskedTextBox.Size = new System.Drawing.Size(134, 20);
            this.cnpjMaskedTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 153);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 153);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(139, 92);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(250, 20);
            this.enderecoTextBox.TabIndex = 7;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(395, 92);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(43, 20);
            this.numeroTextBox.TabIndex = 9;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(444, 92);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(176, 20);
            this.bairroTextBox.TabIndex = 11;
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "complemento", true));
            this.complementoTextBox.Location = new System.Drawing.Point(139, 130);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(211, 20);
            this.complementoTextBox.TabIndex = 13;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "cep", true));
            this.cepMaskedTextBox.Location = new System.Drawing.Point(626, 92);
            this.cepMaskedTextBox.Mask = "00.000-000";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(74, 20);
            this.cepMaskedTextBox.TabIndex = 15;
            // 
            // pesquisaMunicipio1
            // 
            this.pesquisaMunicipio1.Location = new System.Drawing.Point(351, 112);
            this.pesquisaMunicipio1.Name = "pesquisaMunicipio1";
            this.pesquisaMunicipio1.Size = new System.Drawing.Size(293, 39);
            this.pesquisaMunicipio1.TabIndex = 17;
            // 
            // lookup1
            // 
            this.lookup1.Location = new System.Drawing.Point(139, 156);
            this.lookup1.Name = "lookup1";
            this.lookup1.Size = new System.Drawing.Size(353, 37);
            this.lookup1.TabIndex = 18;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 236);
            this.Controls.Add(this.lookup1);
            this.Controls.Add(this.pesquisaMunicipio1);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepMaskedTextBox);
            this.Controls.Add(complementoLabel);
            this.Controls.Add(this.complementoTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjMaskedTextBox);
            this.Controls.Add(razao_socialLabel);
            this.Controls.Add(this.razao_socialTextBox);
            this.Name = "frmEmpresa";
            this.Text = "Empresa";
            this.Controls.SetChildIndex(this.razao_socialTextBox, 0);
            this.Controls.SetChildIndex(razao_socialLabel, 0);
            this.Controls.SetChildIndex(this.cnpjMaskedTextBox, 0);
            this.Controls.SetChildIndex(cnpjLabel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.enderecoTextBox, 0);
            this.Controls.SetChildIndex(enderecoLabel, 0);
            this.Controls.SetChildIndex(this.numeroTextBox, 0);
            this.Controls.SetChildIndex(numeroLabel, 0);
            this.Controls.SetChildIndex(this.bairroTextBox, 0);
            this.Controls.SetChildIndex(bairroLabel, 0);
            this.Controls.SetChildIndex(this.complementoTextBox, 0);
            this.Controls.SetChildIndex(complementoLabel, 0);
            this.Controls.SetChildIndex(this.cepMaskedTextBox, 0);
            this.Controls.SetChildIndex(cepLabel, 0);
            this.Controls.SetChildIndex(this.pesquisaMunicipio1, 0);
            this.Controls.SetChildIndex(this.lookup1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.TextBox razao_socialTextBox;
        private System.Windows.Forms.MaskedTextBox cnpjMaskedTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox complementoTextBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private PesquisaMunicipio pesquisaMunicipio1;
        private Lookup lookup1;
    }
}