using System.Data.SqlClient;
using System.Data;
namespace CLientes
{
   public class Conexao
    {
        SqlConnection con = new SqlConnection();// instanciando a classe connection

        // Construtor
        public Conexao()
        {
            //passar a conexao com o bd
            con.ConnectionString = @"Data Source=DESKTOP-KLC6HK7;Initial Catalog=ClientesErp;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
           
        }
        // metodo Conectar
        public SqlConnection conectar()
        {
            // Verificação se o bd está aberto
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
               
            return con;
        }
        // Metodo Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

           
        }

    }
}