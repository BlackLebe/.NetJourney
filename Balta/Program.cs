using System;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2 + 9;
            // var texto = "O Preço do produto é: " + price + "apenas na promoção";
            var texto = string.Format("O Preço do produto é: {0} apenas na promoção", price);
            Console.WriteLine(texto);
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