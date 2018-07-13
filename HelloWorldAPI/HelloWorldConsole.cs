using System;

namespace HelloWorldAPI
{
    internal class HelloWorldConsole : IHelloWorld
    {
        public string logTo 
        {
            get;set;
        }

        public string getMessage()
        {
            return "Hello World!  This is console.  Is there anybody out there?";
        }

        public void writeMessage(string value)
        {
            throw new NotImplementedException();
        }
    }
}