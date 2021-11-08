using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumericalAddition_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
     
            
           var output = RomanNumericalAddition.Program.AddNumerical(new string[] {"X", "X" , "L"});
            Assert.AreEqual("LXX", output);
        }
    }
}
