using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        // 0 - Funcionário
        // 1 - Diretor
        // 2 - Designer
        // N - ...
        // private int _tipo;
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; set; }

        // Ao adicionar vitual permite a rescrita do método nas classes derivadas
        public virtual double getBonificacao()
        {
            return Salario * 0.1;
        }


        // Definir que uma propriedade e da Classe não do Objeto  
        public static int totalDeFuncionarios { get; private set; }

        public Funcionario(string cpf)
        {
            Cpf = cpf;
            Console.WriteLine("Criando um funcionário.");
            totalDeFuncionarios++;
        }

    }
}
