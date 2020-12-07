using System;
using System.Collections.Generic;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> livros = new List<String>() { "1 - Orgulho e Preconceito", "2 - Dom Quixote de la Mancha", 
            "3 - O Pequeno Príncipe","4 - Dom Casmurro", "5 - O Bandolim do Capitão Corelli",
            "6 - O Conde de Monte Cristo", "7 - Um Estudo em Vermelho","8 - A menina que roubava livros",
            "9 - Alice no país das maravilhas", "10 - Cem Anos de Solidão"};

            foreach (var item in livros)
            {
                Console.WriteLine($"{item} \n");
            }
            Console.ReadKey();
            Console.Clear();

            livros.Insert(0, $"0 - O coração das trevas");
            Console.WriteLine("Adicionando livro na posição 0 da lista: \n");
            foreach(var item in livros)
            {
                Console.WriteLine($"{item} \n");
            }
            Console.ReadKey();
            Console.Clear();

            livros.Add($"{livros.Count} - Guerra e paz");
            Console.WriteLine("Adicionando livro na última posição da lista: \n");

            foreach(var item in livros)
            {
                Console.WriteLine($"{item} \n");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Número de elementos na lista: {livros.Count}");
            Console.ReadKey();
            Console.Clear();

            String encontra = livros.Find(item => item[4] == 'A');
            Console.WriteLine($"Primeiro livro com a letra A: {encontra}");
            Console.ReadKey();
            Console.Clear();

            encontra = livros.FindLast(item => item[4] == 'O');
            Console.WriteLine($"Último livro que começa com O: {encontra}");
            Console.ReadKey();
            Console.Clear();

            livros.RemoveAt(5);
            Console.WriteLine("Removendo o elemento 6 da lista: \n");
            foreach(var item in livros)
            {
                Console.WriteLine($"{item} \n");
            }
            Console.ReadKey();
            Console.Clear();

            livros.RemoveRange(0, 3);
            Console.WriteLine("Removendo a partir da poisição 0 de 3 em 3: \n");
            foreach(var item in livros)
            {
                Console.WriteLine($"{item} \n");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Obrigado por utilizar.");
            Console.ReadKey();
        }
    }
}
