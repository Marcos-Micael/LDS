using ProjetoLDS.Model.DAO;
using ProjetoLDS.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLDS.Controller
{
    internal class TurmaController
    {
        public bool AdicionarTurma(String nome, String instituto)
        {
            bool retornadao = false;
            TurmaDTO turmaDTO = new TurmaDTO(nome, instituto);
            TurmaDAO turmaDAO = new TurmaDAO();
            retornadao = turmaDAO.Adicionar(turmaDTO);
            return retornadao;
        }
    }
}
