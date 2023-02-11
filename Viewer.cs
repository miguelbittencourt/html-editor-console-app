using System.Text.RegularExpressions;

namespace HtmlEditor
{
    public class Viewer
    {
        public static void Show(string text) {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------------");
            Replace(text);
            Console.Write("\n");
            Console.WriteLine("-----------------");
            Console.WriteLine("Aperte enter para sair do modo visualização.");
            Console.ReadKey();
            Console.Clear();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var words = text.Split(' ');
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var title = new Regex(@"<\s*h1[^>]*>(.*?)<\s*/\s*h1>");

            for(var i = 0; i < words.Length; i++)
            {
                if(strong.IsMatch(words[i]))
                    WriteStrong(words[i]);
                else if(title.IsMatch(words[i]))
                    WriteTitle(words[i]);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
            
        }

        public static void WriteStrong(string word)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(
                    word.Substring(
                        word.IndexOf('>') + 1,
                        (
                            (word.LastIndexOf('<') - 1) - word.IndexOf('>')
                        )
                    )
                );
            Console.Write(" ");
        }
    
        public static void WriteTitle(string word)
        {
            Console.Write(
                    word.Substring(
                        word.IndexOf('>') + 1,
                        (
                            (word.LastIndexOf('<') - 1) - word.IndexOf('>')
                        )
                    ).ToUpper()
                );
            Console.Write(" ");
        }
    }
}