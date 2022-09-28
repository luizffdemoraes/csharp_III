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
        private int _tipo;
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public Funcionario(int _tipo)
        {
            this._tipo = _tipo;
        }

        public double getBonificacao()
        {
            if (_tipo == 1)
            {
                return Salario;
            }
            else
            {
                return Salario * 0.1;
            }
        }
    }
}
