using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

{

}

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]

        public void Serialize(List<Order> orders, string chosenFileName)
        {
            chosenFileName = "Report";
            var actual = @"C:\Users\romka\Documents\vigi15\Output for C#\Report.txt";
            var expected = @$"C:\Users\romka\Documents\vigi15\Output for C#\{chosenFileName}.txt";

            Assert.AreEqual(expected, actual);
        }
    }
}
