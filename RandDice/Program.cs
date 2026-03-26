using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //int dados = int.Parse(args[0]);
            //int semente = int.Parse(args[1]);
            int n, s,soma;

            n =int.Parse(args[0]);
            s =int.Parse(args[1]);

            //buscar a semente yk
            Random adakirin = new Random(s);
        
            soma = 0;
            for (int i = 0; i < n; i++)
            {
                int lancarDados = adakirin.Next(1, 7); 
                soma += lancarDados;
            }

            Console.WriteLine(soma);
        }
    }
}
