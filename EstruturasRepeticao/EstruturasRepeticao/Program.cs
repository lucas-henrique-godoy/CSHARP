using System;
using System.Collections.Generic;

namespace EstruturasRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            string nome = "Pessoa";
            int idade = 18;
            float decibeis = 15.14f;
            double salario = 10.50;
            bool verdade = true;
            var nsei = 0;

            // ESTRUTURAS DE REPETIÇÃO

            // FOR
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            */

            // WHILE
            // USANDO IF JUNTO DO WHILE 
            /*
            bool loop = false;
            int i = 0;

            while (loop)
            {
                if (i == 5)
                {
                    loop = false;
                }
                Console.WriteLine(i);
                i++;
            }
            */

            // MANEIRA CONVENCIONAL DE USO DO WHILE
            /*
            int i = 0;

            while (i < 5) // Continua enquanto 'i' for menor que 5
            {
                Console.WriteLine(i); // Imprime o valor atual de 'i'
                i++; // Incrementa 'i'
            }
            Console.WriteLine(i); // Imprime 5 fora do loop
            */

            // DO WHILE
            /*
            bool loop = true;

            do
            {
                // Código aqui
            } while (loop);
            */

            // FOREACH
            /*
            int[] numeros = new int[] { 10, 22, 30, 40, 50, 60, 90, 100 };

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            */

            // Criando e manipulando a lista de pessoas
            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < 2; i++)
            {
                Pessoa pessoa = new Pessoa
                {
                    Nome = "Lucas" + i,
                    Idade = i
                };
                pessoas.Add(pessoa);
            }

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine("Nome: " + pessoa.Nome + " Idade: " + pessoa.Idade);
            }

            Console.ReadKey();
        }
    }
}
