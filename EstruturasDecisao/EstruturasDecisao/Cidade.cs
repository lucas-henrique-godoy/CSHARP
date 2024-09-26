using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisao
{
    public class Cidade
    {

        public string nomeCidade { get; set; }

        public string nomeEstado { get; set; }

        public int numCep { get; set; }

        public Cidade(string nomeCidade, string nomeEstado)
        {
            this.nomeCidade = nomeCidade;
            this.nomeEstado = nomeEstado;
        }
            
        public Cidade(string nomeCidade, string nomeEstado, int numCep)
        {
            this.nomeCidade = nomeCidade;
            this.nomeEstado = nomeEstado;
            this.numCep = numCep;
        }

    }
}
