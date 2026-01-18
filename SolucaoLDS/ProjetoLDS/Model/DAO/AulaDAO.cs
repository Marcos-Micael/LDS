using MySqlConnector;
using ProjetoLDS.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLDS.Model.DAO
{
    internal class AulaDAO
    {
        private MySqlConnection con;
        private String comandoSql = "";
        private MySqlCommand envelope;
        private MySqlDataReader cursor;
        private List<AulaDTO> listadeaula;

        public AulaDAO()
        {
            String strconexao = "server=localhost;userid=root;password=monarca;database=gestaodeaulas";
            con = new MySqlConnection(strconexao);
        }

        public bool AdicionarAula(AulaDTO aulaDTO)
        {
            con.Open();
            comandoSql = "insert into aula(titulo, turma, data, horario, descricao, idTurma) values (@titulo, @turma, @data, @horario, @descricao, @idTurma)";
            envelope = new MySqlCommand();
            envelope.CommandText = comandoSql;
            envelope.Connection = con;
            envelope.Parameters.AddWithValue("@titulo", aulaDTO.Titulo);
            envelope.Parameters.AddWithValue("@turma", aulaDTO.Turma);
            envelope.Parameters.AddWithValue("@data", aulaDTO.Data.ToString("yyyy-MM-dd"));
            envelope.Parameters.AddWithValue("@horario", aulaDTO.Horario.ToString("HH:mm:ss"));
            envelope.Parameters.AddWithValue("@descricao", aulaDTO.Descricao);
            envelope.Parameters.AddWithValue("@idTurma", aulaDTO.IdTurma);
            envelope.Prepare();
            int resultado = envelope.ExecuteNonQuery();
            con.Close();
            if (resultado > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<AulaDTO> ListarAula()
        {
            listadeaula = new List<AulaDTO>();
            con.Open();

            comandoSql = "select a.idAula, a.titulo as titulo, t.nome as turma, a.data as data, a.horario as horario, " +
                "a.descricao as descricao from aula a join turma t on a.idturma = t.idturma " +
                "where CONCAT(a.data, ' ', a.horario) > NOW() order by a. data desc, a.horario desc";
            envelope = new MySqlCommand(comandoSql, con);
            envelope.Prepare();
            cursor = envelope.ExecuteReader();

            while (cursor.Read()) 
            {
                AulaDTO aulaDTO = new AulaDTO();
                aulaDTO.IdAula = cursor.GetInt32("idAula");
                aulaDTO.Titulo = cursor.GetString("titulo");
                aulaDTO.Turma = cursor.GetString("turma");
                aulaDTO.Data = cursor.GetDateOnly("data");
                aulaDTO.Horario = cursor.GetTimeOnly("horario");
                aulaDTO.Descricao = cursor.GetString("descricao");
                listadeaula.Add(aulaDTO);
            }

            con.Close();

            return listadeaula;
        }

        public bool ExcluirAula(int idAula)
        {
            con.Open();
            comandoSql = "delete from aula where idAula = @idAula";
            envelope = new MySqlCommand();
            envelope.CommandText = comandoSql;
            envelope.Connection = con;
            
            envelope.Parameters.AddWithValue("@idAula", idAula);
            envelope.Prepare();
            
            int resultado = envelope.ExecuteNonQuery();
            
            con.Close();
            
            if (resultado > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SalvarAula(AulaDTO aulaDTO)
        {
            con.Open();
            comandoSql = "update aula set titulo = @titulo, turma = @turma, data = @data, horario = @horario, descricao = @descricao, idTurma = @idTurma where idAula = @idAula";
            envelope = new MySqlCommand();
            envelope.CommandText = comandoSql;
            envelope.Connection = con;
            
            envelope.Parameters.AddWithValue("@titulo", aulaDTO.Titulo);
            envelope.Parameters.AddWithValue("@turma", aulaDTO.Turma);
            envelope.Parameters.AddWithValue("@data", aulaDTO.Data.ToString("yyyy-MM-dd"));
            envelope.Parameters.AddWithValue("@horario", aulaDTO.Horario.ToString("HH:mm:ss"));
            envelope.Parameters.AddWithValue("@descricao", aulaDTO.Descricao);
            envelope.Parameters.AddWithValue("@idTurma", aulaDTO.IdTurma);
            envelope.Parameters.AddWithValue("@idAula", aulaDTO.IdAula);
            envelope.Prepare();
            
            int resultado = envelope.ExecuteNonQuery();
            con.Close();
            if (resultado > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String MaisDesc(int idAula)
        {
            String desc = "";
            con.Open();
            comandoSql = "Select descricao from aula where idAula = @idAula";
            envelope = new MySqlCommand();
            envelope.CommandText = comandoSql;
            envelope.Connection = con;

            envelope.Parameters.AddWithValue("@idAula", idAula);

            cursor = envelope.ExecuteReader();

            if (cursor.Read())
            {
                desc = cursor.GetString("descricao");
            }

            con.Close();
            return desc;
        }

    }
}
