using System.Text;

namespace Hangman_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckForError_Test()
        {
            var fakeGuessed = new List<string> { "a", "b" };
            var fakeWord = "Bananas";
            var fakeGuess = "a";
            var fakeIsNotLetter = false;
            var fakeIsGuessed = false;
            var fakeIsBadInput = false;

            var actual = Hangman.Program.CheckForError(fakeGuessed, fakeWord, fakeGuess, ref fakeIsNotLetter, ref fakeIsGuessed, ref fakeIsBadInput);
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void CheckForError_Test1()
        {
            var fakeGuessed = new List<string> { "b" };
            var fakeWord = "Bananas";
            var fakeGuess = "a";
            var fakeIsNotLetter = false;
            var fakeIsGuessed = false;
            var fakeIsBadInput = false;

            var actual = Hangman.Program.CheckForError(fakeGuessed, fakeWord, fakeGuess, ref fakeIsNotLetter, ref fakeIsGuessed, ref fakeIsBadInput);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void PickRandomString_Test()
        {
            var fakeWords = new string[] { "aaa", "bbb", "ccc" };
            var fakeRandom = new Random(1);

            var expected = fakeWords[fakeRandom.Next(0, fakeWords.Length)];

            var actual = Hangman.Program.PickRandomString(fakeWords, fakeRandom);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfWon_Test()
        {
            var fakeWord = "Bananas";
            var fakeWordField = "B_n_n_s";
            var fakeGuess = "Bananas";

            var actual = Hangman.Program.CheckIfWon(fakeWord, fakeWordField, fakeGuess);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfWon_Test1()
        {
            var fakeWord = "Bananas";
            var fakeWordField = "Bananas";
            var fakeGuess = "a";

            var actual = Hangman.Program.CheckIfWon(fakeWord, fakeWordField, fakeGuess);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfLost_Test()
        {
            var fakeWord = "Bananas";
            var fakeGuess = "a";
            var fakeFails = 7;

            var actual = Hangman.Program.CheckIfLost(fakeWord, fakeGuess, fakeFails);
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void CheckIfLost_Test1()
        {
            var fakeWord = "Bananas";
            var fakeGuess = "Bananas";
            var fakeFails = 5;

            var actual = Hangman.Program.CheckIfLost(fakeWord, fakeGuess, fakeFails);
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void CheckIfLost_Test2()
        {
            var fakeWord = "Bananas";
            var fakeGuess = "Obuolys";
            var fakeFails = 5;

            var actual = Hangman.Program.CheckIfLost(fakeWord, fakeGuess, fakeFails);
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Guess_Test()
        {
            var fakeWordField = new StringBuilder("Banana_");
            var fakeWord = "Bananas";
            var fakeGuess = "s";
            var fakeFails = 4;
            List<string> fakeGuessed = new List<string>();

            var expected = "Bananas";

            var actual = Hangman.Program.Guess(fakeWordField, fakeWord, ref fakeFails, fakeGuess, fakeGuessed);
            Assert.AreEqual(expected, actual.ToString());
        }
        [TestMethod]
        public void Guess_Test1()
        {
            var fakeWordField = new StringBuilder("Banana_");
            var fakeWord = "Bananas";
            var fakeGuess = "g";
            var fakeFails = 4;
            List<string> fakeGuessed = new List<string>();

            var expected = 5;

            Hangman.Program.Guess(fakeWordField, fakeWord, ref fakeFails, fakeGuess, fakeGuessed);
            Assert.AreEqual(expected, fakeFails);
        }
        [TestMethod]
        public void Guess_Test2()
        {
            var fakeWordField = new StringBuilder("Banana_");
            var fakeWord = "Bananas";
            var fakeGuess = "g";
            var fakeFails = 4;
            List<string> fakeGuessed = new List<string>();

            var expected = new List<string> { "g" };

            Hangman.Program.Guess(fakeWordField, fakeWord, ref fakeFails, fakeGuess, fakeGuessed);
            CollectionAssert.AreEqual(expected, fakeGuessed);
        }
        [TestMethod]
        public void ArrayRemove_Test1()
        {
            var fakeWords = new string[] { "Bananas", "Obuolys", "Ananasas", "Arklys" };
            var fakeWord = "Bananas";

            var expected = new string[] { "Obuolys", "Ananasas", "Arklys" };

            var actual = Hangman.Program.ArrayRemove(fakeWords, fakeWord);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
