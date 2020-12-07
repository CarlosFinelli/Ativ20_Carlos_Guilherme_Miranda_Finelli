using System;
using System.Collections.Generic;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> livros = new List<String>() { "Orgulho e Preconceito", "Dom Quixote de la Mancha", "O Pequeno Príncipe",
            "Dom Casmurro", "O Bandolim do Capitão Corelli", "O Conde de Monte Cristo", "Um Estudo em Vermelho",
            "A menina que roubava livros", "Alice no país das maravilhas", "Cem Anos de Solidão"};

            foreach (var item in livros)
            {
                Console.WriteLine($"{item} \n");
            }
            Console.ReadKey();

        }
    }
}
