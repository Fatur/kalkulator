using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class PenjumlahanTest
    {
        private Kalkulator kalkulator;
        [TestInitialize]
        public void Init(){
            kalkulator=new Kalkulator();
        }
        [TestMethod]
        public void Test_lima_ditambah_lima()
        {
            kalkulator.Input(5);
            kalkulator.Tambah();
            kalkulator.Input(5);
            Assert.AreEqual(10,kalkulator.Output());
        }
        [TestMethod]
        public void Test_lima_ditambah_enam()
        {
            kalkulator.Input(5);
            kalkulator.Tambah();
            kalkulator.Input(6);
            Assert.AreEqual(11,kalkulator.Output());
        }
        [TestMethod]
        public void Test_lima_ditambah_enam_ditambah_lima()
        {
            kalkulator.Input(5);
            kalkulator.Tambah();
            kalkulator.Input(6);
            kalkulator.Tambah();
            kalkulator.Input(5);
            Assert.AreEqual(16,kalkulator.Output());
        }
        [TestMethod]
        public void Test_reset_kalkulator()
        {
            kalkulator.Input(5);
            kalkulator.Tambah();
            kalkulator.Input(6);
            kalkulator.Tambah();
            kalkulator.Input(5);
            kalkulator.Reset();
            Assert.AreEqual(0,kalkulator.Output());
        }
    }
}
