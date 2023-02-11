using System.IO;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Drawer.DrawScreen();
            Writer.WriteOptions();

            string option = Console.ReadLine() ?? "";

            try{
                HandleMenuOption(short.Parse(option));
            }
            catch(FormatException ex){
                Console.WriteLine(ex.Message);
                Console.WriteLine("A opção inserida é nula, insira uma opção valida");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Algo deu errado");
            }
            finally
            {
                Console.ReadKey();
                Console.Clear();
                Show();
            }
            
        }
        public static void HandleMenuOption(short? option)
        {
            switch(option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}