namespace SisCad.Forms
{
    partial class frmSelecaoEmpresa
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
            this.empresaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnGestor = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empresaComboBox
            // 
            this.empresaComboBox.FormattingEnabled = true;
            this.empresaComboBox.Location = new System.Drawing.Point(12, 36);
            this.empresaComboBox.Name = "empresaComboBox";
            this.empresaComboBox.Size = new System.Drawing.Size(384, 21);
            this.empresaComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(321, 63);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnGestor
            // 
            this.btnGestor.Location = new System.Drawing.Point(12, 63);
            this.btnGestor.Name = "btnGestor";
            this.btnGestor.Size = new System.Drawing.Size(75, 23);
            this.btnGestor.TabIndex = 3;
            this.btnGestor.Text = "Gestor";
            this.btnGestor.UseVisualStyleBackColor = true;
            this.btnGestor.Click += new System.EventHandler(this.btnGestor_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(93, 63);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnEmpresa.TabIndex = 4;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // frmSelecaoEmpresa
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 103);
            this.ControlBox = false;
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnGestor);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empresaComboBox);
            this.Name = "frmSelecaoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Empresa";
            this.Load += new System.EventHandler(this.frmSelecaoEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox empresaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnGestor;
        private System.Windows.Forms.Button btnEmpresa;
    }
}