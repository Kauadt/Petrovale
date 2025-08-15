using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PETROVALE
{
    internal class lavagem : conexao
    {

        private int id_agendamentoLavagem;
        private string horario;
        private string data_agendamento;
        private string placa;
        private int id_servico;

        public void setId_agendamentoLavagem(int id_agendamentoLavagem)
        {
            this.id_agendamentoLavagem = id_agendamentoLavagem;
        }
        public int getId_agendamentoLavagem()
        {
            return this.id_agendamentoLavagem;
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

        public void inserir_agendamentoLavagem()
        {
            string query = "INSERT INTO agendamento_lavagem(horario, data_agendamento, placa, id_servico) VALUES ('" + getHorario() + "','" + getData_agendamento() + "','" + getPlaca() + "','" + getId_servico() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable consultar_agendamentoLavagem()
        {
            this.abrirconexao();

            string mSQL = "Select * from agendamento_lavagem ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar_agendamentoLavagem()
        {
            string query = "UPDATE agendamento_lavagem SET horario = '" + getHorario() + "', data_agendamento = '" + getData_agendamento() + "', placa = '" + getPlaca() + "', id_servico = '" + getId_servico() +
                "' WHERE id_agendamentoLavagem = '" + getId_agendamentoLavagem() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir_agendamentoLavagem()
        {
            string query = "DELETE from agendamento_lavagem where id_agendamentoLavagem = '" + getId_agendamentoLavagem() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
