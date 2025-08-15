using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PETROVALE
{
    internal class vendaProduto : conexao
    {

        private int id_vendaproduto;
        private decimal valor;
        private string data_vendaproduto;
        private int quantidade;
        private int id_posto;
        private int id_produto;
        private int id_funcionario;
        private int id_cliente;

        public void setId_vendaproduto(int id_vendaproduto)
        {
            this.id_vendaproduto = id_vendaproduto;
        }
        public int getId_vendaproduto()
        {
            return this.id_vendaproduto;
        }

        public void setValor(decimal valor)
        {
            this.valor = valor;
        }
        public decimal getValor()
        {
            return this.valor;
        }

        public void setData_vendaproduto(string data_vendaproduto)
        {
            this.data_vendaproduto = data_vendaproduto;
        }
        public string getData_vendaproduto()
        {
            return this.data_vendaproduto;
        }

        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public int getQuantidade()
        {
            return this.quantidade;
        }

        public void setId_posto(int id_posto)
        {
            this.id_posto = id_posto;
        }
        public int getId_posto()
        {
            return this.id_posto;
        }

        public void setId_produto(int id_produto)
        {
            this.id_produto = id_produto;
        }
        public int getId_produto()
        {
            return this.id_produto;
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

        public void inserir_vendaProduto()
        {
            string query = "INSERT INTO venda_produtos(valor, data_vendaproduto, quantidade, id_posto, id_produto, id_funcionario, id_cliente) VALUES ('" + getValor() + "','" + getData_vendaproduto() + "','" + getQuantidade() + "','" + getId_posto() + "','" + getId_produto() + "','" + getId_funcionario() + "','" + getId_cliente() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable consultar_vendaProduto()
        {
            this.abrirconexao();

            string mSQL = "Select * from venda_produtos ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar_vendaProduto()
        {
            string query = "UPDATE venda_produtos SET valor = '" + getValor() + "', data_vendaproduto = '" + getData_vendaproduto() + "', quantidade = '" + getQuantidade() + "', id_posto = '" + getId_posto() + "', id_produto = '" + getId_produto() + "', id_funcionario = '" + getId_funcionario() + "', id_cliente = '" + getId_cliente() +
                "' WHERE id_vendaproduto = '" + getId_vendaproduto() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir_vendaProduto()
        {
            string query = "DELETE from venda_produtos where id_vendaproduto = '" + getId_vendaproduto() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
