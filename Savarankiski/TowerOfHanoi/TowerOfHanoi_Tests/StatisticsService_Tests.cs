using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Services;
using TowerOfHanoi.Domain.Interfaces;

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
    }
}
