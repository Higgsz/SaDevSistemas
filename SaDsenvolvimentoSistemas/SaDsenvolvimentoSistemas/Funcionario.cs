using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaDsenvolvimentoSistemas
{
    class Funcionario
    {
        //Atributos da classe
        public string NomeFunc { get; set; }
        public int CpfFunc { get; set; }
        public string SexoFunc { get; set; }
        public int TelefoneFunc { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public override string ToString()
        {
            return "Nome: " + NomeFunc
                  + "CPF: " + CpfFunc
                  + "Sexo: " + SexoFunc
                  + "Telefone: " + TelefoneFunc
                  + "Cargo: " + Cargo
                  + "Salário: " + Salario;
        }
    }
}
