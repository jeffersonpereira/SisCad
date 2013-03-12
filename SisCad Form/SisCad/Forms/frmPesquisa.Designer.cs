namespace SisCad
{
    partial class frmPesquisa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datetimePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataF = new System.Windows.Forms.DateTimePicker();
            this.dataI = new System.Windows.Forms.DateTimePicker();
            this.intPanel = new System.Windows.Forms.Panel();
            this.valueF = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valueI = new System.Windows.Forms.NumericUpDown();
            this.stringPanel = new System.Windows.Forms.Panel();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filtroComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultadoListView = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.datetimePanel.SuspendLayout();
            this.intPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueI)).BeginInit();
            this.stringPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datetimePanel);
            this.groupBox1.Controls.Add(this.intPanel);
            this.groupBox1.Controls.Add(this.stringPanel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.filtroComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // datetimePanel
            // 
            this.datetimePanel.Controls.Add(this.label2);
            this.datetimePanel.Controls.Add(this.label1);
            this.datetimePanel.Controls.Add(this.dataF);
            this.datetimePanel.Controls.Add(this.dataI);
            this.datetimePanel.Location = new System.Drawing.Point(133, 16);
            this.datetimePanel.Name = "datetimePanel";
            this.datetimePanel.Size = new System.Drawing.Size(387, 41);
            this.datetimePanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial";
            // 
            // dataF
            // 
            this.dataF.CustomFormat = "dd/MM/yyyy";
            this.dataF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataF.Location = new System.Drawing.Point(126, 18);
            this.dataF.Name = "dataF";
            this.dataF.Size = new System.Drawing.Size(117, 20);
            this.dataF.TabIndex = 0;
            // 
            // dataI
            // 
            this.dataI.CustomFormat = "dd/MM/yyyy";
            this.dataI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataI.Location = new System.Drawing.Point(3, 18);
            this.dataI.Name = "dataI";
            this.dataI.Size = new System.Drawing.Size(117, 20);
            this.dataI.TabIndex = 0;
            // 
            // intPanel
            // 
            this.intPanel.Controls.Add(this.valueF);
            this.intPanel.Controls.Add(this.label5);
            this.intPanel.Controls.Add(this.label4);
            this.intPanel.Controls.Add(this.valueI);
            this.intPanel.Location = new System.Drawing.Point(133, 16);
            this.intPanel.Name = "intPanel";
            this.intPanel.Size = new System.Drawing.Size(384, 41);
            this.intPanel.TabIndex = 3;
            // 
            // valueF
            // 
            this.valueF.Location = new System.Drawing.Point(129, 21);
            this.valueF.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valueF.Name = "valueF";
            this.valueF.Size = new System.Drawing.Size(120, 20);
            this.valueF.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor Inicial";
            // 
            // valueI
            // 
            this.valueI.Location = new System.Drawing.Point(3, 21);
            this.valueI.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valueI.Name = "valueI";
            this.valueI.Size = new System.Drawing.Size(120, 20);
            this.valueI.TabIndex = 0;
            // 
            // stringPanel
            // 
            this.stringPanel.Controls.Add(this.descricao);
            this.stringPanel.Controls.Add(this.label3);
            this.stringPanel.Location = new System.Drawing.Point(133, 16);
            this.stringPanel.Name = "stringPanel";
            this.stringPanel.Size = new System.Drawing.Size(387, 41);
            this.stringPanel.TabIndex = 3;
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(3, 18);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(376, 20);
            this.descricao.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descrição";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // filtroComboBox
            // 
            this.filtroComboBox.FormattingEnabled = true;
            this.filtroComboBox.Location = new System.Drawing.Point(6, 34);
            this.filtroComboBox.Name = "filtroComboBox";
            this.filtroComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtroComboBox.TabIndex = 0;
            this.filtroComboBox.SelectedIndexChanged += new System.EventHandler(this.filtroComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultadoListView);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 326);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // resultadoListView
            // 
            this.resultadoListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadoListView.FullRowSelect = true;
            this.resultadoListView.Location = new System.Drawing.Point(3, 16);
            this.resultadoListView.Name = "resultadoListView";
            this.resultadoListView.Size = new System.Drawing.Size(596, 307);
            this.resultadoListView.TabIndex = 0;
            this.resultadoListView.UseCompatibleStateImageBehavior = false;
            this.resultadoListView.View = System.Windows.Forms.View.Details;
            this.resultadoListView.SelectedIndexChanged += new System.EventHandler(this.resultadoListView_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 449);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.groupBox1.ResumeLayout(false);
            this.datetimePanel.ResumeLayout(false);
            this.datetimePanel.PerformLayout();
            this.intPanel.ResumeLayout(false);
            this.intPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueI)).EndInit();
            this.stringPanel.ResumeLayout(false);
            this.stringPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox filtroComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView resultadoListView;
        private System.Windows.Forms.Panel datetimePanel;
        private System.Windows.Forms.DateTimePicker dataF;
        private System.Windows.Forms.DateTimePicker dataI;
        private System.Windows.Forms.Panel intPanel;
        private System.Windows.Forms.Panel stringPanel;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown valueF;
        private System.Windows.Forms.NumericUpDown valueI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}