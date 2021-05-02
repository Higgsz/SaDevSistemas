using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesForms
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Funcionario()
        {

        }

        public override string ToString()
        {
            return "Nome; " + Nome
            +"Idade: " + Idade;
        }
    }
}
