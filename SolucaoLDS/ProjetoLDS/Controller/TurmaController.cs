using ProjetoLDS.Model.DAO;
using ProjetoLDS.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            retornadao = turmaDAO.AdicionarTurma(turmaDTO);
            return retornadao;
        }

        public bool RemoverTurma(int idTurma)
        {
            bool retornadao = false;
            TurmaDAO turmaDAO = new TurmaDAO();
            retornadao = turmaDAO.RemoverTurma(idTurma);
            return retornadao;
        }

        public List<TurmaDTO> ListarTurmas()
        {
            List<TurmaDTO> listaRetornada = new List<TurmaDTO>();
            TurmaDAO turmaDAO = new TurmaDAO();
            listaRetornada = turmaDAO.ListarTurmas();
            return listaRetornada;
        }

        public bool AtualizarTurma(int idTurma, string nome, string instituto)
        {
            bool retornadao = false;
            TurmaDTO turmaDTO = new TurmaDTO(idTurma, nome, instituto);
            TurmaDAO turmaDAO = new TurmaDAO();
            retornadao = turmaDAO.AtualizarTurma(turmaDTO);
            return retornadao;
        }

        public DataTable CarregarCMB()
        {
            TurmaDAO turmaDAO = new TurmaDAO();
            return turmaDAO.CarregarCMB();
        }
    }
}
