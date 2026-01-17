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
            dataGridView1 = new DataGridView();
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
            TxtHorario = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            CmbTurma = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColunaTitulo, ColunaTurma, ColunaData, ColunaHorario, ColunaDescricao });
            dataGridView1.Location = new Point(483, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(520, 480);
            dataGridView1.TabIndex = 0;
            // 
            // ColunaTitulo
            // 
            ColunaTitulo.HeaderText = "Titulo";
            ColunaTitulo.Name = "ColunaTitulo";
            ColunaTitulo.ReadOnly = true;
            // 
            // ColunaTurma
            // 
            ColunaTurma.HeaderText = "Turma";
            ColunaTurma.Name = "ColunaTurma";
            ColunaTurma.ReadOnly = true;
            // 
            // ColunaData
            // 
            ColunaData.HeaderText = "Data";
            ColunaData.Name = "ColunaData";
            ColunaData.ReadOnly = true;
            // 
            // ColunaHorario
            // 
            ColunaHorario.HeaderText = "Horário";
            ColunaHorario.Name = "ColunaHorario";
            ColunaHorario.ReadOnly = true;
            // 
            // ColunaDescricao
            // 
            ColunaDescricao.HeaderText = "Descrição";
            ColunaDescricao.Name = "ColunaDescricao";
            ColunaDescricao.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 89);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 1;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 128);
            label2.Name = "label2";
            label2.Size = new Size(68, 22);
            label2.TabIndex = 2;
            label2.Text = "Turma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 171);
            label3.Name = "label3";
            label3.Size = new Size(54, 22);
            label3.TabIndex = 3;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 256);
            label4.Name = "label4";
            label4.Size = new Size(101, 22);
            label4.TabIndex = 4;
            label4.Text = "Descrição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 211);
            label5.Name = "label5";
            label5.Size = new Size(76, 22);
            label5.TabIndex = 5;
            label5.Text = "Horário:";
            // 
            // TxtTitulo
            // 
            TxtTitulo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTitulo.Location = new Point(150, 86);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(255, 29);
            TxtTitulo.TabIndex = 6;
            // 
            // TxtHorario
            // 
            TxtHorario.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtHorario.Location = new Point(150, 211);
            TxtHorario.Name = "TxtHorario";
            TxtHorario.Size = new Size(255, 29);
            TxtHorario.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(150, 253);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 125);
            textBox1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(150, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 22);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.Value = new DateTime(2026, 1, 17, 0, 0, 0, 0);
            // 
            // CmbTurma
            // 
            CmbTurma.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbTurma.FormattingEnabled = true;
            CmbTurma.Location = new Point(150, 130);
            CmbTurma.Name = "CmbTurma";
            CmbTurma.Size = new Size(255, 30);
            CmbTurma.TabIndex = 11;
            // 
            // CadastrarAula
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 480);
            Controls.Add(CmbTurma);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(TxtHorario);
            Controls.Add(TxtTitulo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CadastrarAula";
            Text = "Cadastrar Aula";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColunaTitulo;
        private DataGridViewTextBoxColumn ColunaTurma;
        private DataGridViewTextBoxColumn ColunaData;
        private DataGridViewTextBoxColumn ColunaHorario;
        private DataGridViewTextBoxColumn ColunaDescricao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtTitulo;
        private TextBox TxtHorario;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox CmbTurma;
    }
}