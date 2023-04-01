using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê o conteúdo do arquivo e armazena em uma string
            string json = File.ReadAllText("./dados.json");

            // Converte a string para uma lista de objetos Faturamento
             var faturamentoMensal = JsonConvert.DeserializeObject<List<Faturamento>>(json);

            var valores = new List<decimal>();
            foreach (var faturamento in faturamentoMensal)
            {
                valores.Add(faturamento.Valor);
            }

            var media = valores.Where(x => x > 0).Average();
            var diasAcimaDaMedia = valores.Count(x => x > media);
            var menorValor = valores.Where(x => x > 0).Min();
            var maiorValor = valores.Where(x => x > 0).Max();

            Console.WriteLine($"Menor valor: R${menorValor:F2}");
            Console.WriteLine($"Maior valor: R${maiorValor:F2}");
            Console.WriteLine($"Número de dias acima da média: R${diasAcimaDaMedia:F2}");
        }
    }

}
