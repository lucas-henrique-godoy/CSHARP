using System; // Usando a biblioteca system

namespace Meu_Primeiro_Hello_World // Namespace permite referenciar em outros projetos o local que queremos acessar.
{
    internal class Program // Classe interna que não consegue ser vista externamente.
    {
        static void Main(string[] args) // Método estático que sempre vai se construir independente da instanciação da classe, para podermos iniciar o programa.
        {
            Console.WriteLine("Hello World!"); // Console(terminal) - WriteLine(escreva linha)
        }
    }
}
