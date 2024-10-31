using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"A Soma entre {x} e {y} é {x + y}");
        }

        
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"A Subtração entre {x} e {y} é {x - y}");
        }

        
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"A Multiplicação entre {x} e {y} é {x * y}");
        }

        
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"A Divisão entre {x} e {y} é {x / y}");
        }

        public void Potenciar(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"A Potenciação de expoente {y} na base {x} é  {potencia}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O Seno de {angulo} é {seno}");
        }

    }
}