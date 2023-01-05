using InputDelegate.Library;

namespace InputDelegate
{
    public class MainProgram
    {

        public static void Main()
        {
            var parser = new ConsoleParser(onNumber, onWord, onJunk);
            parser.run();
        }
        
        private static void onWord()
        {
            Console.WriteLine("OnWord");
        }

        private static void onNumber()
        {
            Console.WriteLine("OnNumber");
        }

        private static void onJunk()
        {
            Console.WriteLine("OnJunk");
        }
    }
}