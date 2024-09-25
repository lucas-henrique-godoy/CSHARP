// Importa namespaces necessários do .NET
using System; // Fornece classes básicas, como Console
using System.Collections.Generic; // Fornece classes para coleções genéricas
using System.Linq; // Fornece métodos de consulta para coleções
using System.Text; // Fornece classes para manipulação de strings
using System.Threading.Tasks; // Fornece classes para operações assíncronas e paralelas

// Define um namespace chamado EstruturasDecisao
namespace EstruturasDecisao
{
    // Declara uma classe pública chamada Endereco
    public class Endereco
    {
        // Atributo: propriedade pública Logradouro com acesso restrito ao seu modificador 'set'
        public string Logradouro { get; private set; }

        // Método público para alterar o endereço
        public string AlterarEndereco(string logradouro)
        {
            // Atribui o novo logradouro ao atributo Logradouro
            this.Logradouro = logradouro;
            // Retorna o logradouro atualizado
            return Logradouro;
        }
    }
}
