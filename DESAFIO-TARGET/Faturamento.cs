using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_TARGET
{
    public class Faturamento
    {
        public void AnalyzeFaturamento(List<double> faturamentoDiario)
        {
            var diasValidos = faturamentoDiario.Where(f => f > 0).ToList();

            double menorValor = diasValidos.Min();
            double maiorValor = diasValidos.Max();
            double mediaMensal = diasValidos.Average();

            int diasAcimaMedia = diasValidos.Count(f => f > mediaMensal);

            Console.WriteLine($"Menor faturamento: {menorValor}");
            Console.WriteLine($"Maior faturamento: {maiorValor}");
            Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
        }
    }
}
