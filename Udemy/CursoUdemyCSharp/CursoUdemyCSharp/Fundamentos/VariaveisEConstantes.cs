using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemyCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415; - não dá pra mudar o valor da constante

            double area = PI * (raio * raio);
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos (built in)

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine(saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine(salario);

            int menorValorInt = int.MinValue; // mais usado dos inteiros!
            Console.WriteLine(menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine(populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine(menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine(populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine(precoComputador);
        } 
    }
}
