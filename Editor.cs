using System.Text;
using System.IO;

namespace HtmlEditor
{
    public static class Editor
    {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------------");
            Start();
        }

        public static void Start() {
            Console.WriteLine("Escreva o texto em html\nQuando concluir o texto pressione enter e esc para sair do modo edição.");
            var text = new StringBuilder();

            do{
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
            } while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Viewer.Show(text.ToString());
        }
    }
}