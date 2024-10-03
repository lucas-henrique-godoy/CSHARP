using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace CadastroUsuario.Model
{
    public class Model_DB
    {
        private static readonly Lazy<Model_DB> Lazy = new Lazy<Model_DB>(() => new Model_DB());
        public static Model_DB Instance { get { return Lazy.Value; } }
        public SqlConnection sqlConnection { get; set; } // Traz a conexão com o banco de dados.

        public Model_DB()
        {
            // Conexão ao banco de dados dbCadastro
            sqlConnection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Database=dbCadastro;Trusted_Connection=True;");
        }

        public bool SalvarUsuario(Usuario usuario)
        {
            try
            {
                if (Instance.sqlConnection.State != ConnectionState.Open)
                {
                    Instance.sqlConnection.Open();
                }

                // Verifica se o usuário já existe
                var usuarioExistente = Instance.sqlConnection.QueryFirstOrDefault<string>(
                    "SELECT CPF FROM tbUsuario WHERE CPF = @CPF", new { CPF = usuario.cpf });

                if (usuarioExistente != null)
                {
                    return false; // Usuário já cadastrado
                }

                // Insere o novo endereço e captura o ID
                var idEndereco = Instance.sqlConnection.QuerySingle<int>(
                    "INSERT INTO tbEndereco (Logradouro) OUTPUT INSERTED.ID VALUES (@Endereco);",
                    new { Endereco = usuario.endereco });

                // Calcula a idade
                var idade = DateTime.Now.Year - usuario.dataNascimento.Year;

                // Insere o novo usuário
                Instance.sqlConnection.Execute(
                    "INSERT INTO tbUsuario (Nome, Idade, Ativo, CPF, IdEndereco) VALUES (@Nome, @Idade, 1, @CPF, @IdEndereco);",
                    new { Nome = usuario.nome, Idade = idade, CPF = usuario.cpf, IdEndereco = idEndereco });

                return true; // Cadastro realizado com sucesso
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
