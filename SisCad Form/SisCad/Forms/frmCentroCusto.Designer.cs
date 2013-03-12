namespace SisCad.Forms
{
    partial class frmCentroCusto
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label codigoLabel;
            this.centro_custoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            descricaoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.centro_custoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(82, 28);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(55, 13);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descrição";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(9, 28);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(40, 13);
            codigoLabel.TabIndex = 8;
            codigoLabel.Text = "Código";
            // 
            // centro_custoBindingSource
            // 
            this.centro_custoBindingSource.DataSource = typeof(Model.Data.centro_custo);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centro_custoBindingSource, "descricao", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.descricaoTextBox.Location = new System.Drawing.Point(85, 44);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(388, 20);
            this.descricaoTextBox.TabIndex = 2;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centro_custoBindingSource, "codigo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.codigoTextBox.Location = new System.Drawing.Point(12, 44);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(67, 20);
            this.codigoTextBox.TabIndex = 9;
            // 
            // frmCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 87);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Name = "frmCentroCusto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Custo";
            this.Controls.SetChildIndex(this.descricaoTextBox, 0);
            this.Controls.SetChildIndex(descricaoLabel, 0);
            this.Controls.SetChildIndex(this.codigoTextBox, 0);
            this.Controls.SetChildIndex(codigoLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.centro_custoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource centro_custoBindingSource;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
    }
}