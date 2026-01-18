using MySqlConnector;
using ProjetoLDS.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLDS.Model.DAO
{
    internal class TurmaDAO
    {
        private MySqlConnection con;
        private string comandoSql = "";
        private MySqlCommand envelope;
        private MySqlDataReader cursor;
        private List<TurmaDTO> listadeturma;

        public TurmaDAO()
        {
            String strconexao = "server=localhost;userid=root;password=monarca;database=gestaodeaulas";
            con = new MySqlConnection(strconexao);
        }

        public bool AdicionarTurma(TurmaDTO turmaDTO)
        {
            con.Open();
            comandoSql = "insert into turma(nome, instituto) values (@nome, @instituto)";
            envelope = new MySqlCommand();
            envelope.CommandText = comandoSql;
            envelope.Connection = con;

            envelope.Parameters.AddWithValue("@nome", turmaDTO.Nome);
            envelope.Parameters.AddWithValue("@instituto", turmaDTO.Instituto);
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

        public bool RemoverTurma(int idTurma)
        {
            con.Open();
            comandoSql = "delete from turma where idTurma = @idTurma";
            envelope = new MySqlCommand();
            envelope.CommandText = comandoSql;
            envelope.Connection = con;
            envelope.Parameters.AddWithValue("@idTurma", idTurma);
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

        public List<TurmaDTO> ListarTurmas()
        {
            listadeturma = new List<TurmaDTO>();
            con.Open();

            comandoSql = "select * from turma";
            envelope = new MySqlCommand(comandoSql, con);
            envelope.Prepare();
            cursor = envelope.ExecuteReader();

            while (cursor.Read())
            {
                TurmaDTO turmaDTO = new TurmaDTO();
                turmaDTO.IdTurma = cursor.GetInt32("idTurma");
                turmaDTO.Nome = cursor.GetString("nome");
                turmaDTO.Instituto = cursor.GetString("instituto");
                listadeturma.Add(turmaDTO);
            }

            con.Close();

            return listadeturma;
        }

        public bool AtualizarTurma(TurmaDTO turmaDTO)
        {
            con.Open();
            comandoSql = "update turma set nome = @nome, instituto = @instituto where idTurma = @idTurma";
            envelope = new MySqlCommand();

            envelope.CommandText = comandoSql;

            envelope.Connection = con;

            envelope.Parameters.AddWithValue("@nome", turmaDTO.Nome);
            envelope.Parameters.AddWithValue("@instituto", turmaDTO.Instituto);
            envelope.Parameters.AddWithValue("@idTurma", turmaDTO.IdTurma);
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

        public DataTable CarregarCMB()
        {
            try
            {
                con.Open();
                comandoSql = "select idTurma, nome from turma";
                envelope = new MySqlCommand(comandoSql, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(envelope);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar as turmas: " + ex.Message);
            }

        }

    }
}
