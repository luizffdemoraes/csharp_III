using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas: Autenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Criando um GerenteDeContas.");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double getBonificacao()
        {
            return Salario * 0.25;
        }

    }
}
