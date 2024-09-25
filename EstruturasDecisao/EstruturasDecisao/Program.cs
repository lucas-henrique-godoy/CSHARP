using System;

namespace EstruturasDecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nome = "Debugando "; // Nome da pessoa
            int idade = 18; // Idade da pessoa
            float decibeis = 15.14f; // 15.14 é tratado como double, então o 'f' é necessário para indicar que é um float.
            double salario = 10.50; // Salário em formato double
            bool verdade = true; // Variável booleana que indica verdadeiro ou falso
            var nsei = 0;   // Não espera nenhum valor, mas identifica qual é o valor que esta vindo. // 'var' é usado para inferir o tipo da variável automaticamente; aqui, nsei é inferido como int a partir do valor 0.
            */
            /* ESTRUTURAS DE DECISÃO
             
             * Verifica se o nome é "Lucas" e a idade é 18
            if (nome == "Lucas" && idade == 18)
            {
                Console.WriteLine(nome); // Imprime o nome
            }
            // Verifica se o nome é "Debugando C".
            else if (nome == "Debugando C")
            {
                Console.WriteLine("Ola Mundo!"); // Imprime uma saudação
            }
            else
            {
                Console.WriteLine("Sair"); // Imprime "Sair"; pode adicionar lógica adicional aqui, se necessário
            }*/

            /*ESTRUTURA SWITCH CASE
             * 
            switch (verdade)
            {
                case true:
                    nsei = 1;
                    break;

                default:
                    nsei = 2;
                    break;
            }          

            Console.WriteLine(nsei);
            */


            //OBJETO
            Endereco endereco = new Endereco();

            string resultado = endereco.AlterarEndereco("Rua 784");

            Console.WriteLine(resultado);


            Console.ReadKey(); // Aguarda uma tecla ser pressionada antes de fechar
        }
    }
}
