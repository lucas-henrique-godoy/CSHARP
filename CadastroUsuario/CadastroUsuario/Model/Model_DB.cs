using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.IO;
using System.Linq;
using System.Text;



namespace CadastroUsuario.Model
{
    public class Model_DB
    {
        private static readonly Lazy<Model_DB> Lazy = new Lazy<Model_DB>(() => new Model_DB());
        public static Model_DB Instance { get {  return Lazy.Value; } }
        public SqlConnection sqlConnection { get; set; } // Traz a conexão com o banco de dados.
        public SqlDataAdapter adapter { get; set; } // Permite adaptar alguns comandos do banco de dados.

        public Model_DB() 
        {
            sqlConnection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
        }


        public bool SalvarUsuario(Usuario usuario)
        {
            try 
            {
                if (Instance.sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    Instance.sqlConnection.Open();
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Nome", usuario.nome);
                parameters.Add("@DataNascimento", usuario.dataNascimento);
                parameters.Add("@CPF", usuario.cpf);
                parameters.Add("@Telefone", usuario.telefone);
                parameters.Add("@Endereco", usuario.endereco);

                string result = Instance.sqlConnection.Query<string>("spSLN_CadastroUsuario", parameters, commandType: CommandType.StoredProcedure).ToString();

                if (result == "Usuário já cadastrado!")
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Instance.sqlConnection.Close();
            }
        }
    }
}
