using System;


namespace ConsoleApp1
{
    class App
    {
        static void Main(string[] args)
        {
           const int capMaxima = 1000;

            int ingressosVendidos = 75;
            int ingressosRestantes = capMaxima - ingressosVendidos;

            Console.WriteLine("Ingressos vendidos: "+ ingressosVendidos + " de 1000");
            Console.WriteLine("Ingressos Restantes: "+ ingressosRestantes);

        }
    }
}
