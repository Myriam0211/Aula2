using System;
using System.Collections.Generis;
0referências
public class Program
{
     0referências
      public static void Main()
      {
        List<string> nomes = new List<string>();

       
        bool continuar = true;

        
        while (continuar)
        {
            Cosole.WriteLine("\nMenu");
            Console.WriteLine("1. Adicionar o nome");
            Console.WriteLine("2. AListar nome");
            console.WriteLine("3. Sair");

            int opcao;
            if (int.TryParse(Console.ReadLine)