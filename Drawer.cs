namespace HtmlEditor
{
    public class Drawer
    {
        public static void DrawScreen()
        {
            DrawDashedLine(30);
            DrawVerticalContent(10, 30);
            DrawDashedLine(30);
        }
        private static void DrawDashedLine(int lineLength)
        {
            Console.Write("+");
            for (int i = 0; i <= lineLength; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        private static void DrawVerticalContent(int lineQuantity, int columnSize)
        {
            for (int lines = 0; lines <= lineQuantity; lines++)
            {
                Console.Write("|");
                for (int columns = 0; columns <= columnSize; columns++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}