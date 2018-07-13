using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelloWorldAPI.HelloWorldConstants;

namespace HelloWorldAPI
{
    public class HelloWorldFactory : HelloWorldAbstractFactory
    {
        public override IHelloWorld CreateInstance(HelloWorldTypes clientType, string logTo)
        {

            switch (clientType)
            {
                case HelloWorldTypes.Console:
                    return new HelloWorldConsole() { logTo = logTo };
                case HelloWorldTypes.Mobile:
                    throw new ApplicationException(string.Format("Client '{0}' cannot be created", clientType.ToString()));
                case HelloWorldTypes.Web:
                    throw new ApplicationException(string.Format("Client '{0}' cannot be created", clientType.ToString()));
                case HelloWorldTypes.WebService:
                    throw new ApplicationException(string.Format("Client '{0}' cannot be created", clientType.ToString()));

                default:
                    throw new ApplicationException(string.Format("Client type is unknown"));
            }
        }
    }
}
