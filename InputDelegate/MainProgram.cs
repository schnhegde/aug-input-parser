using InputDelegate.Library;

namespace InputDelegate
{
    public class MainProgram
    {

        public static void Main()
        {
            var program = new MainProgram();
            var parser = new ConsoleParser(program.onNumber, program.onWord, program.onJunk);
            parser.run();
        }
        
        private void onWord()
        {
            Console.WriteLine("OnWord");
        }

        private void onNumber()
        {
            Console.WriteLine("OnNumber");
        }

        private void onJunk()
        {
            Console.WriteLine("OnJunk");
        }
    }
}