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
    public class StatisticsService_Tests
    {
        [TestMethod]
        public void FindFilePriority_StringFileDirectories_DictionaryStringString()
        {
            IStatistics fakeStatistiscsService = new StatisticsService();

            var fakeFileDirs = new string[6]
            {
                "E:\\App\\Logs\\filename1.csv",
                "E:\\App\\Logs\\filename1.txt",
                "E:\\App\\Logs\\filename1.html",
                "E:\\App\\Logs\\filename2.html",
                "E:\\App\\Logs\\filename2.csv",
                "E:\\App\\Logs\\filename3.csv",
            };

            var expected = new Dictionary<string, string>()
            {
                { "filename1", "txt" },
                { "filename2", "html" },
                { "filename3", "csv" },
            };

            var actual = fakeStatistiscsService.FindFilePriority(fakeFileDirs);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AppendLog_StringBuilderAndLog_StringBuilderWithAppendedLog()
        {
            StatisticsService fakeStatistiscsService = new StatisticsService();
            Log fakeLog1 = new Log(DateTime.Now, 15,3,3,3,3);
            Log fakeLog2 = new Log(DateTime.Now.AddMinutes(1), 18,3,3,3,3);

            var expected1 = String.Format("| {0,-21} | {1,-26} | {2,-7} |{3}", fakeLog1.GameStartTime, fakeLog1.Move, "N/G", Environment.NewLine);
            expected1 += $"----------------------------------------------------------------{Environment.NewLine}";
            var expected2 = expected1 + String.Format("| {0,-21} | {1,-26} | {2,-7} |{3}", fakeLog2.GameStartTime, fakeLog2.Move - 15, 3, Environment.NewLine);
            expected2 += $"----------------------------------------------------------------{Environment.NewLine}";


            var actual1 = fakeStatistiscsService.AppendLog(new StringBuilder(), fakeLog1).ToString();
            fakeStatistiscsService.IsUntilWin = false;
            var actual2 = actual1 + fakeStatistiscsService.AppendLog(new StringBuilder(), fakeLog2).ToString();

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
