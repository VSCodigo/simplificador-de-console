namespace RecebedoresDeEntrada
{    
    public static class Recebedor
    {
        public static int ReceberInt()
        {            
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int entradaInt))
                {
                    return entradaInt;
                }

                int linhaDestino = Console.CursorTop - 1;

                Console.SetCursorPosition(0, linhaDestino);
                Console.Write(new string(' ', Console.WindowWidth));

                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("Tá nem ai pras regras, né gostoso? Escreva apenas números inteiros.");
                Thread.Sleep(1200);

                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);
            }            
        }
    }
}

