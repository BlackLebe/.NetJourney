using System;
using System.Runtime.Intrinsics;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string operacao = Menu();

                switch (operacao)
                {
                    case "+":
                        Soma();
                        break;

                    case "-":
                        Subtracao();
                        break;

                    case "/":
                        Divisao();
                        break;

                    case "*":
                        Multiplicacao();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Deseja Continuar? [S/N] ");
                string parar = Console.ReadLine();
                if (parar == "N")
                {
                    break;
                }
            }
        }

        static string Menu()
        {
            Console.Clear();
            Console.WriteLine(@"Bem Vindo! Digite o tipo de operação que você deseja realizar
            + para soma
            - para subtração
            * para multiplicação
            / para divisão");
            string? operation = Console.ReadLine();
            return operation;
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Por favor, digite o primeiro valor");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite o segundo valor");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float Soma = n1 + n2;
            Console.WriteLine($"O Resultado da soma é: {Soma}");
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Por favor, digite o primeiro valor");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite o segundo valor");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float subtracao = n1 - n2;
            Console.WriteLine($"O Resultado da soma é: {Subtracao}");
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Por favor, digite o primeiro valor");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite o segundo valor");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float divisao = n1 / n2;
            Console.WriteLine($"O Resultado da soma é: {divisao}");
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Por favor, digite o primeiro valor");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite o segundo valor");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float multiplicacao = n1 * n2;
            Console.WriteLine($"O Resultado da soma é: {multiplicacao}");
        }
    }
}