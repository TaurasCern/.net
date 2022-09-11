using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Services;
using TowerOfHanoi.Domain.Interfaces;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi_Tests
{
    [TestClass]
    public class HelperService_Tests
    {
        [TestMethod]
        public void FindMoveCsv_StringHelpTip()
        {
            IGame fakeGame = new Game(DateTime.Now);
            HelperService fakeHelperService = new HelperService(fakeGame);
            var expected = "<pagalba> - paimkite diską iš pirmo stulpelio ir padėkite į trecia";

            fakeGame.PickUp(0);
            fakeGame.Place(1);

            fakeHelperService.FindMoveCsv(TestData.HelperService_Tests_InitialData.lines1);

            var actual = fakeHelperService.FormatHelpTip();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindMoveCsv_StringHelpTipNotFound()
        {
            IGame fakeGame = new Game(DateTime.Now);
            HelperService fakeHelperService = new HelperService(fakeGame);
            var expected = "Pagalba negalima";

            fakeGame.PickUp(0);
            fakeGame.Place(2);

            fakeHelperService.FindMoveCsv(TestData.HelperService_Tests_InitialData.lines1);

            var actual = fakeHelperService.FormatHelpTip();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GameState_LogGameState()
        {
            IGame fakeGame = new Game(DateTime.Now);
            HelperService fakeHelperService = new HelperService(fakeGame);
            var expected = new Log(fakeGame.GameStartDate, 2, 2, 3, 1, 1);

            fakeGame.PickUp(0);
            fakeGame.Place(1); 
            fakeGame.PickUp(0);
            fakeGame.Place(2);

            var actual = fakeHelperService.GameState();

            Assert.AreEqual(expected.GameStartTime, actual.GameStartTime);
            Assert.AreEqual(expected.Move, actual.Move);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindFilePriority_StringFileDirectories_DictionaryStringString()
        {
            IGame fakeGame = new Game(DateTime.Now);
            HelperService fakeStatistiscsService = new HelperService(fakeGame);

            var fakeFileDirs = new string[6]
            {               
                "E:\\App\\Logs\\filename1.txt",
                "E:\\App\\Logs\\filename1.csv",
                "E:\\App\\Logs\\filename1.html",
                "E:\\App\\Logs\\filename2.html",
                "E:\\App\\Logs\\filename2.csv",
                "E:\\App\\Logs\\filename3.html",
            };

            var expected = new Dictionary<string, string>()
            {
                { "filename1", "csv" },
                { "filename2", "csv" },
                { "filename3", "html" },
            };

            var actual = fakeStatistiscsService.FindFilePriority(fakeFileDirs);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindMoveCsv_BetterChoice_StringHelpTip()
        {
            IGame fakeGame = new Game(DateTime.Now);
            HelperService fakeHelperService = new HelperService(fakeGame);
            var expected = "<pagalba> - paimkite diską iš pirmo stulpelio ir padėkite į antra";

            fakeHelperService.FindMoveCsv(TestData.HelperService_Tests_InitialData.lines2);
            fakeHelperService.FindMoveCsv(TestData.HelperService_Tests_InitialData.lines1);          

            var actual = fakeHelperService.FormatHelpTip();

            Assert.AreEqual(expected, actual);
        }
    }
}
