using MySqlConnector;
using ProjetoLDS.Model.DTO;
using System;
using System.Collections.Generic;
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
            String strconexao = "server=localhost;userid=root;password=;database=gestaodeaulas";
            con = new MySqlConnection(strconexao);
        }

        public bool Adicionar(TurmaDTO turmaDTO)
        {
            con.Open();
            comandoSql = "insert into gestaodeaulas(nome, instituto) values (@nome, @instituto)";
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


    }


}
