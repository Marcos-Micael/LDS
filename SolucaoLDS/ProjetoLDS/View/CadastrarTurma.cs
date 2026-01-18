using ProjetoLDS.Controller;
using ProjetoLDS.Model.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLDS.View
{
    public partial class FrmCadastarTurma : Form
    {
        public FrmCadastarTurma()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            TxtNome.Text = "";
            TxtInstituto.Text = "";
        }

        private void TsSalvar_Click(object sender, EventArgs e)
        {
            String nome = "", instituto = "";

            nome = TxtNome.Text;
            if (nome == "")
            {
                MessageBox.Show("O campo NOME é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return;
            }

            instituto = TxtInstituto.Text;
            if (instituto == "")
            {
                MessageBox.Show("O campo INSTITUTO é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtInstituto.Focus();
                return;
            }

            TurmaController turmaController = new TurmaController();

            bool resultado = true;

            resultado = turmaController.AdicionarTurma(nome, instituto);

            if (resultado == true)
            {
                MessageBox.Show("Turma cadastrada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                TsListar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar a turma!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void TsExcluir_Click(object sender, EventArgs e)
        {
            if (DgvTurma.SelectedRows.Count > 0)
            {
                int idTurma = Convert.ToInt32(DgvTurma.SelectedRows[0].Cells[0].Value);

                TurmaController turmaController = new TurmaController();
                bool resultado = turmaController.RemoverTurma(idTurma);

                if (resultado == true)
                {
                    MessageBox.Show("Turma removida com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TsListar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erro ao remover a turma!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma turma para remover!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void TsListar_Click(object sender, EventArgs e)
        {
            String[] dados = new String[3];

            DgvTurma.AutoGenerateColumns = false;

            DgvTurma.Rows.Clear();

            TurmaController turmaController = new TurmaController();
            List<TurmaDTO> listaTurmas = turmaController.ListarTurmas();

            foreach (TurmaDTO turma in listaTurmas)
            {
                dados[0] = Convert.ToString(turma.IdTurma);
                dados[1] = turma.Nome;
                dados[2] = turma.Instituto;
                DgvTurma.Rows.Add(dados);

            }
        }

        private void DgvTurma_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtNome.Text = DgvTurma.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtInstituto.Text = DgvTurma.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void TsAtualizar_Click(object sender, EventArgs e)
        {
            String nome = TxtNome.Text, instituto = TxtInstituto.Text;
            bool resultado = true;

            if(TxtNome.Text == "")
            {
                MessageBox.Show("O campo NOME é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return;
            }
            
            if(TxtInstituto.Text == "")
            {
                MessageBox.Show("O campo INSTITUTO é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtInstituto.Focus();
                return;
            }

            if(DgvTurma.SelectedRows.Count > 0)
            {
                int idTurma = Convert.ToInt32(DgvTurma.SelectedRows[0].Cells[0].Value);
                TurmaController turmaController = new TurmaController();
                resultado = turmaController.AtualizarTurma(idTurma, nome, instituto);
                if (resultado == true)
                {
                    MessageBox.Show("Turma atualizada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TsListar_Click(sender, e);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar a turma!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limparCampos();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma turma para atualizar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
