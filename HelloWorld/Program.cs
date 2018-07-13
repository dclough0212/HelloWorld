using HelloWorldAPI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelloWorldAPI.HelloWorldConstants;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            var logDir = ConfigurationManager.AppSettings["LogTo"].ToString();

            HelloWorldFactory hwFac = new HelloWorldFactory();
            IHelloWorld hwAPI = hwFac.CreateInstance(HelloWorldTypes.Console, logDir);

            Console.Write(hwAPI.getMessage());

            Console.ReadKey();
        }
    }
}
