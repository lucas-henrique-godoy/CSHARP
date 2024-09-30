using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.Model
{
    internal class Usuario
    {
        public string nome {  get; set; }

        public int idade {  get; set; }

        public DateTime dataNascimento { get; set; }

        public string cpf { get; set; }

        public string telefone {  get; set; }

        public string endereco { get; set; }

        
    }
}
