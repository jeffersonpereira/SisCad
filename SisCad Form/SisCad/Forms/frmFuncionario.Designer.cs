namespace SisCad.Forms
{
    partial class frmFuncionario
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label paiLabel;
            System.Windows.Forms.Label maeLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label pisLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label data_emissao_rgLabel;
            System.Windows.Forms.Label orgao_emissor_rgLabel;
            System.Windows.Forms.Label cnhLabel;
            System.Windows.Forms.Label data_expedicao_cnhLabel;
            System.Windows.Forms.Label categoria_cnhLabel;
            System.Windows.Forms.Label ctpsLabel;
            System.Windows.Forms.Label serieLabel;
            System.Windows.Forms.Label titulo_eleitorLabel;
            System.Windows.Forms.Label zonaLabel;
            System.Windows.Forms.Label secaoLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label telefone_residencialLabel;
            System.Windows.Forms.Label telefone_recadoLabel;
            System.Windows.Forms.Label telefone_celularLabel;
            System.Windows.Forms.Label data_admissaoLabel;
            System.Windows.Forms.Label salario_atualLabel;
            System.Windows.Forms.Label salario_inicialLabel;
            System.Windows.Forms.Label grau_instrucaoLabel;
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label estado_civilLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.funcionarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.data_nascimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pesquisaMunicipio = new SisCad.Forms.PesquisaMunicipio();
            this.paiTextBox = new System.Windows.Forms.TextBox();
            this.maeTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.secaoTextBox = new System.Windows.Forms.TextBox();
            this.zonaTextBox = new System.Windows.Forms.TextBox();
            this.titulo_eleitorTextBox = new System.Windows.Forms.TextBox();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.ctpsTextBox = new System.Windows.Forms.TextBox();
            this.categoria_cnhTextBox = new System.Windows.Forms.TextBox();
            this.data_expedicao_cnhMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cnhTextBox = new System.Windows.Forms.TextBox();
            this.orgao_emissor_rgTextBox = new System.Windows.Forms.TextBox();
            this.data_emissao_rgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rgTextBox = new System.Windows.Forms.TextBox();
            this.pisMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lookup4 = new SisCad.Forms.Lookup();
            this.lookup2 = new SisCad.Forms.Lookup();
            this.lookup1 = new SisCad.Forms.Lookup();
            this.salario_inicialTextBox = new System.Windows.Forms.TextBox();
            this.salario_atualTextBox = new System.Windows.Forms.TextBox();
            this.data_admissaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.estado_civilComboBox = new System.Windows.Forms.ComboBox();
            this.lookup3 = new SisCad.Forms.Lookup();
            this.corComboBox = new System.Windows.Forms.ComboBox();
            this.grau_instrucaoComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dependenteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.feriasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.feriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.movimentacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.telefone_residencialMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefone_recadoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefone_celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            nomeLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            paiLabel = new System.Windows.Forms.Label();
            maeLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            pisLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            data_emissao_rgLabel = new System.Windows.Forms.Label();
            orgao_emissor_rgLabel = new System.Windows.Forms.Label();
            cnhLabel = new System.Windows.Forms.Label();
            data_expedicao_cnhLabel = new System.Windows.Forms.Label();
            categoria_cnhLabel = new System.Windows.Forms.Label();
            ctpsLabel = new System.Windows.Forms.Label();
            serieLabel = new System.Windows.Forms.Label();
            titulo_eleitorLabel = new System.Windows.Forms.Label();
            zonaLabel = new System.Windows.Forms.Label();
            secaoLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            telefone_residencialLabel = new System.Windows.Forms.Label();
            telefone_recadoLabel = new System.Windows.Forms.Label();
            telefone_celularLabel = new System.Windows.Forms.Label();
            data_admissaoLabel = new System.Windows.Forms.Label();
            salario_atualLabel = new System.Windows.Forms.Label();
            salario_inicialLabel = new System.Windows.Forms.Label();
            grau_instrucaoLabel = new System.Windows.Forms.Label();
            corLabel = new System.Windows.Forms.Label();
            estado_civilLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).BeginInit();
            this.funcionarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dependenteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependenteBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feriasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriasBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(206, 36);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(35, 13);
            nomeLabel.TabIndex = 7;
            nomeLabel.Text = "Nome";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(512, 36);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(31, 13);
            sexoLabel.TabIndex = 8;
            sexoLabel.Text = "Sexo";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Location = new System.Drawing.Point(600, 37);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(63, 13);
            data_nascimentoLabel.TabIndex = 9;
            data_nascimentoLabel.Text = "Nascimento";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(136, 77);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(53, 13);
            enderecoLabel.TabIndex = 10;
            enderecoLabel.Text = "Endereço";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(418, 77);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(44, 13);
            numeroLabel.TabIndex = 11;
            numeroLabel.Text = "Número";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(485, 77);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(34, 13);
            bairroLabel.TabIndex = 12;
            bairroLabel.Text = "Bairro";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(136, 114);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 14;
            cepLabel.Text = "CEP";
            // 
            // paiLabel
            // 
            paiLabel.AutoSize = true;
            paiLabel.Location = new System.Drawing.Point(136, 151);
            paiLabel.Name = "paiLabel";
            paiLabel.Size = new System.Drawing.Size(22, 13);
            paiLabel.TabIndex = 17;
            paiLabel.Text = "Pai";
            // 
            // maeLabel
            // 
            maeLabel.AutoSize = true;
            maeLabel.Location = new System.Drawing.Point(418, 151);
            maeLabel.Name = "maeLabel";
            maeLabel.Size = new System.Drawing.Size(28, 13);
            maeLabel.TabIndex = 19;
            maeLabel.Text = "Mãe";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(3, 9);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(27, 13);
            cpfLabel.TabIndex = 0;
            cpfLabel.Text = "CPF";
            // 
            // pisLabel
            // 
            pisLabel.AutoSize = true;
            pisLabel.Location = new System.Drawing.Point(109, 9);
            pisLabel.Name = "pisLabel";
            pisLabel.Size = new System.Drawing.Size(56, 13);
            pisLabel.TabIndex = 2;
            pisLabel.Text = "Pis/Pasep";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new System.Drawing.Point(215, 9);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(23, 13);
            rgLabel.TabIndex = 4;
            rgLabel.Text = "RG";
            // 
            // data_emissao_rgLabel
            // 
            data_emissao_rgLabel.AutoSize = true;
            data_emissao_rgLabel.Location = new System.Drawing.Point(321, 9);
            data_emissao_rgLabel.Name = "data_emissao_rgLabel";
            data_emissao_rgLabel.Size = new System.Drawing.Size(46, 13);
            data_emissao_rgLabel.TabIndex = 6;
            data_emissao_rgLabel.Text = "Emissão";
            // 
            // orgao_emissor_rgLabel
            // 
            orgao_emissor_rgLabel.AutoSize = true;
            orgao_emissor_rgLabel.Location = new System.Drawing.Point(427, 9);
            orgao_emissor_rgLabel.Name = "orgao_emissor_rgLabel";
            orgao_emissor_rgLabel.Size = new System.Drawing.Size(94, 13);
            orgao_emissor_rgLabel.TabIndex = 8;
            orgao_emissor_rgLabel.Text = "Órgão Emissor/UF";
            // 
            // cnhLabel
            // 
            cnhLabel.AutoSize = true;
            cnhLabel.Location = new System.Drawing.Point(533, 9);
            cnhLabel.Name = "cnhLabel";
            cnhLabel.Size = new System.Drawing.Size(30, 13);
            cnhLabel.TabIndex = 10;
            cnhLabel.Text = "CNH";
            // 
            // data_expedicao_cnhLabel
            // 
            data_expedicao_cnhLabel.AutoSize = true;
            data_expedicao_cnhLabel.Location = new System.Drawing.Point(109, 47);
            data_expedicao_cnhLabel.Name = "data_expedicao_cnhLabel";
            data_expedicao_cnhLabel.Size = new System.Drawing.Size(83, 13);
            data_expedicao_cnhLabel.TabIndex = 13;
            data_expedicao_cnhLabel.Text = "Expedição CNH";
            // 
            // categoria_cnhLabel
            // 
            categoria_cnhLabel.AutoSize = true;
            categoria_cnhLabel.Location = new System.Drawing.Point(6, 48);
            categoria_cnhLabel.Name = "categoria_cnhLabel";
            categoria_cnhLabel.Size = new System.Drawing.Size(78, 13);
            categoria_cnhLabel.TabIndex = 14;
            categoria_cnhLabel.Text = "Categoria CNH";
            // 
            // ctpsLabel
            // 
            ctpsLabel.AutoSize = true;
            ctpsLabel.Location = new System.Drawing.Point(215, 48);
            ctpsLabel.Name = "ctpsLabel";
            ctpsLabel.Size = new System.Drawing.Size(35, 13);
            ctpsLabel.TabIndex = 16;
            ctpsLabel.Text = "CTPS";
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Location = new System.Drawing.Point(321, 47);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(31, 13);
            serieLabel.TabIndex = 18;
            serieLabel.Text = "Série";
            // 
            // titulo_eleitorLabel
            // 
            titulo_eleitorLabel.AutoSize = true;
            titulo_eleitorLabel.Location = new System.Drawing.Point(427, 47);
            titulo_eleitorLabel.Name = "titulo_eleitorLabel";
            titulo_eleitorLabel.Size = new System.Drawing.Size(82, 13);
            titulo_eleitorLabel.TabIndex = 20;
            titulo_eleitorLabel.Text = "Título de Eleitor";
            // 
            // zonaLabel
            // 
            zonaLabel.AutoSize = true;
            zonaLabel.Location = new System.Drawing.Point(533, 48);
            zonaLabel.Name = "zonaLabel";
            zonaLabel.Size = new System.Drawing.Size(32, 13);
            zonaLabel.TabIndex = 22;
            zonaLabel.Text = "Zona";
            // 
            // secaoLabel
            // 
            secaoLabel.AutoSize = true;
            secaoLabel.Location = new System.Drawing.Point(614, 48);
            secaoLabel.Name = "secaoLabel";
            secaoLabel.Size = new System.Drawing.Size(38, 13);
            secaoLabel.TabIndex = 24;
            secaoLabel.Text = "Seção";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(136, 37);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(50, 13);
            matriculaLabel.TabIndex = 22;
            matriculaLabel.Text = "Mátricula";
            // 
            // telefone_residencialLabel
            // 
            telefone_residencialLabel.AutoSize = true;
            telefone_residencialLabel.Location = new System.Drawing.Point(138, 191);
            telefone_residencialLabel.Name = "telefone_residencialLabel";
            telefone_residencialLabel.Size = new System.Drawing.Size(107, 13);
            telefone_residencialLabel.TabIndex = 24;
            telefone_residencialLabel.Text = "Telefone Residencial";
            // 
            // telefone_recadoLabel
            // 
            telefone_recadoLabel.AutoSize = true;
            telefone_recadoLabel.Location = new System.Drawing.Point(242, 191);
            telefone_recadoLabel.Name = "telefone_recadoLabel";
            telefone_recadoLabel.Size = new System.Drawing.Size(90, 13);
            telefone_recadoLabel.TabIndex = 26;
            telefone_recadoLabel.Text = "Telefone Recado";
            // 
            // telefone_celularLabel
            // 
            telefone_celularLabel.AutoSize = true;
            telefone_celularLabel.Location = new System.Drawing.Point(348, 191);
            telefone_celularLabel.Name = "telefone_celularLabel";
            telefone_celularLabel.Size = new System.Drawing.Size(39, 13);
            telefone_celularLabel.TabIndex = 28;
            telefone_celularLabel.Text = "Celular";
            // 
            // data_admissaoLabel
            // 
            data_admissaoLabel.AutoSize = true;
            data_admissaoLabel.Location = new System.Drawing.Point(3, 6);
            data_admissaoLabel.Name = "data_admissaoLabel";
            data_admissaoLabel.Size = new System.Drawing.Size(93, 13);
            data_admissaoLabel.TabIndex = 0;
            data_admissaoLabel.Text = "Data de Admissão";
            // 
            // salario_atualLabel
            // 
            salario_atualLabel.AutoSize = true;
            salario_atualLabel.Location = new System.Drawing.Point(109, 6);
            salario_atualLabel.Name = "salario_atualLabel";
            salario_atualLabel.Size = new System.Drawing.Size(66, 13);
            salario_atualLabel.TabIndex = 2;
            salario_atualLabel.Text = "Salário Atual";
            // 
            // salario_inicialLabel
            // 
            salario_inicialLabel.AutoSize = true;
            salario_inicialLabel.Location = new System.Drawing.Point(215, 3);
            salario_inicialLabel.Name = "salario_inicialLabel";
            salario_inicialLabel.Size = new System.Drawing.Size(69, 13);
            salario_inicialLabel.TabIndex = 4;
            salario_inicialLabel.Text = "Salário Inicial";
            // 
            // grau_instrucaoLabel
            // 
            grau_instrucaoLabel.AutoSize = true;
            grau_instrucaoLabel.Location = new System.Drawing.Point(0, 6);
            grau_instrucaoLabel.Name = "grau_instrucaoLabel";
            grau_instrucaoLabel.Size = new System.Drawing.Size(92, 13);
            grau_instrucaoLabel.TabIndex = 0;
            grau_instrucaoLabel.Text = "Grau de Instrução";
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Location = new System.Drawing.Point(127, 6);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(23, 13);
            corLabel.TabIndex = 2;
            corLabel.Text = "Cor";
            // 
            // estado_civilLabel
            // 
            estado_civilLabel.AutoSize = true;
            estado_civilLabel.Location = new System.Drawing.Point(216, 6);
            estado_civilLabel.Name = "estado_civilLabel";
            estado_civilLabel.Size = new System.Drawing.Size(64, 13);
            estado_civilLabel.TabIndex = 5;
            estado_civilLabel.Text = "Estado Cívil";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 153);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // funcionarioBindingNavigator
            // 
            this.funcionarioBindingNavigator.AddNewItem = this.btnNovo;
            this.funcionarioBindingNavigator.BindingSource = this.funcionarioBindingSource;
            this.funcionarioBindingNavigator.CountItem = null;
            this.funcionarioBindingNavigator.DeleteItem = this.btnExcluir;
            this.funcionarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnExcluir,
            this.btnSalvar,
            this.btnEditar,
            this.btnCancelar,
            this.toolStripSeparator1,
            this.btnPesquisar,
            this.btnSair});
            this.funcionarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.funcionarioBindingNavigator.MoveFirstItem = null;
            this.funcionarioBindingNavigator.MoveLastItem = null;
            this.funcionarioBindingNavigator.MoveNextItem = null;
            this.funcionarioBindingNavigator.MovePreviousItem = null;
            this.funcionarioBindingNavigator.Name = "funcionarioBindingNavigator";
            this.funcionarioBindingNavigator.PositionItem = null;
            this.funcionarioBindingNavigator.Size = new System.Drawing.Size(731, 25);
            this.funcionarioBindingNavigator.TabIndex = 7;
            this.funcionarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::SisCad.Properties.Resources.edit_add;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.RightToLeftAutoMirrorImage = true;
            this.btnNovo.Size = new System.Drawing.Size(56, 22);
            this.btnNovo.Text = "Novo";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(Data.Entidades.funcionario);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::SisCad.Properties.Resources.delete;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeftAutoMirrorImage = true;
            this.btnExcluir.Size = new System.Drawing.Size(61, 22);
            this.btnExcluir.Text = "Excluir";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::SisCad.Properties.Resources.apply;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(58, 22);
            this.btnSalvar.Text = "Salvar";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::SisCad.Properties.Resources.edit;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 22);
            this.btnEditar.Text = "Editar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SisCad.Properties.Resources.editdelete;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::SisCad.Properties.Resources.system_search;
            this.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 22);
            this.btnPesquisar.Text = "Pesquisar";
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(46, 22);
            this.btnSair.Text = "Sair";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(209, 52);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(300, 20);
            this.nomeTextBox.TabIndex = 8;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "sexo", true));
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Location = new System.Drawing.Point(515, 52);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(82, 21);
            this.sexoComboBox.TabIndex = 9;
            // 
            // data_nascimentoMaskedTextBox
            // 
            this.data_nascimentoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "data_nascimento", true));
            this.data_nascimentoMaskedTextBox.Location = new System.Drawing.Point(603, 53);
            this.data_nascimentoMaskedTextBox.Mask = "00/00/0000";
            this.data_nascimentoMaskedTextBox.Name = "data_nascimentoMaskedTextBox";
            this.data_nascimentoMaskedTextBox.Size = new System.Drawing.Size(108, 20);
            this.data_nascimentoMaskedTextBox.TabIndex = 10;
            this.data_nascimentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(139, 93);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(276, 20);
            this.enderecoTextBox.TabIndex = 11;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(421, 93);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(61, 20);
            this.numeroTextBox.TabIndex = 12;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(488, 93);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(223, 20);
            this.bairroTextBox.TabIndex = 13;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "cep", true));
            this.cepMaskedTextBox.Location = new System.Drawing.Point(139, 130);
            this.cepMaskedTextBox.Mask = "00.000-999";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cepMaskedTextBox.TabIndex = 15;
            // 
            // pesquisaMunicipio
            // 
            this.pesquisaMunicipio.Location = new System.Drawing.Point(242, 111);
            this.pesquisaMunicipio.Name = "pesquisaMunicipio";
            this.pesquisaMunicipio.Size = new System.Drawing.Size(294, 43);
            this.pesquisaMunicipio.TabIndex = 16;
            // 
            // paiTextBox
            // 
            this.paiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "pai", true));
            this.paiTextBox.Location = new System.Drawing.Point(139, 167);
            this.paiTextBox.Name = "paiTextBox";
            this.paiTextBox.Size = new System.Drawing.Size(276, 20);
            this.paiTextBox.TabIndex = 18;
            // 
            // maeTextBox
            // 
            this.maeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "mae", true));
            this.maeTextBox.Location = new System.Drawing.Point(421, 167);
            this.maeTextBox.Name = "maeTextBox";
            this.maeTextBox.Size = new System.Drawing.Size(290, 20);
            this.maeTextBox.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 233);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 202);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(secaoLabel);
            this.tabPage1.Controls.Add(this.secaoTextBox);
            this.tabPage1.Controls.Add(zonaLabel);
            this.tabPage1.Controls.Add(this.zonaTextBox);
            this.tabPage1.Controls.Add(titulo_eleitorLabel);
            this.tabPage1.Controls.Add(this.titulo_eleitorTextBox);
            this.tabPage1.Controls.Add(serieLabel);
            this.tabPage1.Controls.Add(this.serieTextBox);
            this.tabPage1.Controls.Add(ctpsLabel);
            this.tabPage1.Controls.Add(this.ctpsTextBox);
            this.tabPage1.Controls.Add(categoria_cnhLabel);
            this.tabPage1.Controls.Add(this.categoria_cnhTextBox);
            this.tabPage1.Controls.Add(data_expedicao_cnhLabel);
            this.tabPage1.Controls.Add(this.data_expedicao_cnhMaskedTextBox);
            this.tabPage1.Controls.Add(cnhLabel);
            this.tabPage1.Controls.Add(this.cnhTextBox);
            this.tabPage1.Controls.Add(orgao_emissor_rgLabel);
            this.tabPage1.Controls.Add(this.orgao_emissor_rgTextBox);
            this.tabPage1.Controls.Add(data_emissao_rgLabel);
            this.tabPage1.Controls.Add(this.data_emissao_rgMaskedTextBox);
            this.tabPage1.Controls.Add(rgLabel);
            this.tabPage1.Controls.Add(this.rgTextBox);
            this.tabPage1.Controls.Add(pisLabel);
            this.tabPage1.Controls.Add(this.pisMaskedTextBox);
            this.tabPage1.Controls.Add(cpfLabel);
            this.tabPage1.Controls.Add(this.cpfMaskedTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Documentação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // secaoTextBox
            // 
            this.secaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "secao", true));
            this.secaoTextBox.Location = new System.Drawing.Point(617, 63);
            this.secaoTextBox.Name = "secaoTextBox";
            this.secaoTextBox.Size = new System.Drawing.Size(68, 20);
            this.secaoTextBox.TabIndex = 25;
            // 
            // zonaTextBox
            // 
            this.zonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "zona", true));
            this.zonaTextBox.Location = new System.Drawing.Point(536, 63);
            this.zonaTextBox.Name = "zonaTextBox";
            this.zonaTextBox.Size = new System.Drawing.Size(75, 20);
            this.zonaTextBox.TabIndex = 23;
            // 
            // titulo_eleitorTextBox
            // 
            this.titulo_eleitorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "titulo_eleitor", true));
            this.titulo_eleitorTextBox.Location = new System.Drawing.Point(430, 63);
            this.titulo_eleitorTextBox.Name = "titulo_eleitorTextBox";
            this.titulo_eleitorTextBox.Size = new System.Drawing.Size(100, 20);
            this.titulo_eleitorTextBox.TabIndex = 21;
            // 
            // serieTextBox
            // 
            this.serieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "serie", true));
            this.serieTextBox.Location = new System.Drawing.Point(324, 63);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(100, 20);
            this.serieTextBox.TabIndex = 19;
            // 
            // ctpsTextBox
            // 
            this.ctpsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "ctps", true));
            this.ctpsTextBox.Location = new System.Drawing.Point(218, 63);
            this.ctpsTextBox.Name = "ctpsTextBox";
            this.ctpsTextBox.Size = new System.Drawing.Size(100, 20);
            this.ctpsTextBox.TabIndex = 17;
            // 
            // categoria_cnhTextBox
            // 
            this.categoria_cnhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "categoria_cnh", true));
            this.categoria_cnhTextBox.Location = new System.Drawing.Point(6, 63);
            this.categoria_cnhTextBox.Name = "categoria_cnhTextBox";
            this.categoria_cnhTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoria_cnhTextBox.TabIndex = 15;
            // 
            // data_expedicao_cnhMaskedTextBox
            // 
            this.data_expedicao_cnhMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "data_expedicao_cnh", true));
            this.data_expedicao_cnhMaskedTextBox.Location = new System.Drawing.Point(112, 63);
            this.data_expedicao_cnhMaskedTextBox.Mask = "00/00/0000";
            this.data_expedicao_cnhMaskedTextBox.Name = "data_expedicao_cnhMaskedTextBox";
            this.data_expedicao_cnhMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_expedicao_cnhMaskedTextBox.TabIndex = 14;
            // 
            // cnhTextBox
            // 
            this.cnhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "cnh", true));
            this.cnhTextBox.Location = new System.Drawing.Point(536, 25);
            this.cnhTextBox.Name = "cnhTextBox";
            this.cnhTextBox.Size = new System.Drawing.Size(149, 20);
            this.cnhTextBox.TabIndex = 11;
            // 
            // orgao_emissor_rgTextBox
            // 
            this.orgao_emissor_rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "orgao_emissor_rg", true));
            this.orgao_emissor_rgTextBox.Location = new System.Drawing.Point(430, 25);
            this.orgao_emissor_rgTextBox.Name = "orgao_emissor_rgTextBox";
            this.orgao_emissor_rgTextBox.Size = new System.Drawing.Size(100, 20);
            this.orgao_emissor_rgTextBox.TabIndex = 9;
            // 
            // data_emissao_rgMaskedTextBox
            // 
            this.data_emissao_rgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "data_emissao_rg", true));
            this.data_emissao_rgMaskedTextBox.Location = new System.Drawing.Point(324, 25);
            this.data_emissao_rgMaskedTextBox.Mask = "00/00/0000";
            this.data_emissao_rgMaskedTextBox.Name = "data_emissao_rgMaskedTextBox";
            this.data_emissao_rgMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_emissao_rgMaskedTextBox.TabIndex = 7;
            this.data_emissao_rgMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // rgTextBox
            // 
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "rg", true));
            this.rgTextBox.Location = new System.Drawing.Point(218, 25);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(100, 20);
            this.rgTextBox.TabIndex = 5;
            // 
            // pisMaskedTextBox
            // 
            this.pisMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "pis", true));
            this.pisMaskedTextBox.Location = new System.Drawing.Point(112, 25);
            this.pisMaskedTextBox.Mask = "0.000.000.000-0";
            this.pisMaskedTextBox.Name = "pisMaskedTextBox";
            this.pisMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.pisMaskedTextBox.TabIndex = 3;
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "cpf", true));
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(6, 25);
            this.cpfMaskedTextBox.Mask = "000.000.000-00";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cpfMaskedTextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.lookup4);
            this.tabPage2.Controls.Add(this.lookup2);
            this.tabPage2.Controls.Add(this.lookup1);
            this.tabPage2.Controls.Add(salario_inicialLabel);
            this.tabPage2.Controls.Add(this.salario_inicialTextBox);
            this.tabPage2.Controls.Add(salario_atualLabel);
            this.tabPage2.Controls.Add(this.salario_atualTextBox);
            this.tabPage2.Controls.Add(data_admissaoLabel);
            this.tabPage2.Controls.Add(this.data_admissaoMaskedTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admissão";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lookup4
            // 
            this.lookup4.Location = new System.Drawing.Point(3, 91);
            this.lookup4.Name = "lookup4";
            this.lookup4.Size = new System.Drawing.Size(353, 37);
            this.lookup4.TabIndex = 10;
            // 
            // lookup2
            // 
            this.lookup2.Location = new System.Drawing.Point(3, 48);
            this.lookup2.Name = "lookup2";
            this.lookup2.Size = new System.Drawing.Size(353, 37);
            this.lookup2.TabIndex = 7;
            // 
            // lookup1
            // 
            this.lookup1.Location = new System.Drawing.Point(323, 7);
            this.lookup1.Name = "lookup1";
            this.lookup1.Size = new System.Drawing.Size(353, 37);
            this.lookup1.TabIndex = 6;
            // 
            // salario_inicialTextBox
            // 
            this.salario_inicialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "salario_inicial", true));
            this.salario_inicialTextBox.Location = new System.Drawing.Point(218, 22);
            this.salario_inicialTextBox.Name = "salario_inicialTextBox";
            this.salario_inicialTextBox.Size = new System.Drawing.Size(100, 20);
            this.salario_inicialTextBox.TabIndex = 5;
            // 
            // salario_atualTextBox
            // 
            this.salario_atualTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "salario_atual", true));
            this.salario_atualTextBox.Location = new System.Drawing.Point(112, 22);
            this.salario_atualTextBox.Name = "salario_atualTextBox";
            this.salario_atualTextBox.Size = new System.Drawing.Size(100, 20);
            this.salario_atualTextBox.TabIndex = 3;
            // 
            // data_admissaoMaskedTextBox
            // 
            this.data_admissaoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "data_admissao", true));
            this.data_admissaoMaskedTextBox.Location = new System.Drawing.Point(6, 22);
            this.data_admissaoMaskedTextBox.Name = "data_admissaoMaskedTextBox";
            this.data_admissaoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_admissaoMaskedTextBox.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(estado_civilLabel);
            this.tabPage3.Controls.Add(this.estado_civilComboBox);
            this.tabPage3.Controls.Add(this.lookup3);
            this.tabPage3.Controls.Add(corLabel);
            this.tabPage3.Controls.Add(this.corComboBox);
            this.tabPage3.Controls.Add(grau_instrucaoLabel);
            this.tabPage3.Controls.Add(this.grau_instrucaoComboBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(699, 176);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Características";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // estado_civilComboBox
            // 
            this.estado_civilComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "estado_civil", true));
            this.estado_civilComboBox.FormattingEnabled = true;
            this.estado_civilComboBox.Location = new System.Drawing.Point(216, 22);
            this.estado_civilComboBox.Name = "estado_civilComboBox";
            this.estado_civilComboBox.Size = new System.Drawing.Size(113, 21);
            this.estado_civilComboBox.TabIndex = 6;
            // 
            // lookup3
            // 
            this.lookup3.Location = new System.Drawing.Point(335, 6);
            this.lookup3.Name = "lookup3";
            this.lookup3.Size = new System.Drawing.Size(353, 37);
            this.lookup3.TabIndex = 4;
            // 
            // corComboBox
            // 
            this.corComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "cor", true));
            this.corComboBox.FormattingEnabled = true;
            this.corComboBox.Location = new System.Drawing.Point(130, 22);
            this.corComboBox.Name = "corComboBox";
            this.corComboBox.Size = new System.Drawing.Size(80, 21);
            this.corComboBox.TabIndex = 3;
            // 
            // grau_instrucaoComboBox
            // 
            this.grau_instrucaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "grau_instrucao", true));
            this.grau_instrucaoComboBox.FormattingEnabled = true;
            this.grau_instrucaoComboBox.Location = new System.Drawing.Point(3, 22);
            this.grau_instrucaoComboBox.Name = "grau_instrucaoComboBox";
            this.grau_instrucaoComboBox.Size = new System.Drawing.Size(121, 21);
            this.grau_instrucaoComboBox.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.dependenteDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(699, 176);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dependente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dependenteDataGridView
            // 
            this.dependenteDataGridView.AllowUserToAddRows = false;
            this.dependenteDataGridView.AutoGenerateColumns = false;
            this.dependenteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dependenteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dependenteDataGridView.DataSource = this.dependenteBindingSource;
            this.dependenteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dependenteDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dependenteDataGridView.Name = "dependenteDataGridView";
            this.dependenteDataGridView.ReadOnly = true;
            this.dependenteDataGridView.Size = new System.Drawing.Size(699, 176);
            this.dependenteDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data_nascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nascimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "parentesco";
            this.dataGridViewTextBoxColumn4.HeaderText = "Parentesco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dependenteBindingSource
            // 
            this.dependenteBindingSource.DataMember = "dependente";
            this.dependenteBindingSource.DataSource = this.funcionarioBindingSource;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.feriasDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(699, 176);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Férias";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // feriasDataGridView
            // 
            this.feriasDataGridView.AllowUserToAddRows = false;
            this.feriasDataGridView.AutoGenerateColumns = false;
            this.feriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feriasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.feriasDataGridView.DataSource = this.feriasBindingSource;
            this.feriasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feriasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.feriasDataGridView.Name = "feriasDataGridView";
            this.feriasDataGridView.ReadOnly = true;
            this.feriasDataGridView.Size = new System.Drawing.Size(699, 176);
            this.feriasDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "inicio_aquisicao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Inicio Aquisição";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fim_aquisicao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fim Aquisição";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "inicio_gozo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Inicio Gozo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fim_gozo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fim Gozo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "abono_pecuniario";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Abono";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // feriasBindingSource
            // 
            this.feriasBindingSource.DataMember = "ferias";
            this.feriasBindingSource.DataSource = this.funcionarioBindingSource;
            // 
            // tabPage6
            // 
            this.tabPage6.AutoScroll = true;
            this.tabPage6.Controls.Add(this.movimentacaoDataGridView);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(699, 176);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Movimentação";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // movimentacaoDataGridView
            // 
            this.movimentacaoDataGridView.AllowUserToAddRows = false;
            this.movimentacaoDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movimentacaoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.movimentacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movimentacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn14});
            this.movimentacaoDataGridView.DataSource = this.movimentacaoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.movimentacaoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.movimentacaoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movimentacaoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.movimentacaoDataGridView.Name = "movimentacaoDataGridView";
            this.movimentacaoDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movimentacaoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.movimentacaoDataGridView.Size = new System.Drawing.Size(699, 176);
            this.movimentacaoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn9.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "data_saida";
            this.dataGridViewTextBoxColumn10.HeaderText = "Saída";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "data_retorno";
            this.dataGridViewTextBoxColumn11.HeaderText = "Retorno";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "tipo_movimentacao";
            this.dataGridViewTextBoxColumn14.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // movimentacaoBindingSource
            // 
            this.movimentacaoBindingSource.DataMember = "movimentacao";
            this.movimentacaoBindingSource.DataSource = this.funcionarioBindingSource;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.funcionarioBindingSource, "ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(599, 203);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(112, 24);
            this.ativoCheckBox.TabIndex = 9;
            this.ativoCheckBox.Text = "Funcionário Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(139, 52);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(64, 20);
            this.matriculaTextBox.TabIndex = 23;
            // 
            // telefone_residencialMaskedTextBox
            // 
            this.telefone_residencialMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "telefone_residencial", true));
            this.telefone_residencialMaskedTextBox.Location = new System.Drawing.Point(139, 207);
            this.telefone_residencialMaskedTextBox.Mask = "(00) 0000-0000";
            this.telefone_residencialMaskedTextBox.Name = "telefone_residencialMaskedTextBox";
            this.telefone_residencialMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefone_residencialMaskedTextBox.TabIndex = 25;
            // 
            // telefone_recadoMaskedTextBox
            // 
            this.telefone_recadoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "telefone_recado", true));
            this.telefone_recadoMaskedTextBox.Location = new System.Drawing.Point(245, 207);
            this.telefone_recadoMaskedTextBox.Mask = "(00) 0000-0000";
            this.telefone_recadoMaskedTextBox.Name = "telefone_recadoMaskedTextBox";
            this.telefone_recadoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefone_recadoMaskedTextBox.TabIndex = 27;
            // 
            // telefone_celularMaskedTextBox
            // 
            this.telefone_celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "telefone_celular", true));
            this.telefone_celularMaskedTextBox.Location = new System.Drawing.Point(351, 207);
            this.telefone_celularMaskedTextBox.Mask = "(00) 0000-0000";
            this.telefone_celularMaskedTextBox.Name = "telefone_celularMaskedTextBox";
            this.telefone_celularMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefone_celularMaskedTextBox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 30;
            this.button1.Text = "Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(telefone_celularLabel);
            this.Controls.Add(this.telefone_celularMaskedTextBox);
            this.Controls.Add(telefone_recadoLabel);
            this.Controls.Add(this.telefone_recadoMaskedTextBox);
            this.Controls.Add(telefone_residencialLabel);
            this.Controls.Add(this.telefone_residencialMaskedTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(maeLabel);
            this.Controls.Add(this.maeTextBox);
            this.Controls.Add(paiLabel);
            this.Controls.Add(this.paiTextBox);
            this.Controls.Add(this.pesquisaMunicipio);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepMaskedTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.data_nascimentoMaskedTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.funcionarioBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).EndInit();
            this.funcionarioBindingNavigator.ResumeLayout(false);
            this.funcionarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dependenteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependenteBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feriasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriasBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.BindingNavigator funcionarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.MaskedTextBox data_nascimentoMaskedTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private PesquisaMunicipio pesquisaMunicipio;
        private System.Windows.Forms.TextBox paiTextBox;
        private System.Windows.Forms.TextBox maeTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox pisMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.TextBox rgTextBox;
        private System.Windows.Forms.MaskedTextBox data_emissao_rgMaskedTextBox;
        private System.Windows.Forms.TextBox orgao_emissor_rgTextBox;
        private System.Windows.Forms.TextBox cnhTextBox;
        private System.Windows.Forms.TextBox categoria_cnhTextBox;
        private System.Windows.Forms.MaskedTextBox data_expedicao_cnhMaskedTextBox;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.TextBox ctpsTextBox;
        private System.Windows.Forms.TextBox secaoTextBox;
        private System.Windows.Forms.TextBox zonaTextBox;
        private System.Windows.Forms.TextBox titulo_eleitorTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.MaskedTextBox telefone_residencialMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefone_recadoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefone_celularMaskedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox salario_inicialTextBox;
        private System.Windows.Forms.TextBox salario_atualTextBox;
        private System.Windows.Forms.MaskedTextBox data_admissaoMaskedTextBox;
        private Lookup lookup2;
        private Lookup lookup1;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TabPage tabPage3;
        private Lookup lookup3;
        private System.Windows.Forms.ComboBox corComboBox;
        private System.Windows.Forms.ComboBox grau_instrucaoComboBox;
        private Lookup lookup4;
        private System.Windows.Forms.ComboBox estado_civilComboBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dependenteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource dependenteBindingSource;
        private System.Windows.Forms.DataGridView feriasDataGridView;
        private System.Windows.Forms.BindingSource feriasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView movimentacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.BindingSource movimentacaoBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}