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
            LblNome.Location = new Point(58, 49);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(45, 16);
            LblNome.TabIndex = 0;
            LblNome.Text = "Nome:";
            // 
            // LblInstituto
            // 
            LblInstituto.AutoSize = true;
            LblInstituto.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblInstituto.Location = new Point(58, 84);
            LblInstituto.Name = "LblInstituto";
            LblInstituto.Size = new Size(57, 16);
            LblInstituto.TabIndex = 1;
            LblInstituto.Text = "Instituto:";
            // 
            // TxtNome
            // 
            TxtNome.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNome.Location = new Point(121, 46);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(240, 22);
            TxtNome.TabIndex = 2;
            // 
            // TxtInstituto
            // 
            TxtInstituto.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtInstituto.Location = new Point(121, 81);
            TxtInstituto.Name = "TxtInstituto";
            TxtInstituto.Size = new Size(240, 22);
            TxtInstituto.TabIndex = 3;
            // 
            // DgvTurma
            // 
            DgvTurma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTurma.Columns.AddRange(new DataGridViewColumn[] { Nome, Instituto });
            DgvTurma.Location = new Point(-1, 171);
            DgvTurma.Name = "DgvTurma";
            DgvTurma.Size = new Size(435, 209);
            DgvTurma.TabIndex = 4;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            // 
            // Instituto
            // 
            Instituto.HeaderText = "Instituto";
            Instituto.Name = "Instituto";
            Instituto.ReadOnly = true;
            Instituto.Width = 175;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsSalvar, TsExcluir, TsAtualizar, TsListar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(432, 25);
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
            TsSalvar.Size = new Size(23, 22);
            TsSalvar.Text = "toolStripButton1";
            // 
            // TsExcluir
            // 
            TsExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsExcluir.Image = (Image)resources.GetObject("TsExcluir.Image");
            TsExcluir.ImageTransparentColor = Color.Magenta;
            TsExcluir.Name = "TsExcluir";
            TsExcluir.Size = new Size(23, 22);
            TsExcluir.Text = "toolStripButton1";
            // 
            // TsAtualizar
            // 
            TsAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsAtualizar.Image = (Image)resources.GetObject("TsAtualizar.Image");
            TsAtualizar.ImageTransparentColor = Color.Magenta;
            TsAtualizar.Name = "TsAtualizar";
            TsAtualizar.Size = new Size(23, 22);
            TsAtualizar.Text = "toolStripButton1";
            // 
            // TsListar
            // 
            TsListar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsListar.Image = (Image)resources.GetObject("TsListar.Image");
            TsListar.ImageTransparentColor = Color.Magenta;
            TsListar.Name = "TsListar";
            TsListar.Size = new Size(23, 22);
            TsListar.Text = "toolStripButton1";
            // 
            // FrmCadastarTurma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(toolStrip1);
            Controls.Add(DgvTurma);
            Controls.Add(TxtInstituto);
            Controls.Add(TxtNome);
            Controls.Add(LblInstituto);
            Controls.Add(LblNome);
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
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Instituto;
        private ToolStrip toolStrip1;
        private ToolStripButton TsSalvar;
        private ToolStripButton TsExcluir;
        private ToolStripButton TsAtualizar;
        private ToolStripButton TsListar;
    }
}