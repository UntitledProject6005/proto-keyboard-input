namespace ProtoKeyboardInput;

class Program
{
        static void Main(string[] args)
        {
                // https://stackoverflow.com/a/46939556/3875151
                ConsoleKey key;
                
                // While ConsoleKey is not Escape, print it out if its a spacebar
                do
                {
                        while (!Console.KeyAvailable)
                        { }

                        key = Console.ReadKey(true).Key;

                        if (key == ConsoleKey.Spacebar)
                        {
                                Console.WriteLine("  !");
                        }
                        Console.WriteLine(key);

                } while (key != ConsoleKey.Escape);

        }
}