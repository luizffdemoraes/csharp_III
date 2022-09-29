using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor: Funcionario
    {

        // override permite redefinir o metodo na classe derivada
        public override double getBonificacao()
        {
            // Ao utilizar o base você acessa o método da classe base / superclasse
            return Salario + base.getBonificacao();
        }

        // ctor + tab 2 vezes cria a o metodo construtor da classe
        public Diretor(string cpf, double salario):base(cpf, salario)
        {
            Console.WriteLine("Criando um diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
