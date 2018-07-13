using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelloWorldAPI.HelloWorldConstants;

namespace HelloWorldAPI
{

    public abstract class HelloWorldAbstractFactory
    {
        public abstract IHelloWorld CreateInstance(HelloWorldTypes clientType, string logTo);
    }

}
