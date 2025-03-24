using System;
using System.Text;

namespace BaltaEditorHtml
{
    public static class editor
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("--------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("---------------");
            Console.WriteLine(" Deseja Salvar o arquivo?[S/N] ");
            char choice = Convert.ToChar(Console.ReadLine());
            if (char.ToUpper(choice) == 'S')
            {
                Salvando(file);
            }
            else if (char.ToUpper(choice) == 'N')
            {
                Viewer.Show(file.ToString());
            }
            else
            {
                Menu.Show();
            }
        }

        static void Salvando(StringBuilder text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo??");
            var path = Console.ReadLine();

            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(text);
            }

            Console.WriteLine($"Arquivo {path}salvo com sucesso!");
            Console.ReadLine();
            Menu.Show();
        }
    }
}