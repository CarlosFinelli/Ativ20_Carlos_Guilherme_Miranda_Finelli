using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bebidas> bebidas = new List<Bebidas>();
            int opcao = 0;
            while (opcao != 2)
            {
                Bebidas bebida = new Bebidas();
                Console.Write("Insira o nome da bebida: ");
                bebida.Nome = Console.ReadLine();
                Console.Clear();
                Console.Write("Insira o preço da bebida: ");
                bebida.Valor = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                if(bebidas.Count == 0)
                {
                    bebida.Id = 1;
                    bebidas.Add(bebida);
                } else
                {
                    var acha = bebidas.Last();
                    bebida.Id = acha.Id + 1;
                    bebidas.Add(bebida);
                }
                Console.Write("Deseja inserir mais alguma bebida? \"1 = Sim, 2 = Não\"");
                opcao = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }

            foreach(var item in bebidas)
            {
                Console.WriteLine($"Código da bebida: {item.Id} | Nome: {item.Nome} | Valor: {item.Valor} |\n");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar nosso programa.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
