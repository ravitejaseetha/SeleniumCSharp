using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLogNet
{
    [Parallelizable(ParallelScope.Fixtures)]
    [TestFixture]
    public class Class1
    {
        private static log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        [TestFixtureSetUp]
        public void BeforeTest()
        {
            Console.WriteLine("Test Fixture Setup");
        }

        [Test]
        [Category("LogRollConsole")]
        public void LogExampleSample()
        {
            Logger.Debug("I am in LogExample method");
            Logger.Error("Log throws error");
            Logger.Fatal("Log Fatal");
        }



        [Test]
        [Category("LogRollConsole")]
        public void LogExampleSampleOne()
        {
            Logger.Debug("I am in LogExample method");
            Logger.Error("Log throws error");
            Logger.Fatal("Log Fatal");
        }


        [TestFixtureTearDown]

        public void AllTests()
        {
            Console.WriteLine("Test Fixture Tear down");
        }


        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
        }

        [TearDown]

        public void TearDown()
        {
            Console.WriteLine("Tear Down");
        }
    }
}
