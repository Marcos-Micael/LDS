using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLDS.Model.DTO
{
    internal class TurmaDTO
    {
        private int idTurma;
        private string nome;
        private string instituto;
        
        public TurmaDTO() 
        { 
        }

        public TurmaDTO(int idTurma, string nome, string instituto)
        {
            this.idTurma = idTurma;
            this.nome = nome;
            instituto = instituto;
        }

        public TurmaDTO(string nome, string instituto)
        {
            this.nome = nome;
            instituto = instituto;
        }

        public int IdTurma { get => idTurma; set => idTurma = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Instituto {  get => instituto; set => instituto = value; }
    }
}
