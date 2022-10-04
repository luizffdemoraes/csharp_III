using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    public class Livraria
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Isbn { get; set; } 
        public int AnoDePublicacao { get; set; }
        public string EstiloLiterario { get; set; }
        public int NumeroDePaginas { get; set; }
        public string PaisDePublicacao { get; set; }

        public Livraria(int Isbn, string Titulo)
        {
            this.Isbn = Isbn;
            this.Titulo = Titulo;
        }


 



    }
}
