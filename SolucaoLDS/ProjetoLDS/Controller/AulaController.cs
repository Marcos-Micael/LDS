using ProjetoLDS.Model.DAO;
using ProjetoLDS.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLDS.Controller
{
    internal class AulaController
    {
        public bool AdicionarAula(String titulo, String turma, DateOnly data, TimeOnly horario, String descricao, int idTurma)
        {
            bool retornadao = false;
            AulaDTO aulaDTO = new AulaDTO(titulo, turma, data, horario, descricao, idTurma);
            AulaDAO aulaDAO = new AulaDAO();
            retornadao = aulaDAO.AdicionarAula(aulaDTO);
            return retornadao;

        }

        public List<AulaDTO> ListarAula()
        {
            List<AulaDTO> listadeaula = new List<AulaDTO>();
            AulaDAO aulaDAO = new AulaDAO();
            listadeaula = aulaDAO.ListarAula();
            return listadeaula;
        }

        public bool ExcluirAula(int idAula)
        {
            bool retornadao = false;
            AulaDTO aulaDTO = new AulaDTO();
            aulaDTO.IdAula = idAula;
            AulaDAO aulaDAO = new AulaDAO();
            retornadao = aulaDAO.ExcluirAula(idAula);
            return retornadao;
        }

        public bool AtualizarAula(int idAula, String titulo, String turma, DateOnly data, TimeOnly horario, String descricao, int idTurma)
        {
            bool retornadao = false;
            AulaDTO aulaDTO = new AulaDTO(titulo, turma, data, horario, descricao, idAula, idTurma);
            AulaDAO aulaDAO = new AulaDAO();
            retornadao = aulaDAO.SalvarAula(aulaDTO);
            return retornadao;
        }

        public String MaisDesc(int idAula)
        {
            AulaDAO aulaDAO = new AulaDAO();
            return aulaDAO.MaisDesc(idAula);
        }
    }
}
