using System;
using System.Collections.Generic;

namespace Es_Pag_278_294
{
    class Program
    {
        static void Main(string[] args)
        {
            //es 1 pag 278
            Console.WriteLine("Quanti numeri vuoi nel vettore?");
            int n = int.Parse(Console.ReadLine());
            List<int> lista = new List<int>(n);
            List<int> duplicati = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserisci un numero");
                int n1 = int.Parse(Console.ReadLine());
                if (lista.Contains(n1))
                    duplicati.Add(n1);
                lista.Add(n1);
            }
            for (int i = 0; i < duplicati.Count; i++)
            {
                Console.WriteLine($"Il numero {duplicati[i]} è doppione.");
            }
            Console.ReadLine();
        }
    }
}


           
