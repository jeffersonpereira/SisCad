namespace SisCad.Forms
{
    partial class frmSetor
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
            this.setorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.lookupDepartamento = new SisCad.Forms.Lookup();
            this.lookupCentroCusto = new SisCad.Forms.Lookup();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(9, 30);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(55, 13);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descrição";
            // 
            // setorBindingSource
            // 
            this.setorBindingSource.DataSource = typeof(Model.Data.setor);
            this.setorBindingSource.DataSourceChanged += new System.EventHandler(this.setorBindingSource_DataSourceChanged);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setorBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(12, 46);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(351, 20);
            this.descricaoTextBox.TabIndex = 2;
            // 
            // lookupDepartamento
            // 
            this.lookupDepartamento.AutoSize = true;
            this.lookupDepartamento.Location = new System.Drawing.Point(10, 72);
            this.lookupDepartamento.Name = "lookupDepartamento";
            this.lookupDepartamento.Size = new System.Drawing.Size(353, 40);
            this.lookupDepartamento.TabIndex = 3;
            // 
            // lookupCentroCusto
            // 
            this.lookupCentroCusto.AutoSize = true;
            this.lookupCentroCusto.Location = new System.Drawing.Point(10, 118);
            this.lookupCentroCusto.Name = "lookupCentroCusto";
            this.lookupCentroCusto.Size = new System.Drawing.Size(345, 40);
            this.lookupCentroCusto.TabIndex = 4;
            // 
            // frmSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 196);
            this.Controls.Add(this.lookupCentroCusto);
            this.Controls.Add(this.lookupDepartamento);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Name = "frmSetor";
            this.Text = "Setor";
            this.Load += new System.EventHandler(this.frmSetor_Load);
            this.Controls.SetChildIndex(this.descricaoTextBox, 0);
            this.Controls.SetChildIndex(descricaoLabel, 0);
            this.Controls.SetChildIndex(this.lookupDepartamento, 0);
            this.Controls.SetChildIndex(this.lookupCentroCusto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource setorBindingSource;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private Lookup lookupDepartamento;
        private Lookup lookupCentroCusto;
    }
}