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
            string nome = "Debugando ";
            int idade = 18;
            float decibeis = 15.14f;
            double salario = 10.50;
            bool verdade = true;
            var nsei = 0;


            // Estruturas de Repetição

            /*FOR
            for (int i = 0; i < 5;i++)
            {
                Console.WriteLine(i);                
            }*/


            //WHILE
            bool loop = true;

            int i = 0;

            while (loop)
            {
                if(i == 5)
                {
                    loop = false;
                }
                Console.WriteLine(i);
                i++;
            }




            //




            Console.WriteLine("FIM!");

            Console.ReadKey();
        }
}   }
