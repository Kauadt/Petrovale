using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PETROVALE
{
    internal class vendaServico : conexao
    {

        private int id_vendaservicos;
        private string data_vendaservicos;
        private decimal quantidade_combustivel;
        private int id_funcionario;
        private int id_cliente;
        private int id_servico;

        public void setId_vendaservicos(int id_vendaservicos)
        {
            this.id_vendaservicos = id_vendaservicos;
        }
        public int getId_vendaservicos()
        {
            return this.id_vendaservicos;
        }

        public void setData_vendaservicos(string data_vendaservicos)
        {
            this.data_vendaservicos = data_vendaservicos;
        }
        public string getData_vendaservicos()
        {
            return this.data_vendaservicos;
        }

        public void setQuantidade_combustivel(decimal quantidade_combustivel)
        {
            this.quantidade_combustivel = quantidade_combustivel;
        }
        public decimal getQuantidade_combustivel()
        {
            return this.quantidade_combustivel;
        }

        public void setId_funcionario(int id_funcionario)
        {
            this.id_funcionario = id_funcionario;
        }
        public int getId_funcionario()
        {
            return this.id_funcionario;
        }

        public void setId_cliente(int id_cliente)
        {
            this.id_cliente = id_cliente;
        }
        public int getId_cliente()
        {
            return this.id_cliente;
        }

        public void setId_servico(int id_servico)
        {
            this.id_servico = id_servico;
        }
        public int getId_servico()
        {
            return this.id_servico;
        }

        public void inserir_vendaServico()
        {
            string query = "INSERT INTO venda_servicos(data_vendaservicos, quantidade_combustivel, id_funcionario, id_cliente, id_servico) VALUES ('" + getData_vendaservicos() + "','" + getQuantidade_combustivel() + "','" + getId_funcionario() + "','" + getId_cliente() + "','" + getId_servico() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable consultar_vendaServico()
        {
            this.abrirconexao();

            string mSQL = "Select * from venda_servicos ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar_vendaServico()
        {
            string query = "UPDATE venda_servicos SET data_vendaservicos = '" + getData_vendaservicos() + "', quantidade_combustivel = '" + getQuantidade_combustivel() + "', id_funcionario = '" + getId_funcionario() + "', id_cliente = '" + getId_cliente() + "', id_servico = '" + getId_servico() +
                "' WHERE id_vendaservicos = '" + getId_vendaservicos() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir_vendaServico()
        {
            string query = "DELETE from venda_servicos where id_vendaservicos = '" + getId_vendaservicos() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
