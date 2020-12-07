using System;
using System.Collections.Generic;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            int cont = 1;
            Console.Write("Insira o número de registros que deseja efetuar: ");
            int N = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            while (cont <= N)
            {
                Funcionario f = new Funcionario();
                Console.Write("Insira o nome do Funcionário: ");
                f.Nome = Console.ReadLine();
                Console.Clear();
                Console.Write("Insira o salário do Funcionário: ");
                f.Salario = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                f.Id = cont;
                funcionarios.Add(f);
                Console.Clear();
                cont++;
            }
        Menu:
            Console.Clear();
            foreach(var item in funcionarios)
            {
                Console.WriteLine($"| Id: {item.Id} | Nome: {item.Nome} | Salario: {item.Salario} |\n");
            }
            Console.Write("Insira o Id que deseja aumentar o salário: ");
            int Id = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            var confereId = funcionarios.Find(item => item.Id == Id);
            if (confereId == null)
            {
                Console.Write("Id inválido");
                Console.ReadKey();
                goto Menu;
            }
            Console.Write($"Insira a porcentagem que deseja aumentar no salário do funcionário {confereId.Nome}: ");
            double porcentagem = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            confereId.aumentaSalario(porcentagem);
            Console.Write("Deseja alterar o salário de outro funcionário? \"1 = Sim, 2 = Não\": ");
            int opcao = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            if (opcao == 1)
            {
                goto Menu;
            }
            
            foreach(var item in funcionarios)
            {
                Console.WriteLine($"| Id: {item.Id} | Nome: {item.Nome} | Salário: {item.Salario} |\n");
            }
            Console.ReadKey();
            Console.Clear();
            Console.Write("Obrigado por utilizar nosso sistema.");
            Console.ReadKey();
        }
    }
}
