using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CLientes
{
    public class CadastroClientes
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public CadastroClientes(string nome, string rg, string cpf, string endereco, string bairro, string cidade, string numero, string estado,string telefone, string email)
        {
            //Comandos Sql
            cmd.CommandText = "Insert into Clientes (nome, rg, cpf, endereco, bairro, cidade, numero, estado, telefone, email) values (@nome, @rg, @cpf, @endereco, @bairro,@cidade, @numero, @estado, @telefone, @email)";

            //Parametros
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@rg", rg);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                // COnectando ao bd -- class Conexao
                cmd.Connection = conexao.conectar();

                //Executar Comando
                cmd.ExecuteNonQuery();

                // desconectar bd
                conexao.desconectar();

                //Mostrar mensagem de erro ou sucesso -- Variavel declarada acima
                this.mensagem = "Cadastrado com sucesso";

            }
            catch (SqlException e)// tratar um erro expessifico no sql, variavel "e" para guardar o erro
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";
            
            }

        }
    }
}
