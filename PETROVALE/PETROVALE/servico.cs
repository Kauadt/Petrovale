using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PETROVALE
{
    internal class servico : conexao
    {

        private int id_servico, desconto;
        private string nome, tipo;
        private decimal preco;


        public void setId_servico(int id_servico)
        {
            this.id_servico = id_servico;
        }
        public int getId_servico()
        {
            return this.id_servico;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return this.tipo;
        }

        public void setPreco(decimal preco)
        {
            this.preco = preco;
        }
        public decimal getPreco()
        {
            return this.preco;
        }

        public void setDesconto(int desconto)
        {
            this.desconto = desconto;
        }
        public int getDesconto()
        {
            return this.desconto;
        }

        public DataTable consultar_servico()
        {
            this.abrirconexao();

            string mSQL = "Select * from servicos ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar_servico()
        {
            string query = "UPDATE servicos SET preco = '" + getPreco() + "', desconto = '" + getDesconto() +
                "' WHERE id_servico = '" + getId_servico() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
