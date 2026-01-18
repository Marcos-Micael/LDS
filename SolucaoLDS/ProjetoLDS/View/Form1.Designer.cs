namespace ProjetoLDS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            TSMCadastrar = new ToolStripMenuItem();
            TSICadAula = new ToolStripMenuItem();
            TSICadTurma = new ToolStripMenuItem();
            historicoToolStripMenuItem = new ToolStripMenuItem();
            aulaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMCadastrar, historicoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMCadastrar
            // 
            TSMCadastrar.DropDownItems.AddRange(new ToolStripItem[] { TSICadAula, TSICadTurma });
            TSMCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TSMCadastrar.Name = "TSMCadastrar";
            TSMCadastrar.Size = new Size(112, 27);
            TSMCadastrar.Text = "Cadastrar";
            // 
            // TSICadAula
            // 
            TSICadAula.Name = "TSICadAula";
            TSICadAula.Size = new Size(224, 28);
            TSICadAula.Text = "Aula";
            TSICadAula.Click += TSICadAula_Click;
            // 
            // TSICadTurma
            // 
            TSICadTurma.Name = "TSICadTurma";
            TSICadTurma.Size = new Size(224, 28);
            TSICadTurma.Text = "Turma";
            TSICadTurma.Click += TSICadTurma_Click;
            // 
            // historicoToolStripMenuItem
            // 
            historicoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aulaToolStripMenuItem });
            historicoToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            historicoToolStripMenuItem.Size = new Size(100, 27);
            historicoToolStripMenuItem.Text = "Historico";
            // 
            // aulaToolStripMenuItem
            // 
            aulaToolStripMenuItem.Name = "aulaToolStripMenuItem";
            aulaToolStripMenuItem.Size = new Size(224, 28);
            aulaToolStripMenuItem.Text = "Aula";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Gerenciamento de Aulas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMCadastrar;
        private ToolStripMenuItem TSICadAula;
        private ToolStripMenuItem TSICadTurma;
        private ToolStripMenuItem historicoToolStripMenuItem;
        private ToolStripMenuItem aulaToolStripMenuItem;
    }
}
