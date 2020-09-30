using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.IO;

namespace MySampleCodeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {

            string[] str = new string[0];

            MySampleCode.Program.CreateHostBuilder(str);

            Assert.Pass();
           
        }
    }
}