namespace DNRtests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DNRNormalization_Test1()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var actual = DNRgrandine.Program.NormalizeDNR(txt);
            var expected = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDNRValid_Test1()
        {
            var txt = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = DNRgrandine.Program.IsDNRValid(txt);
            var expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDNRValid_Test2()
        {
            var txt = "TCG-TAC-GAZ-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = DNRgrandine.Program.IsDNRValid(txt);
            var expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DoesDNRContainCAT_Test1()
        {
            var txt = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = DNRgrandine.Program.DoesDNRContainCAT(txt);
            var expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DoesDNRContainCAT_Test2()
        {
            var txt = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-AGA-GCT";
            var actual = DNRgrandine.Program.DoesDNRContainCAT(txt);
            var expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Get3rdAnd5thSegment_Test1()
        {
            var txt = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-AGA-GCT";
            var actual = DNRgrandine.Program.Get3rdAnd5thSegment(txt);
            var expected = "GAC-CGT";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindDNRCount_Test1()
        {
            var txt = "TcG-TAC-  GAC-TAC-CGT-CAG-  ACT-TAA-CCA-GTC-AGA-  GCT";
            var actual = DNRgrandine.Program.FindDNRCount(txt, "TAC");
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddSegment_Test1()
        {
            var txt = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-AGA-GCT";
            var actual = DNRgrandine.Program.AddSegment(txt, "TAC");
            var expected = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-AGA-GCT-TAC";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReplaceSegment_Test1()
        {
            var txt = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-AGA-GCT";
            var actual = DNRgrandine.Program.ReplaceSegment(txt, "TAC", "CCA");
            var expected = "TCG-CCA-GAC-CCA-CGT-CAG-ACT-TAA-CCA-GTC-AGA-GCT";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveSpecifiedSegment_Test1()
        {
            var txt = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-AGA-GCT";
            var actual = DNRgrandine.Program.RemoveSpecifiedSegment(txt, "TAC");
            var expected = "TCG-GAC-CGT-CAG-ACT-TAA-CCA-GTC-AGA-GCT";
            Assert.AreEqual(expected, actual);
        }
    }
}