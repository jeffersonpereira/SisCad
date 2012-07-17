namespace SisCad.Forms
{
    partial class frmFerias
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
            System.Windows.Forms.Label fim_aquisicaoLabel;
            System.Windows.Forms.Label inicio_aquisicaoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.feriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fim_aquisicaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inicio_aquisicaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.abono_pecuniarioCheckBox = new System.Windows.Forms.CheckBox();
            this.lookup1 = new SisCad.Forms.Lookup();
            fim_aquisicaoLabel = new System.Windows.Forms.Label();
            inicio_aquisicaoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.feriasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fim_aquisicaoLabel
            // 
            fim_aquisicaoLabel.AutoSize = true;
            fim_aquisicaoLabel.Location = new System.Drawing.Point(109, 22);
            fim_aquisicaoLabel.Name = "fim_aquisicaoLabel";
            fim_aquisicaoLabel.Size = new System.Drawing.Size(23, 13);
            fim_aquisicaoLabel.TabIndex = 1;
            fim_aquisicaoLabel.Text = "Fim";
            // 
            // inicio_aquisicaoLabel
            // 
            inicio_aquisicaoLabel.AutoSize = true;
            inicio_aquisicaoLabel.Location = new System.Drawing.Point(6, 22);
            inicio_aquisicaoLabel.Name = "inicio_aquisicaoLabel";
            inicio_aquisicaoLabel.Size = new System.Drawing.Size(32, 13);
            inicio_aquisicaoLabel.TabIndex = 2;
            inicio_aquisicaoLabel.Text = "Inicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 13);
            label1.TabIndex = 2;
            label1.Text = "Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(109, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(23, 13);
            label2.TabIndex = 1;
            label2.Text = "Fim";
            // 
            // feriasBindingSource
            // 
            this.feriasBindingSource.DataSource = typeof(Data.Entidades.ferias);
            // 
            // fim_aquisicaoMaskedTextBox
            // 
            this.fim_aquisicaoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feriasBindingSource, "fim_aquisicao", true));
            this.fim_aquisicaoMaskedTextBox.Location = new System.Drawing.Point(112, 38);
            this.fim_aquisicaoMaskedTextBox.Mask = "00/00/0000";
            this.fim_aquisicaoMaskedTextBox.Name = "fim_aquisicaoMaskedTextBox";
            this.fim_aquisicaoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.fim_aquisicaoMaskedTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(inicio_aquisicaoLabel);
            this.groupBox1.Controls.Add(this.inicio_aquisicaoMaskedTextBox);
            this.groupBox1.Controls.Add(this.fim_aquisicaoMaskedTextBox);
            this.groupBox1.Controls.Add(fim_aquisicaoLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período Aquisitivo";
            // 
            // inicio_aquisicaoMaskedTextBox
            // 
            this.inicio_aquisicaoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feriasBindingSource, "inicio_aquisicao", true));
            this.inicio_aquisicaoMaskedTextBox.Location = new System.Drawing.Point(6, 38);
            this.inicio_aquisicaoMaskedTextBox.Mask = "00/00/0000";
            this.inicio_aquisicaoMaskedTextBox.Name = "inicio_aquisicaoMaskedTextBox";
            this.inicio_aquisicaoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.inicio_aquisicaoMaskedTextBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Location = new System.Drawing.Point(235, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 62);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gozo";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feriasBindingSource, "inicio_gozo", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 38);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feriasBindingSource, "fim_gozo", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(112, 38);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 2;
            // 
            // abono_pecuniarioCheckBox
            // 
            this.abono_pecuniarioCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.feriasBindingSource, "abono_pecuniario", true));
            this.abono_pecuniarioCheckBox.Location = new System.Drawing.Point(12, 153);
            this.abono_pecuniarioCheckBox.Name = "abono_pecuniarioCheckBox";
            this.abono_pecuniarioCheckBox.Size = new System.Drawing.Size(161, 24);
            this.abono_pecuniarioCheckBox.TabIndex = 4;
            this.abono_pecuniarioCheckBox.Text = "Abono Pecuniário de Férias";
            this.abono_pecuniarioCheckBox.UseVisualStyleBackColor = true;
            // 
            // lookup1
            // 
            this.lookup1.Location = new System.Drawing.Point(9, 28);
            this.lookup1.Name = "lookup1";
            this.lookup1.Size = new System.Drawing.Size(353, 37);
            this.lookup1.TabIndex = 5;
            // 
            // frmFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 198);
            this.Controls.Add(this.lookup1);
            this.Controls.Add(this.abono_pecuniarioCheckBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Férias";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.abono_pecuniarioCheckBox, 0);
            this.Controls.SetChildIndex(this.lookup1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.feriasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource feriasBindingSource;
        private System.Windows.Forms.MaskedTextBox fim_aquisicaoMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox inicio_aquisicaoMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.CheckBox abono_pecuniarioCheckBox;
        private Lookup lookup1;
    }
}