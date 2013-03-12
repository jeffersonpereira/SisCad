namespace SisCad.Forms
{
    partial class Lookup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(0, 16);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(292, 20);
            this.valueTextBox.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(-3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(43, 13);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Lookup";
            // 
            // btnShow
            // 
            this.btnShow.Image = global::SisCad.Properties.Resources.system_search;
            this.btnShow.Location = new System.Drawing.Point(292, 17);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(24, 20);
            this.btnShow.TabIndex = 2;
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = global::SisCad.Properties.Resources.edit_trash;
            this.btnClear.Location = new System.Drawing.Point(315, 17);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(24, 20);
            this.btnClear.TabIndex = 2;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Lookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.valueTextBox);
            this.Name = "Lookup";
            this.Size = new System.Drawing.Size(341, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnShow;
    }
}
