using System.Text.RegularExpressions;

namespace InputDelegate.Library
{
    public class ConsoleParser
    {
        public delegate void ParserDelegate();

        ParserDelegate onNumber;
        ParserDelegate onWord;
        ParserDelegate onJunk;

        public ConsoleParser(ParserDelegate onNumber, ParserDelegate onWord, ParserDelegate onJunk) { 
            this.onNumber = onNumber;
            this.onWord = onWord;
            this.onJunk = onJunk;
        }

        public void processLine(string line)
        {
            bool isOnlyNumber = Regex.IsMatch(line, @"^\d+$");
            bool isWord = Regex.IsMatch(line, @"^[A-Za-z0-9]+$");

            if (isOnlyNumber)
            {
                onNumber();
            }
            else if (isWord)
            {
                onWord();
            }
            else
            {
                onJunk();
            }
        }
        // public void run(ParserDelegate onWord, ParserDelegate onNumber, ParserDelegate onJunk) earlier method 
        public void run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    processLine(input);

                } catch (IOException e)
                {
                    //Console.WriteLine("io exception");
                } catch (OutOfMemoryException e)
                {
                    //Console.WriteLine("OutOfMemoryException exception");
                } catch (ArgumentOutOfRangeException e)
                {
                    //Console.WriteLine("ArgumentOutOfRangeException exception");
                } catch (ArgumentNullException)
                {
                    //Console.WriteLine("NullReferenceException exception");
                }

            }
        }
    }
}