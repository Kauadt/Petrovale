using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PETROVALE
{
    internal class vagas : conexao
    {

        private int id_vaga;
        private int numero_vagas;
        private string status_vagas;
        private int id_agendamentoEstacionamento;

        public void setId_vaga(int id_vaga)
        {
            this.id_vaga = id_vaga;
        }
        public int getId_vaga()
        {
            return this.id_vaga;
        }

        public void setNumero_vagas(int numero_vagas)
        {
            this.numero_vagas = numero_vagas;
        }
        public int getNumero_vagas()
        {
            return this.numero_vagas;
        }

        public void setStatus_vagas(string status_vagas)
        {
            this.status_vagas = status_vagas;
        }
        public string getStatus_vagas()
        {
            return this.status_vagas;
        }

        public void setId_agendamentoEstacionamento(int id_agendamentoEstacionamento)
        {
            this.id_agendamentoEstacionamento = id_agendamentoEstacionamento;
        }
        public int getId_agendamentoEstacionamento()
        {
            return this.id_agendamentoEstacionamento;
        }

        public void inserir_vagas()
        {
            string query = "INSERT INTO vagas(numero_vagas, status_vagas, id_agendamentoEstacionamento) VALUES ('" + getNumero_vagas() + "','" + getStatus_vagas() + "','" + getId_agendamentoEstacionamento() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable consultar_vagas()
        {
            this.abrirconexao();

            string mSQL = "Select * from vagas ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar_vagas()
        {
            string query = "UPDATE vagas SET numero_vagas = '" + getNumero_vagas() + "', status_vagas = '" + getStatus_vagas() + "', id_agendamentoEstacionamento = '" + getId_agendamentoEstacionamento() +
                "' WHERE id_vaga = '" + getId_vaga() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir_vagas()
        {
            string query = "DELETE from vagas where id_vaga = '" + getId_vaga() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
