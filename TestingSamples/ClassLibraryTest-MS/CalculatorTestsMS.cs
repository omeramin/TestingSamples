using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryUnitTest_MS
{
    [TestClass]
    public class CalculatorTestsMS
    {

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(12, 30, 42)]
        [DataRow(14, 1, 15)]
        [TestMethod]
        public void Add_Test(int A, int B, int Expected)
        {
                       

            int result = Calculator.Add(A, B);

            Assert.AreEqual(Expected, result);            

        }

        [TestMethod]
        public void Subtract_Test()
        {
            int result = Calculator.Divide(10, 3);
            Assert.AreEqual(70, result);
        }

        [TestMethod]
        public void Divide_Test()
        {
            int result = Calculator.Divide(10, 3);
            Assert.AreEqual(3, 3.33);
        }
    }
}
