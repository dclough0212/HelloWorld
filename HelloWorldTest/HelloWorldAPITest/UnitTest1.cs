using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI;
using static HelloWorldAPI.HelloWorldConstants;

namespace HelloWorldAPITest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConsole()
        {
            var fac = new HelloWorldFactory();

            var hello = fac.CreateInstance(HelloWorldConstants.HelloWorldTypes.Console, "database");
            var response = hello.getMessage();

            Assert.IsNotNull(response, "API returned null from API");
            Assert.IsTrue(response == HelloWorldConstants.ConsoleResponse, "Helloworld API did not return valid response for console");
        }

        [TestMethod]
        public void TestWebService()
        {
            var fac = new HelloWorldFactory();

            try
            {
                var hello = fac.CreateInstance(HelloWorldTypes.WebService, "database");
                Assert.Fail("WebService exception not thrown");
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Client 'WebService' cannot be created");
            }

        }

        [TestMethod]
        public void WriteMessage_NotImplemented()
        {

            HelloWorldFactory fac = new HelloWorldFactory();
            IHelloWorld hwAPI = fac.CreateInstance(HelloWorldTypes.Console, "test");

            try {

                hwAPI.writeMessage("test");
            }
            catch (NotImplementedException e)
            {
                Assert.IsTrue(e.Message == "The method or operation is not implemented.");
            }
        }
    }
}
