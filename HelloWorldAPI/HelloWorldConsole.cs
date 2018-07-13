using System;

namespace HelloWorldAPI
{
    internal class HelloWorldConsole : IHelloWorld
    {
        public string logTo 
        {
            get;set;
        }

        /// <summary>
        /// Get message
        /// </summary>
        /// <returns></returns>
        public string getMessage()
        {
            return HelloWorldConstants.ConsoleResponse;
        }

        /// <summary>
        /// Write a message
        /// </summary>
        /// <param name="value"></param>
        public void writeMessage(string value)
        {
            throw new NotImplementedException();
        }
    }
}