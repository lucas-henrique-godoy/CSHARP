using System;

namespace EstruturasDecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Debugando C";
            int idade = 18;
            float decibeis = 15.14f;
            double salario = 10.50;
            bool verdade = true;
            var nsei = 0; // variavel que não espera nenhum valor, mas identifica qual é o valor que esta vindo.

            if (nome == "Lucas" && idade == 18)
            {
                Console.WriteLine(nome);
            }
            else if (nome == "Debugando C")
            {
                Console.WriteLine("Ola Mundo!");
            }
            else
            {
                Console.WriteLine("Sair"); // Pode adicionar algum código ou remover se não necessário.
            }

            Console.ReadKey();
        }
    }
}
