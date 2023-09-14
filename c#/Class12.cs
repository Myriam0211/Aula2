using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;
class Program
{
    static void Main(string[] args)
    { 
        Autor tolkien = new Autor
    {
        AutorId = 1,
        Nome = "J.R.R. Tolkien",
        DataNascimento = new DateTime(1892, 1, 3)
  };

    //Criar um livro
    Livro SenhorDosAneis = new Livro
    {
        LivroId = 1,
        Título = "O Senhor dos Anés",
        AnoPublicacao = 1954,
        Autor = tolkien
    };

    //Associar o livro ao autor
    tolkien.Livros.Add(sennhorDosAneis);

    //Exibir as informações
    Console.WriteLine($"Autor: {tolkien.Nome)");
    foreach (var livro in tolkien.Livros)
    {
         Console.WriteLine($"Livro: {livro.Título}, Publicado em: {livro.anoPublicacao}");
    }
}
}
