﻿using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.25m;
            var culture = valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")); // existem várias formas de se formatar, mas o mais utilizado seria o C de Currency 
                                                                                           // que mostra já considerando a moeda com o Culture, tipo real ou dolar.
            Console.WriteLine(culture.ToString());
            // pode fazer assim tbm, direto no caso
            // Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));













            // var data = new DateTime(2020, 10, 12, 8, 23, 14);
            // Console.WriteLine(data);
            // Console.WriteLine(data.Year);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.Day);
            // Console.WriteLine(data.Hour);
            // Console.WriteLine(data.Minute);
            // Console.WriteLine(data.Second);
            // Console.WriteLine(data.DayOfWeek);
            // var data = DateTime.Now;

            // y = ano, M = Mês, d = dia, m = minuto, H = hora, s = Segundo
            // var formatada = String.Format("{0:dd/MM/yyyy} às {0:H:mm} na timezone de {0:zz}", data);
            // Console.WriteLine(formatada);

            // var dia = data.AddDays(7);

            // Console.WriteLine(data);
            // Console.WriteLine(dia);



            // var price = 10.2 + 9;
            // // var texto = "O Preço do produto é: " + price + "apenas na promoção";
            // var texto = string.Format("O Preço do produto é: {0} apenas na promoção", price);
            // Console.WriteLine(texto);
            // var id = Guid.NewGuid();
            // id.ToString();

            // id = new Guid("6332bed8-f7fe-48c9-9353-af8b74031a49");
            // Console.WriteLine(id);

            // Product monitor = new Product(000034, "Monitor", 1300, EproductType.Product);
            // Console.WriteLine(monitor.Name);
            // Console.WriteLine(monitor.Price);

            // monitor.Atributos();

            // Console.WriteLine(monitor.PriceInDolar(5.785));

            // int x = 25;
            // int y = x;
            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // x = 32;
            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // var arr = new string[2];
            // arr[0] = "item 1";

            // var arr2 = arr;

            // Console.WriteLine(arr[0]);
            // Console.WriteLine(arr2[0]);

            // arr[0] = "item 2";
            // Console.WriteLine(arr[0]);
            // Console.WriteLine(arr2[0]);

            // Console.WriteLine("Escreva algo, qualquer coisa");
            // var texto = Console.ReadLine();
            // Console.WriteLine(texto);
        }
    }

    struct Product
    {

        public int Id;
        public string Name;
        public double Price;
        public EproductType Type;

        public Product(int id, string name, double price, EproductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }

        public void Atributos()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Price);
            Console.WriteLine(Type);
            Console.WriteLine(Id);
        }

    }

    enum EproductType
    {
        Product = 1,
        Service = 2
    }
}