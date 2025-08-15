using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PETROVALE
{
    internal class estacionamento : conexao
    {

        private int id_agendamentoEstacionamento;
        private string horario;
        private string data_agendamento;
        private string tempo;
        private string placa;
        private int id_servico;

        public void setId_agendamentoEstacionamento(int id_agendamentoEstacionamento)
        {
            this.id_agendamentoEstacionamento = id_agendamentoEstacionamento;
        }
        public int getId_agendamentoEstacionamento()
        {
            return this.id_agendamentoEstacionamento;
        }

        public void setTempo(string tempo)
        {
            this.tempo = tempo;
        }
        public string getTempo()
        {
            return this.tempo;
        }

        public void setHorario(string horario)
        {
            this.horario = horario;
        }
        public string getHorario()
        {
            return this.horario;
        }

        public void setData_agendamento(string data_agendamento)
        {
            this.data_agendamento = data_agendamento;
        }
        public string getData_agendamento()
        {
            return this.data_agendamento;
        }

        public void setPlaca(string placa)
        {
            this.placa = placa;
        }
        public string getPlaca()
        {
            return this.placa;
        }

        public void setId_servico(int id_servico)
        {
            this.id_servico = id_servico;
        }
        public int getId_servico()
        {
            return this.id_servico;
        }

        public void inserir_agendamentoEstacionamento()
        {
            string query = "INSERT INTO agendamento_estacionamento(horario, data_agendamento, tempo, placa, id_servico) VALUES ('" + getHorario() + "','" + getData_agendamento() + "','" + getTempo() + "','" + getPlaca() + "','" + getId_servico() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable consultar_agendamentoEstacionamento()
        {
            this.abrirconexao();

            string mSQL = "Select * from agendamento_estacionamento ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar_agendamentoEstacionamento()
        {
            string query = "UPDATE agendamento_estacionamento SET horario = '" + getHorario() + "', data_agendamento = '" + getData_agendamento() + "', tempo = '" + getTempo() + "', placa = '" + getPlaca() + "', id_servico = '" + getId_servico() +
                "' WHERE id_agendamentoEstacionamento = '" + getId_agendamentoEstacionamento() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir_agendamentoEstacionamento()
        {
            string query = "DELETE from agendamento_estacionamento where id_agendamentoEstacionamento = '" + getId_agendamentoEstacionamento() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
