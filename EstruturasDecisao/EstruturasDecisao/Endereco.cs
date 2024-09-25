using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisao
{
    public class Endereco
    {
        public string Logradouro { get; private set; }

        public string AlterarEndereco(string logradouro)
        {
            this.Logradouro = logradouro;
            return Logradouro;
        }
    }
}
