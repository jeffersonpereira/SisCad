namespace SisCad.Forms
{
    partial class frmSelecaoFuncionario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.origemDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.destinoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.valueComboBox = new System.Windows.Forms.ComboBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemoveTodos = new System.Windows.Forms.Button();
            this.btnRemoveUm = new System.Windows.Forms.Button();
            this.btnAddUm = new System.Windows.Forms.Button();
            this.btnAddTodos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.origemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matriculaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.origemDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinoDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.origemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.origemDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origem";
            // 
            // origemDataGridView
            // 
            this.origemDataGridView.AllowUserToAddRows = false;
            this.origemDataGridView.AllowUserToDeleteRows = false;
            this.origemDataGridView.AutoGenerateColumns = false;
            this.origemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.origemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.origemDataGridView.DataSource = this.origemBindingSource;
            this.origemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.origemDataGridView.Location = new System.Drawing.Point(3, 16);
            this.origemDataGridView.Name = "origemDataGridView";
            this.origemDataGridView.ReadOnly = true;
            this.origemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.origemDataGridView.Size = new System.Drawing.Size(281, 280);
            this.origemDataGridView.TabIndex = 0;
            this.origemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.origemDataGridView_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.destinoDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(367, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // destinoDataGridView
            // 
            this.destinoDataGridView.AllowUserToAddRows = false;
            this.destinoDataGridView.AllowUserToDeleteRows = false;
            this.destinoDataGridView.AutoGenerateColumns = false;
            this.destinoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.destinoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1});
            this.destinoDataGridView.DataSource = this.destinoBindingSource;
            this.destinoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinoDataGridView.Location = new System.Drawing.Point(3, 16);
            this.destinoDataGridView.Name = "destinoDataGridView";
            this.destinoDataGridView.ReadOnly = true;
            this.destinoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.destinoDataGridView.Size = new System.Drawing.Size(281, 280);
            this.destinoDataGridView.TabIndex = 0;
            this.destinoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.destinoDataGridView_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.valueComboBox);
            this.groupBox3.Controls.Add(this.valueTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tituloLabel);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 62);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleção";
            // 
            // valueComboBox
            // 
            this.valueComboBox.FormattingEnabled = true;
            this.valueComboBox.Location = new System.Drawing.Point(133, 36);
            this.valueComboBox.Name = "valueComboBox";
            this.valueComboBox.Size = new System.Drawing.Size(503, 21);
            this.valueComboBox.TabIndex = 7;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(133, 36);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(503, 20);
            this.valueTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(133, 20);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(35, 13);
            this.tituloLabel.TabIndex = 2;
            this.tituloLabel.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nome",
            "Matrícula",
            "Setor",
            "Departamento",
            "Centro de Custo",
            "Vínculo"});
            this.comboBox1.Location = new System.Drawing.Point(6, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemoveTodos);
            this.groupBox4.Controls.Add(this.btnRemoveUm);
            this.groupBox4.Controls.Add(this.btnAddUm);
            this.groupBox4.Controls.Add(this.btnAddTodos);
            this.groupBox4.Location = new System.Drawing.Point(305, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(56, 299);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnRemoveTodos
            // 
            this.btnRemoveTodos.Location = new System.Drawing.Point(8, 191);
            this.btnRemoveTodos.Name = "btnRemoveTodos";
            this.btnRemoveTodos.Size = new System.Drawing.Size(36, 36);
            this.btnRemoveTodos.TabIndex = 0;
            this.btnRemoveTodos.Text = ">>";
            this.btnRemoveTodos.UseVisualStyleBackColor = true;
            this.btnRemoveTodos.Click += new System.EventHandler(this.btnRemoveTodos_Click);
            // 
            // btnRemoveUm
            // 
            this.btnRemoveUm.Location = new System.Drawing.Point(8, 149);
            this.btnRemoveUm.Name = "btnRemoveUm";
            this.btnRemoveUm.Size = new System.Drawing.Size(36, 36);
            this.btnRemoveUm.TabIndex = 0;
            this.btnRemoveUm.Text = "<";
            this.btnRemoveUm.UseVisualStyleBackColor = true;
            this.btnRemoveUm.Click += new System.EventHandler(this.btnRemoveUm_Click);
            // 
            // btnAddUm
            // 
            this.btnAddUm.Location = new System.Drawing.Point(8, 107);
            this.btnAddUm.Name = "btnAddUm";
            this.btnAddUm.Size = new System.Drawing.Size(36, 36);
            this.btnAddUm.TabIndex = 0;
            this.btnAddUm.Text = ">";
            this.btnAddUm.UseVisualStyleBackColor = true;
            this.btnAddUm.Click += new System.EventHandler(this.btnAddUm_Click);
            // 
            // btnAddTodos
            // 
            this.btnAddTodos.Location = new System.Drawing.Point(8, 65);
            this.btnAddTodos.Name = "btnAddTodos";
            this.btnAddTodos.Size = new System.Drawing.Size(36, 36);
            this.btnAddTodos.TabIndex = 0;
            this.btnAddTodos.Text = ">>";
            this.btnAddTodos.UseVisualStyleBackColor = true;
            this.btnAddTodos.Click += new System.EventHandler(this.btnAddTodos_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(576, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // origemBindingSource
            // 
            this.origemBindingSource.DataSource = typeof(Model.Data.funcionario);
            // 
            // destinoBindingSource
            // 
            this.destinoBindingSource.DataSource = typeof(Model.Data.funcionario);
            // 
            // matriculaDataGridViewTextBoxColumn1
            // 
            this.matriculaDataGridViewTextBoxColumn1.DataPropertyName = "matricula";
            this.matriculaDataGridViewTextBoxColumn1.HeaderText = "Matrícula";
            this.matriculaDataGridViewTextBoxColumn1.Name = "matriculaDataGridViewTextBoxColumn1";
            this.matriculaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.matriculaDataGridViewTextBoxColumn1.Width = 60;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matrícula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculaDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmSelecaoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 422);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSelecaoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Funcionário";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.origemDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destinoDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.origemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView origemDataGridView;
        private System.Windows.Forms.DataGridView destinoDataGridView;
        private System.Windows.Forms.Button btnRemoveTodos;
        private System.Windows.Forms.Button btnRemoveUm;
        private System.Windows.Forms.Button btnAddUm;
        private System.Windows.Forms.Button btnAddTodos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox valueComboBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.BindingSource origemBindingSource;
        private System.Windows.Forms.BindingSource destinoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
    }
}