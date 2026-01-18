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
    public partial class CadastrarAula : Form
    {
        public CadastrarAula()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            TxtTitulo.Text = "";
            CmbTurma.SelectedIndex = -1;
            DtpData.Value = DateTime.Now;
            DtpHorario.Value = DateTime.Now;
            TxtDescricao.Text = "";
        }

        private void TsSalvar_Click(object sender, EventArgs e)
        {
            DateOnly data;
            TimeOnly horario;
            String titulo = TxtTitulo.Text, turma = CmbTurma.Text, descricao = TxtDescricao.Text;


            horario = TimeOnly.Parse(DtpHorario.Text);
            data = DateOnly.Parse(DtpData.Text);

            AulaController aulaController = new AulaController();
            bool resultado = true;

            resultado = aulaController.AdicionarAula(titulo, turma, data, horario, descricao, Convert.ToInt32(CmbTurma.SelectedValue));

            if (resultado == true)
            {
                MessageBox.Show("Aula cadastrada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar a aula!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CadastrarAula_Load(object sender, EventArgs e)
        {
            try
            {
                TurmaController turmaController = new TurmaController();
                DataTable dt = turmaController.CarregarCMB();

                CmbTurma.DataSource = dt;
                CmbTurma.DisplayMember = "nome";
                CmbTurma.ValueMember = "idTurma";

                CmbTurma.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as turmas: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsListar_Click(object sender, EventArgs e)
        {
            String[] dados = new String[6];

            DgvAula.AutoGenerateColumns = false;
            DgvAula.Rows.Clear();

            AulaController aulaController = new AulaController();
            List<AulaDTO> listaAulas = aulaController.ListarAula();

            foreach (AulaDTO aula in listaAulas)
            {
                dados[0] = aula.IdAula.ToString();
                dados[1] = aula.Titulo;
                dados[2] = aula.Turma;
                dados[3] = aula.Data.ToString("dd/MM/yyyy");
                dados[4] = aula.Horario.ToString("HH:mm");
                dados[5] = aula.Descricao;
                DgvAula.Rows.Add(dados);
            }

        }

        private void TsExcluir_Click(object sender, EventArgs e)
        {
            if (DgvAula.SelectedRows.Count > 0)
            {
                int idAula = Convert.ToInt32(DgvAula.SelectedRows[0].Cells[0].Value);

                AulaController aulaController = new AulaController();
                bool resultado = aulaController.ExcluirAula(idAula);

                if (resultado == true)
                {
                    MessageBox.Show("Aula excluída com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TsListar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erro ao excluir a aula!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Selecione uma aula para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TsAtualizar_Click(object sender, EventArgs e)
        {
            String titulo = TxtTitulo.Text, turma = CmbTurma.Text, descricao = TxtDescricao.Text;
            DateOnly data = DateOnly.Parse(DtpData.Text);
            TimeOnly horario = TimeOnly.Parse(DtpHorario.Text);

            if (DgvAula.SelectedRows.Count > 0)
            {
                int idAula = Convert.ToInt32(DgvAula.SelectedRows[0].Cells[0].Value);
                AulaController aulaController = new AulaController();
                bool resultado = aulaController.AtualizarAula(idAula, titulo, turma, data, horario, descricao, Convert.ToInt32(CmbTurma.SelectedValue));
                if (resultado == true)
                {
                    MessageBox.Show("Aula atualizada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TsListar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar a aula!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma aula para atualizar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvAula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DgvAula.Rows[e.RowIndex];
                TxtTitulo.Text = row.Cells[1].Value.ToString();
                CmbTurma.Text = row.Cells[2].Value.ToString();
                DtpData.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                DtpHorario.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                TxtDescricao.Text = row.Cells[5].Value.ToString();
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            if (DgvAula.SelectedRows.Count > 0)
            {
                String descricao = DgvAula.SelectedRows[0].Cells[5].Value.ToString();
                MessageBox.Show(descricao, "Descrição da Aula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
            else
            {
                MessageBox.Show("Selecione uma aula para ver a descrição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
