namespace ProjetoLDS.View
{
    partial class FrmCadastarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastarTurma));
            LblNome = new Label();
            LblInstituto = new Label();
            TxtNome = new TextBox();
            TxtInstituto = new TextBox();
            DgvTurma = new DataGridView();
            ColunaIdTurma = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Instituto = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            TsSalvar = new ToolStripButton();
            TsExcluir = new ToolStripButton();
            TsAtualizar = new ToolStripButton();
            TsListar = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)DgvTurma).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNome.Location = new Point(66, 65);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(56, 19);
            LblNome.TabIndex = 0;
            LblNome.Text = "Nome:";
            // 
            // LblInstituto
            // 
            LblInstituto.AutoSize = true;
            LblInstituto.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblInstituto.Location = new Point(66, 112);
            LblInstituto.Name = "LblInstituto";
            LblInstituto.Size = new Size(70, 19);
            LblInstituto.TabIndex = 1;
            LblInstituto.Text = "Instituto:";
            // 
            // TxtNome
            // 
            TxtNome.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNome.Location = new Point(138, 61);
            TxtNome.Margin = new Padding(3, 4, 3, 4);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(274, 26);
            TxtNome.TabIndex = 2;
            // 
            // TxtInstituto
            // 
            TxtInstituto.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtInstituto.Location = new Point(138, 108);
            TxtInstituto.Margin = new Padding(3, 4, 3, 4);
            TxtInstituto.Name = "TxtInstituto";
            TxtInstituto.Size = new Size(274, 26);
            TxtInstituto.TabIndex = 3;
            // 
            // DgvTurma
            // 
            DgvTurma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTurma.Columns.AddRange(new DataGridViewColumn[] { ColunaIdTurma, Nome, Instituto });
            DgvTurma.Location = new Point(-1, 228);
            DgvTurma.Margin = new Padding(3, 4, 3, 4);
            DgvTurma.Name = "DgvTurma";
            DgvTurma.RowHeadersWidth = 51;
            DgvTurma.Size = new Size(497, 279);
            DgvTurma.TabIndex = 4;
            DgvTurma.CellDoubleClick += DgvTurma_CellDoubleClick;
            // 
            // ColunaIdTurma
            // 
            ColunaIdTurma.HeaderText = "ID";
            ColunaIdTurma.MinimumWidth = 6;
            ColunaIdTurma.Name = "ColunaIdTurma";
            ColunaIdTurma.ReadOnly = true;
            ColunaIdTurma.Width = 125;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            // 
            // Instituto
            // 
            Instituto.HeaderText = "Instituto";
            Instituto.MinimumWidth = 6;
            Instituto.Name = "Instituto";
            Instituto.ReadOnly = true;
            Instituto.Width = 175;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsSalvar, TsExcluir, TsAtualizar, TsListar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(494, 27);
            toolStrip1.TabIndex = 5;
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
            TsSalvar.Text = "toolStripButton1";
            TsSalvar.Click += TsSalvar_Click;
            // 
            // TsExcluir
            // 
            TsExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsExcluir.Image = (Image)resources.GetObject("TsExcluir.Image");
            TsExcluir.ImageTransparentColor = Color.Magenta;
            TsExcluir.Name = "TsExcluir";
            TsExcluir.Size = new Size(29, 24);
            TsExcluir.Text = "toolStripButton1";
            TsExcluir.Click += TsExcluir_Click;
            // 
            // TsAtualizar
            // 
            TsAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsAtualizar.Image = (Image)resources.GetObject("TsAtualizar.Image");
            TsAtualizar.ImageTransparentColor = Color.Magenta;
            TsAtualizar.Name = "TsAtualizar";
            TsAtualizar.Size = new Size(29, 24);
            TsAtualizar.Text = "toolStripButton1";
            TsAtualizar.Click += TsAtualizar_Click;
            // 
            // TsListar
            // 
            TsListar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsListar.Image = (Image)resources.GetObject("TsListar.Image");
            TsListar.ImageTransparentColor = Color.Magenta;
            TsListar.Name = "TsListar";
            TsListar.Size = new Size(29, 24);
            TsListar.Text = "toolStripButton1";
            TsListar.Click += TsListar_Click;
            // 
            // FrmCadastarTurma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 477);
            Controls.Add(toolStrip1);
            Controls.Add(DgvTurma);
            Controls.Add(TxtInstituto);
            Controls.Add(TxtNome);
            Controls.Add(LblInstituto);
            Controls.Add(LblNome);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCadastarTurma";
            Text = "Cadastrar Turma";
            ((System.ComponentModel.ISupportInitialize)DgvTurma).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNome;
        private Label LblInstituto;
        private TextBox TxtNome;
        private TextBox TxtInstituto;
        private DataGridView DgvTurma;
        private ToolStrip toolStrip1;
        private ToolStripButton TsSalvar;
        private ToolStripButton TsExcluir;
        private ToolStripButton TsAtualizar;
        private ToolStripButton TsListar;
        private DataGridViewTextBoxColumn ColunaIdTurma;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Instituto;
    }
}