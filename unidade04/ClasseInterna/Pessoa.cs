using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseInterna
{
    class Pessoa
    {
        void getOlhos()
        {
            Olho olho = new Olho();
        }

        // assim se cria uma classe interna, é uma classe dentro de outra classe
        // é muito útil para associar classes á outras classes sem precisar usa namespaces
        public class Olho
        {
            public static string Iris = "XYZ";
            public Olho()
            {
                Pessoa pessoa = new Pessoa();
            }
        }
    }
}
