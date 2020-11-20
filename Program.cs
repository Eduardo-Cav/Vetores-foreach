using System;

namespace Vetores_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = {"mouse, teclado, headset, mousepad, monitor, mesa, cadeira"};
            double[] precos = {200, 190, 200, 70, 1200, 300, 1000};
            
            Console.Write("Objetivo: ");
            Console.WriteLine("Montar um setup novo"); 

            for (int i = 0; i < produtos.Length; i++)
            {
              Console.WriteLine("Items: "); 
              Console.WriteLine(produtos[i]);
            }
            Console.WriteLine("Preço de cada peça, respectivamente: "); 
            for (int i = 0; i < precos.Length; i++)
            {
              Console.WriteLine(precos[i]);
            }
        }
    }
}
