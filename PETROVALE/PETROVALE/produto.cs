using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PETROVALE
{
    internal class produto : conexao
    {
        private int id_produto;
        private string nome;
        private string descricao;
        private decimal preco;
        private int desconto;
        private string foto;

        public void setId_produto(int id_produto)
        {
            this.id_produto = id_produto;
        }
        public int getId_produto()
        {
            return this.id_produto;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getDescricao()
        {
            return this.descricao;
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

        public string _foto
        {
            get
            {
                return foto;
            }
            set
            {
                foto = value;
            }
        }

        public void inserir_produto()
        {
            string query = "INSERT INTO produtos(nome, descricao, preco, desconto, foto) VALUES ('" + getNome() + "','" + getDescricao() + "','" + getPreco() +
                "','" + getDesconto() + "','" + foto + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable consultar_produto()
        {
            this.abrirconexao();

            string mSQL = "Select * from produtos ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar_produto()
        {
            string query = "UPDATE produtos SET nome = '" + getNome() + "', descricao = '" + getDescricao() + "', preco = '" + getPreco() + "', desconto = '" + getDesconto() + "', foto = '" + foto +
                "' WHERE id_produto = '" + getId_produto() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir_produto()
        {
            string query = "DELETE from produtos where id_produto = '" + getId_produto() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
