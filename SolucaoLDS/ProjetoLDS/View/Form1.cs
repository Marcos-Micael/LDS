using ProjetoLDS.View;

namespace ProjetoLDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TSICadTurma_Click(object sender, EventArgs e)
        {
            FrmCadastarTurma cadastarTurma = new FrmCadastarTurma();
            cadastarTurma.Show();
        }

        private void TSICadAula_Click(object sender, EventArgs e)
        {
            CadastrarAula cadastrarAula = new CadastrarAula();
            cadastrarAula.Show();
        }
    }
}
