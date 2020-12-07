using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio
{
    class Funcionario
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public double Salario { get; set; }

        public void aumentaSalario(double porcentagem)
        {
            Salario += (Salario * porcentagem) / 100;
        }
    }
}
