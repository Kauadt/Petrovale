using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PETROVALE
{
    class funcionario : conexao
    {

        private int id_funcionario, numero, id_posto;
        private string ctps, nome, estado, cidade, bairro, rua, email, telefone, senha, cargo;


        public void setId_funcionario(int id_funcionario)
        {
            this.id_funcionario = id_funcionario;
        }
        public int getId_funcionario()
        {
            return this.id_funcionario;
        }

        public void setCtps(string ctps)
        {
            this.ctps = ctps;
        }
        public string getCtps()
        {
            return this.ctps;
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

        public void setCargo(string cargo)
        {
            this.cargo = cargo;
        }

        public string getCargo()
        {
            return this.cargo;
        }

        public void setId_posto(int id_posto)
        {
            this.id_posto = id_posto;
        }
        public int getId_posto()
        {
            return this.id_posto;
        }

        public void inserir_funcionario()
        {
            string query = "INSERT INTO funcionarios(ctps, nome, estado, cidade, bairro, rua, numero, email, telefone, senha, cargo, id_posto) VALUES ('" + getCtps() + "','" + getNome() + "','" + getEstado() + "','" + getCidade() +
                "','" + getBairro() + "','" + getRua() + "','" + getNumero() + "','" + getEmail() + "','" + getTelefone() + "','" + getSenha() + "','" + getCargo() + "','" + getId_posto() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable consultar_funcionario()
        {
            this.abrirconexao();

            string mSQL = "Select * from funcionarios ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar_funcionario()
        {
            string query = "UPDATE funcionarios SET ctps = '" + getCtps() + "', nome = '" + getNome() + "', estado = '" + getEstado() + "', cidade = '" + getCidade() + "', bairro = '" + getBairro() + "', rua = '" + getRua() + "', numero = '" + getNumero() + "', email = '" + getEmail() + "', telefone = '" + getTelefone() + "', senha = '" + getSenha() + "', cargo = '" + getCargo() + "', id_posto = '" + getId_posto() +
                "' WHERE id_funcionario = '" + getId_funcionario() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir_funcionario()
        {
            string query = "DELETE from funcionarios where id_funcionario = '" + getId_funcionario() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
