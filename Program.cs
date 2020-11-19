using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array é uma lista de valores

             string [] produtos = {"biscoitos, iogurtes, pães"}; // a contagem de elementos dentro de uma lista se inica em 0
             double [] preços = {1.1, 2.3, 3.4};
             int [] idades ={20, 21, 22};


                 // Início de produtos
            Console.WriteLine("Qual o tamanho da lista que você deseja? ");

             int tamanho = int.Parse(Console.ReadLine());

             string [] nomesdeAlunos = new string [tamanho]; //Entre conchetes está o número do índice

            // Exemplo de array usando número de alunos
             for (var i = 0; i < nomesdeAlunos.Length; i++)
             {
                 Console.Write("Digite um nome ");
                 nomesdeAlunos[i] = Console.ReadLine();
             }

             for (var i = 0; i < nomesdeAlunos.Length; i++)
             {
                 Console.WriteLine(nomesdeAlunos[i]);

             } // Fim de exemplo usando nomes de alunos


            // Console.WriteLine(produtos[2]);

            // Console.WriteLine("Trocar iogurtes por qual item?");
            // // string item = produtos 

            // produtos [2] = Console.ReadLine();

            // Console.WriteLine(produtos[2]);

            // for (int i = 0; i < produtos.Length; i++) 
            { 
            // length serve para definir o tamanho de uma lista
                // ++ = Incrementando

                // Console.Writeline(i);
                // Console.WriteLine(produtos[i]);

            } // Fim de produtos

            // Preços
           for (var i = 0; i < preços.Length; i++)
           {
               Console.Write("Qual o preço? ");
               preços[1] = double.Parse(Console.ReadLine());
               
           }
           for (var i = 0; i < preços.Length; i++)
           {
               Console.WriteLine(preços[1]);
           } // Fim de preços

            // Idade
           for (var i = 0; i < idades.Length; i++)
           {
               Console.Write("Qual a sua idade meu amigo? ");
               idades[1] = int.Parse(Console.ReadLine());
           }
           for (var i = 0; i < idades.Length; i++)
           {
               Console.WriteLine(idades[1]);
           } // Fim de idades
        }
    }
}
