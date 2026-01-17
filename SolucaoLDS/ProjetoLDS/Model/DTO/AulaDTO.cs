using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLDS.Model.DTO
{
    internal class AulaDTO 
    {
        private String titulo;
        private String turma;
        private DateOnly data;
        private TimeOnly horario;
        private String descricao;
        private int idAula;
        private int idTurma;

        public AulaDTO()
        {
        }

        public AulaDTO(string titulo, string turma, DateOnly data, TimeOnly horario, string descricao, int idAula, int idTurma)
        {
            this.titulo = titulo;
            this.turma = turma;
            this.data = data;
            this.horario = horario;
            this.descricao = descricao;
            this.idAula = idAula;
            this.idTurma = idTurma;
        }

        public AulaDTO(string titulo, string turma, DateOnly data, TimeOnly horario, string descricao, int idTurma)
        {
            this.titulo = titulo;
            this.turma = turma;
            this.data = data;
            this.horario = horario;
            this.descricao = descricao;
            this.idTurma = idTurma;
        }

        public int IdAula { get => idAula; set => idAula = value; }
        public int IdTurma { get => idTurma; set => idTurma = value; }
        public String Titulo {  get => titulo; set => titulo = value; }
        public String Descricao { get => descricao; set => descricao = value; }
        public String Turma { get => turma; set => turma = value; }
        public DateOnly Data { get => data; set => data = value; }
        public TimeOnly Horario { get => horario; set => horario = value; }
    }
}
