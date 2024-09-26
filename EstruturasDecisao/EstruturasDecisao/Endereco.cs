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

/*
                    EXPLICAÇÃO DO CÓDIGO ACIMA:

 O código define um namespace chamado EstruturasDecisao e uma classe pública Endereco, que representa um endereço. A classe possui uma propriedade Logradouro, que pode ser lida publicamente, mas só alterada internamente. Além disso, inclui um método público chamado AlterarEndereco, que recebe um parâmetro logradouro, atualiza a propriedade Logradouro com esse valor e retorna o novo valor da propriedade. Dessa forma, a classe encapsula a funcionalidade relacionada ao endereço, permitindo a alteração controlada do logradouro.
 
 */