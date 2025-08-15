using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace PETROVALE
{
    class posto : conexao
    {

        private int id_posto;
        private string cnpj;
        private string nome;
        private string estado;
        private string cidade;
        private string bairro;
        private string rua;
        private int numero;
        private string email;
        private string telefone;
        private string senha;

        public void setId_posto(int id_posto)
        {
            this.id_posto = id_posto;
        }
        public int getId_posto()
        {
            return this.id_posto;
        }

        public void setCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }
        public string getCnpj()
        {
            return this.cnpj;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }
        public string getEstado()
        {
            return this.estado;
        }

        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public string getCidade()
        {
            return this.cidade;
        }

        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }
        public string getBairro()
        {
            return this.bairro;
        }

        public void setRua(string rua)
        {
            this.rua = rua;
        }
        public string getRua()
        {
            return this.rua;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public int getNumero()
        {
            return this.numero;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return this.email;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getTelefone()
        {
            return this.telefone;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public string getSenha()
        {
            return this.senha;
        }

        public void inserir_posto()
        {
            string query = "INSERT INTO postos(cnpj, nome, estado, cidade, bairro, rua, numero, email, telefone, senha) VALUES ('" + getCnpj() + "','" + getNome() + "','" + getEstado() + "','" + getCidade() +
                "','" + getBairro() + "','" + getRua() + "','" + getNumero() + "','" + getEmail() + "','" + getTelefone() + "','" + getSenha() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable consultar_posto()
        {
            this.abrirconexao();

            string mSQL = "Select * from postos ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar_posto()
        {
            string query = "UPDATE postos SET cnpj = '" + getCnpj() + "', nome = '" + getNome() + "', estado = '" + getEstado() + "', cidade = '" + getCidade() + "', bairro = '" + getBairro() + "', rua = '" + getRua() + "', numero = '" + getNumero() + "', email = '" + getEmail() + "', telefone = '" + getTelefone() + "', senha = '" + getSenha() +
                "' WHERE id_posto = '" + getId_posto() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir_posto()
        {
            string query = "DELETE from postos where id_posto = '" + getId_posto() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public int consultar_login()
        {
            this.abrirconexao();

            //count necessário para contar quantos usuárois exitem dentro do banco de dados

            string query = "select count(email) from postos where email = '" +
                getEmail() + "' and senha = '" + getSenha() + "'";

            //execução da query digitada na linha a cima
            MySqlCommand cmd = new MySqlCommand(query, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            //Int32 é o tipo de variável para armazenar o valor do resultado da query
            //resultado_query é o nome da variável que armazena valor
            Int32 resultado_query = Convert.ToInt32(cmd.ExecuteScalar());
            //finaliza a consulta
            cmd.Dispose();

            int valor_login;
            valor_login = resultado_query;
            this.fecharconexao();
            return valor_login;
        }
    }
}
