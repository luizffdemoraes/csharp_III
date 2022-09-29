using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    // A partir do momento que adicionamos o abstract definimos a classe como base para criação de outras com comportamento e propriedades que todo funcionário deve ter
    // Não é possível criar objetos de uma classe abistrata
    public abstract class Funcionario
    {
        // 0 - Funcionário
        // 1 - Diretor
        // 2 - Designer
        // N - ...
        // private int _tipo;
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        //protected modificador de visibilidade de fora da hierarquia de herança não será possível acesso
        public double Salario { get; protected set; }

        // Ao adicionar vitual permite a rescrita do método nas classes derivadas
        // Definir que uma propriedade e da Classe não do Objeto  
        public static int totalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            Console.WriteLine("Criando um funcionário.");
            totalDeFuncionarios++;
        }
        // Ao adicionar abistract no método toda classe que herdar dela tem que implementar 
        public abstract double getBonificacao();

        public abstract void AumentarSalario();
    }
}
