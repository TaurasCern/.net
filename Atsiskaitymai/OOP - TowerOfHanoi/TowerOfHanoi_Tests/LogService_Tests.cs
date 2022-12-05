using TowerOfHanoi.Domain.Services;
using TowerOfHanoi.Domain.Interfaces;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi_Tests
{
    [TestClass]
    public class LogService_Tests
    {
        [TestMethod]
        public void FormatCsvLog_Game_StringCsvLog()
        {
            DateTime fakeTime = DateTime.Now;
            IGame fakeGame = new Game(fakeTime);
            ILogable fakeLogService = new LogService(fakeGame, fakeTime);

            var expected = $"{fakeTime},0,1,1,1,1";

            var actual = fakeLogService.FormatCsvLog();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FormatHtmlLog_Game_StringHtmlLog()
        {
            DateTime fakeTime = DateTime.Now;
            IGame fakeGame = new Game(fakeTime);
            ILogable fakeLogService = new LogService(fakeGame, fakeTime);

            var expected = $"<tr>{Environment.NewLine}" +
                $"<td>{fakeTime}</td>{Environment.NewLine}" +
                $"<td>0</td>{Environment.NewLine}" +
                $"<td>1</td>{Environment.NewLine}" +
                $"<td>1</td>{Environment.NewLine}" +
                $"<td>1</td>{Environment.NewLine}" +
                $"<td>1</td>{Environment.NewLine}" +
                $"</tr>";

            var actual = fakeLogService.FormatHtmlLog();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FormatTxtLog_Game_StringTxtLog()
        {
            DateTime fakeTime = DateTime.Now;
            IGame fakeGame = new Game(fakeTime);
            ILogable fakeLogService = new LogService(fakeGame, fakeTime);

            fakeGame.PickUp(0);
            fakeGame.Place(1);

            var expected = String.Format($"žaidime kuris pradėtas {fakeTime}, ėjimu nr 1" +
                $", 1 " +
                $"dalies diskas buvo paimtas iš pirmo " +
                $"ir padėtas į antra");

            var actual = fakeLogService.FormatTxtLog();

            Assert.AreEqual(expected, actual);
        }


    }
}