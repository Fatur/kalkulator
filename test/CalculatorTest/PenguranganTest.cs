using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class PenguranganTest
    {
        private Kalkulator kalkulator;
        [TestInitialize]
        public void Init(){
            kalkulator=new Kalkulator();
        }
        [TestMethod]
        public void Test_sepuluh_dikurang_lima(){
            kalkulator.Input(10);
            kalkulator.Kurang();
            kalkulator.Input(5);
            Assert.AreEqual(5,kalkulator.Output());
        }
        [TestMethod]
        public void Test_sepuluh_dikurang_lima_kurang_tiga(){
           
            kalkulator.Input(10);
            kalkulator.Kurang();
            kalkulator.Input(5);
            kalkulator.Kurang();
            kalkulator.Input(3);
            Assert.AreEqual(2,kalkulator.Output());
        }

        [TestMethod]
        public void Test_sepuluh_ditambah_lima_kurang_tiga(){
           
            kalkulator.Input(10);
            kalkulator.Tambah();
            kalkulator.Input(5);
            kalkulator.Kurang();
            kalkulator.Input(3);
            Assert.AreEqual(12,kalkulator.Output());
        }
    }
}