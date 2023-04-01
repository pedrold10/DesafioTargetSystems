using System;

namespace Distribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir o faturamento mensal de cada estado
            decimal faturamentoSP = 67836.43m;
            decimal faturamentoRJ = 36678.66m;
            decimal faturamentoMG = 29229.88m;
            decimal faturamentoES = 27165.48m;
            decimal faturamentoOutros = 19849.53m;

            // Calcular o faturamento total
            decimal faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

            // Calcular o percentual de representação de cada estado
            decimal percentualSP = (faturamentoSP / faturamentoTotal) * 100;
            decimal percentualRJ = (faturamentoRJ / faturamentoTotal) * 100;
            decimal percentualMG = (faturamentoMG / faturamentoTotal) * 100;
            decimal percentualES = (faturamentoES / faturamentoTotal) * 100;
            decimal percentualOutros = (faturamentoOutros / faturamentoTotal) * 100;

            // Exibir os resultados
            Console.WriteLine($"Percentual de representação de SP: {percentualSP:f2}%");
            Console.WriteLine($"Percentual de representação de RJ: {percentualRJ:f2}%");
            Console.WriteLine($"Percentual de representação de MG: {percentualMG:f2}%");
            Console.WriteLine($"Percentual de representação de ES: {percentualES:f2}%");
            Console.WriteLine($"Percentual de representação de Outros: {percentualOutros:f2}%");
        }
    }
}
