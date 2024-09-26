using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisao
{
    public class Endereco : Cidade
    {
        public string Logradouro { get; private set; }

        public Endereco(string nomeCidade, string nomeEstado) : base(nomeCidade, nomeEstado)
        {
            this.numCep = 1500309;
        }

        public Endereco(string nomeCidade, string nomeEstado, int numCep, string nomeLogradouro) : base(nomeCidade, nomeEstado, numCep)
        {
            this.Logradouro = nomeLogradouro;
        }

        

        public string AlterarEndereco(string logradouro)
        {
            this.Logradouro = logradouro;
            return Logradouro;
        }

        public string ShowValues()
        {
            string enderecoCompleto = this.Logradouro + " / " + this.nomeEstado +  " / " + this.numCep + " / " + this.nomeCidade;
            return enderecoCompleto;
        }
    }
}








/*
                    EXPLICAÇÃO DO CÓDIGO ACIMA:

 O código define um namespace chamado EstruturasDecisao e uma classe pública Endereco, que representa um endereço. A classe possui uma propriedade Logradouro, que pode ser lida publicamente, mas só alterada internamente. Além disso, inclui um método público chamado AlterarEndereco, que recebe um parâmetro logradouro, atualiza a propriedade Logradouro com esse valor e retorna o novo valor da propriedade. Dessa forma, a classe encapsula a funcionalidade relacionada ao endereço, permitindo a alteração controlada do logradouro.

Ou seja, como o metodo set de mudar a variavel esta private, eu so posso alterar o valor do atributo Logradouro em outra classe(ex: a classe principal program.cs) usando o método AlterarEndereço, e não posso alterar diretamente so atribuindo o valor ao atributo Logradouro. EXEMPLO DO QUE NÃO POSSO FAZER: endereco.Logradouro = "Rua 784";

EXEMPLO DO QUE POSSO FAZER: 
 string resultado = endereco.AlterarEndereco("Rua 784");
 
 */