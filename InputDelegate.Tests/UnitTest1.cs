using InputDelegate.Library;
using System.Text;

namespace InputDelegate.Tests
{
    public class UnitTest1
    {

        private void testParser(bool shouldBeNumber, bool shouldBeWord, bool shouldBeJunk, string line)
        {
            var parser = new ConsoleParser(() =>
            {
                // on number
                Assert.True(shouldBeNumber);
            }, () =>
            {
                // on word
                Assert.True(shouldBeWord);
            }, () =>
            {
                // on junk
                Assert.True(shouldBeJunk);
            });
            parser.processLine(line);
        }

        [Fact]
        public void DoesNumberCallOnNumber()
        {
            testParser(true, false, false, "121");
        }
        [Fact]

        public void DoesNumberAndAlphaCallOnWord()
        {
            testParser(false, true, false, "121abc");
        }
        [Fact]

        public void DoesEmptyCallOnJunk()
        {
            testParser(false, false, true, "");
        }
        [Fact]

        public void DoesSpecialCharsCallOnJunk()
        {
            testParser(false, false, true, ".*#");
        }
        [Fact]

        public void DoesAlphaCallOnWord()
        {
            testParser(false, true, false, "hello");
        }
    }
}