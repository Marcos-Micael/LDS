namespace ProjetoLDS.View
{
    partial class CadastrarAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAula));
            DgvAula = new DataGridView();
            ColunaIdAula = new DataGridViewTextBoxColumn();
            ColunaTitulo = new DataGridViewTextBoxColumn();
            ColunaTurma = new DataGridViewTextBoxColumn();
            ColunaData = new DataGridViewTextBoxColumn();
            ColunaHorario = new DataGridViewTextBoxColumn();
            ColunaDescricao = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtTitulo = new TextBox();
            TxtDescricao = new TextBox();
            DtpData = new DateTimePicker();
            CmbTurma = new ComboBox();
            BtnInfo = new Button();
            toolStrip1 = new ToolStrip();
            TsSalvar = new ToolStripButton();
            TsExcluir = new ToolStripButton();
            TsAtualizar = new ToolStripButton();
            TsListar = new ToolStripButton();
            DtpHorario = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DgvAula).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvAula
            // 
            DgvAula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAula.Columns.AddRange(new DataGridViewColumn[] { ColunaIdAula, ColunaTitulo, ColunaTurma, ColunaData, ColunaHorario, ColunaDescricao });
            DgvAula.Location = new Point(460, 50);
            DgvAula.Name = "DgvAula";
            DgvAula.RowHeadersWidth = 51;
            DgvAula.Size = new Size(677, 377);
            DgvAula.TabIndex = 0;
            DgvAula.CellDoubleClick += DgvAula_CellDoubleClick;
            // 
            // ColunaIdAula
            // 
            ColunaIdAula.HeaderText = "Id";
            ColunaIdAula.MinimumWidth = 6;
            ColunaIdAula.Name = "ColunaIdAula";
            ColunaIdAula.ReadOnly = true;
            ColunaIdAula.Width = 125;
            // 
            // ColunaTitulo
            // 
            ColunaTitulo.HeaderText = "Titulo";
            ColunaTitulo.MinimumWidth = 6;
            ColunaTitulo.Name = "ColunaTitulo";
            ColunaTitulo.ReadOnly = true;
            ColunaTitulo.Width = 125;
            // 
            // ColunaTurma
            // 
            ColunaTurma.HeaderText = "Turma";
            ColunaTurma.MinimumWidth = 6;
            ColunaTurma.Name = "ColunaTurma";
            ColunaTurma.ReadOnly = true;
            ColunaTurma.Width = 125;
            // 
            // ColunaData
            // 
            ColunaData.HeaderText = "Data";
            ColunaData.MinimumWidth = 6;
            ColunaData.Name = "ColunaData";
            ColunaData.ReadOnly = true;
            ColunaData.Width = 125;
            // 
            // ColunaHorario
            // 
            ColunaHorario.HeaderText = "Horário";
            ColunaHorario.MinimumWidth = 6;
            ColunaHorario.Name = "ColunaHorario";
            ColunaHorario.ReadOnly = true;
            ColunaHorario.Width = 125;
            // 
            // ColunaDescricao
            // 
            ColunaDescricao.HeaderText = "Descrição";
            ColunaDescricao.MinimumWidth = 6;
            ColunaDescricao.Name = "ColunaDescricao";
            ColunaDescricao.ReadOnly = true;
            ColunaDescricao.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 89);
            label1.Name = "label1";
            label1.Size = new Size(77, 27);
            label1.TabIndex = 1;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 128);
            label2.Name = "label2";
            label2.Size = new Size(87, 27);
            label2.TabIndex = 2;
            label2.Text = "Turma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 171);
            label3.Name = "label3";
            label3.Size = new Size(69, 27);
            label3.TabIndex = 3;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 256);
            label4.Name = "label4";
            label4.Size = new Size(124, 27);
            label4.TabIndex = 4;
            label4.Text = "Descrição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 211);
            label5.Name = "label5";
            label5.Size = new Size(96, 27);
            label5.TabIndex = 5;
            label5.Text = "Horário:";
            // 
            // TxtTitulo
            // 
            TxtTitulo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTitulo.Location = new Point(150, 86);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(255, 35);
            TxtTitulo.TabIndex = 6;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDescricao.Location = new Point(177, 252);
            TxtDescricao.Multiline = true;
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(255, 125);
            TxtDescricao.TabIndex = 9;
            // 
            // DtpData
            // 
            DtpData.CalendarFont = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpData.CustomFormat = "";
            DtpData.Format = DateTimePickerFormat.Short;
            DtpData.Location = new Point(150, 171);
            DtpData.Name = "DtpData";
            DtpData.Size = new Size(255, 26);
            DtpData.TabIndex = 10;
            DtpData.Value = new DateTime(2026, 1, 17, 0, 0, 0, 0);
            // 
            // CmbTurma
            // 
            CmbTurma.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbTurma.FormattingEnabled = true;
            CmbTurma.Location = new Point(150, 130);
            CmbTurma.Name = "CmbTurma";
            CmbTurma.Size = new Size(255, 35);
            CmbTurma.TabIndex = 11;
            // 
            // BtnInfo
            // 
            BtnInfo.Location = new Point(670, 441);
            BtnInfo.Name = "BtnInfo";
            BtnInfo.Size = new Size(277, 84);
            BtnInfo.TabIndex = 13;
            BtnInfo.Text = "Mais Informação";
            BtnInfo.UseVisualStyleBackColor = true;
            BtnInfo.Click += BtnInfo_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsSalvar, TsExcluir, TsAtualizar, TsListar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1136, 27);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsSalvar
            // 
            TsSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsSalvar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TsSalvar.Image = (Image)resources.GetObject("TsSalvar.Image");
            TsSalvar.ImageAlign = ContentAlignment.BottomCenter;
            TsSalvar.ImageTransparentColor = Color.Magenta;
            TsSalvar.Name = "TsSalvar";
            TsSalvar.Size = new Size(29, 24);
            TsSalvar.Text = "Adicionar";
            TsSalvar.Click += TsSalvar_Click;
            // 
            // TsExcluir
            // 
            TsExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsExcluir.Image = (Image)resources.GetObject("TsExcluir.Image");
            TsExcluir.ImageTransparentColor = Color.Magenta;
            TsExcluir.Name = "TsExcluir";
            TsExcluir.Size = new Size(29, 24);
            TsExcluir.Text = "Deletar";
            TsExcluir.Click += TsExcluir_Click;
            // 
            // TsAtualizar
            // 
            TsAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsAtualizar.Image = (Image)resources.GetObject("TsAtualizar.Image");
            TsAtualizar.ImageTransparentColor = Color.Magenta;
            TsAtualizar.Name = "TsAtualizar";
            TsAtualizar.Size = new Size(29, 24);
            TsAtualizar.Text = "Atualizar";
            TsAtualizar.Click += TsAtualizar_Click;
            // 
            // TsListar
            // 
            TsListar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsListar.Image = (Image)resources.GetObject("TsListar.Image");
            TsListar.ImageTransparentColor = Color.Magenta;
            TsListar.Name = "TsListar";
            TsListar.Size = new Size(29, 24);
            TsListar.Text = "Listar";
            TsListar.Click += TsListar_Click;
            // 
            // DtpHorario
            // 
            DtpHorario.CalendarFont = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpHorario.CustomFormat = "";
            DtpHorario.Format = DateTimePickerFormat.Time;
            DtpHorario.Location = new Point(150, 212);
            DtpHorario.Name = "DtpHorario";
            DtpHorario.Size = new Size(255, 26);
            DtpHorario.TabIndex = 15;
            DtpHorario.Value = new DateTime(2026, 1, 18, 11, 39, 42, 0);
            // 
            // CadastrarAula
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 537);
            Controls.Add(DtpHorario);
            Controls.Add(toolStrip1);
            Controls.Add(BtnInfo);
            Controls.Add(CmbTurma);
            Controls.Add(DtpData);
            Controls.Add(TxtDescricao);
            Controls.Add(TxtTitulo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DgvAula);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CadastrarAula";
            Text = "Cadastrar Aula";
            Load += CadastrarAula_Load;
            ((System.ComponentModel.ISupportInitialize)DgvAula).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvAula;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtTitulo;
        private TextBox TxtDescricao;
        private DateTimePicker DtpData;
        private ComboBox CmbTurma;
        private Button BtnInfo;
        private ToolStrip toolStrip1;
        private ToolStripButton TsSalvar;
        private ToolStripButton TsExcluir;
        private ToolStripButton TsAtualizar;
        private ToolStripButton TsListar;
        private DateTimePicker DtpHorario;
        private DataGridViewTextBoxColumn ColunaIdAula;
        private DataGridViewTextBoxColumn ColunaTitulo;
        private DataGridViewTextBoxColumn ColunaTurma;
        private DataGridViewTextBoxColumn ColunaData;
        private DataGridViewTextBoxColumn ColunaHorario;
        private DataGridViewTextBoxColumn ColunaDescricao;
    }
}