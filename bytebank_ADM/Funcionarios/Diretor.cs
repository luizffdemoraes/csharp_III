using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor: Funcionario
    {
        // ctor + tab 2 vezes cria a o metodo construtor da classe
        public Diretor(string cpf):base(cpf, 5000)
        {
            Console.WriteLine("Criando um Diretor.");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        // override permite redefinir o metodo na classe derivada
        public override double getBonificacao()
        {
            // Ao utilizar o base você acessa o método da classe base / superclasse
            return Salario * 0.5;
        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
