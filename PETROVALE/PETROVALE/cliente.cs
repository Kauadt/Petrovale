using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PETROVALE
{
    internal class cliente : conexao
    {

        private int id_cliente;
        private string cpf;
        private string nome;
        private string estado;
        private string cidade;
        private string bairro;
        private string rua;
        private int numero;
        private string email;
        private string telefone;
        private string senhaC;
        private int id_contaBancaria;

        public void setId_cliente(int id_cliente)
        {
            this.id_cliente = id_cliente;
        }
        public int getId_cliente()
        {
            return this.id_cliente;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return this.cpf;
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

        public void setSenha(string senhaC)
        {
            this.senhaC = senhaC;
        }

        public string getSenha()
        {
            return this.senhaC;
        }
        public void setId_contaBancaria(int id_contaBancaria)
        {
            this.id_contaBancaria = id_contaBancaria;
        }
        public int getId_contaBancaria()
        {
            return this.id_contaBancaria;
        }

        public void inserir_cliente()
        {
            string query = "INSERT INTO clientes(cpf, nome, estado, cidade, bairro, rua, numero, email, telefone, senha, id_contaBancaria) VALUES ('" + getCpf() + "','" + getNome() + "','" + getEstado() + "','" + getCidade() +
                "','" + getBairro() + "','" + getRua() + "','" + getNumero() + "','" + getEmail() + "','" + getTelefone() + "','" + getSenha() + "','" + getId_contaBancaria() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable consultar_cliente()
        {
            this.abrirconexao();

            string mSQL = "Select * from clientes ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar_cliente()
        {
            string query = "UPDATE clientes SET cpf = '" + getCpf() + "', nome = '" + getNome() + "', estado = '" + getEstado() + "', cidade = '" + getCidade() + "', bairro = '" + getBairro() + "', rua = '" + getRua() + "', numero = '" + getNumero() + "', email = '" + getEmail() + "', telefone = '" + getTelefone() + "', senha = '" + getSenha() + "', id_contaBancaria = '" + getId_contaBancaria() +
                "' WHERE id_cliente = '" + getId_cliente() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir_cliente()
        {
            string query = "DELETE from clientes where id_cliente = '" + getId_cliente() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
