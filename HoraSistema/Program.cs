using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime horaAtual;

            horaAtual = DateTime.Now;
            Console.Write("Data e Hora Atual: ");
            Console.WriteLine($"{horaAtual}");
            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
