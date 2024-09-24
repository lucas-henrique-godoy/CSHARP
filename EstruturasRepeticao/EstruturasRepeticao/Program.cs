﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Pessoa";
            int idade = 18;
            float decibeis = 15.14f;
            double salario = 10.50;
            bool verdade = true;
            var nsei = 0;


            // ESTRUTURAS DE REPETIÇÃO.

            /*FOR
            for (int i = 0; i < 5;i++)
            {
                Console.WriteLine(i);                
            }*/

            //______________________________________________________________

            //WHILE
            // USANDO IF JUNTO DO WHILE 
            bool loop = false;
            
             int i = 0;
            /*
             while (loop)
             {
                 if(i == 5)
                 {
                     loop = false;
                 }
                 Console.WriteLine(i);
                 i++;
             }
            */

            //______________________________________________________________

            //MANIERA CONVENCIONAL DE USO DO WHILE

            /*int i = 0;

            while (i < 5) // Continua enquanto 'i' for menor que 5
            {
                Console.WriteLine(i); // Imprime o valor atual de 'i'
                i++; // Incrementa 'i'
            }
            Console.WriteLine(i); // Imprime 5 fora do loop
            */

            //______________________________________________________________
            /*string nomeRaiz = "Pessoa";

            while (loop) 
            { 
                nome = nomeRaiz + i.ToString();
                if (nome == "Pessoa3")
                {
                    loop = false;
                }
                else
                {
                    i++;
                }                
            }
            */
            //______________________________________________________________

            /*DO WHILE
            do
            {
                loop = true;

            }while (loop);
            */

            //______________________________________________________________

            // FOREACH

            int[] numeros = new int[] { 10, 22, 30, 40, 50, 60, 90, 100 };

            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }


            /*List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < 2; i++) 
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = "Lucas" + i;
                pessoa.Idade = i;
                pessoas.Add(pessoa);
            }

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine("Nome: " + pessoa.Nome + "Idade: " + pessoa.Idade);
            }
            */

            Console.ReadKey();
        }
}   }
