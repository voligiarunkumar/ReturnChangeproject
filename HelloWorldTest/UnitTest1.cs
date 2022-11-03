using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using HelloWorld1;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld1.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
            Program obj = new Program();
           int result1= obj.add(1, 2);
            Assert.AreEqual(result1, 3);
        }
    }
}
