using System;

namespace CalculadoraDeDias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira data  (dd//mm/aaaa): ");
            string dataInicialString = Console.ReadLine();

            Console.Write("Digite a segunda data (dd//mm//aaaa): ");
            string dataFinalString = Console.ReadLine();

            // Convertendo as strings de data para objetos DateTime
            DateTime dataInicial = DateTime.ParseExact(dataInicialString, "01/01/2024", null);
            DateTime dataFinal = DateTime.ParseExact(dataFinalString, "31/12/2024", null);

            // Calculando a diferença entre as datas
            TimeSpan diferenca = dataFinal - dataInicial;

            // Exibindo o resultado
            Console.WriteLine("A diferença entre as datas é de {0} dias.", diferenca.TotalDays);
        }
    }
}