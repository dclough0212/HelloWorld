using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI
{
    public interface IHelloWorld
    {
        /// <summary>
        /// Location to log to
        /// </summary>
        string logTo { get; set; }

        /// <summary>
        /// Get message from API
        /// </summary>
        /// <returns></returns>
        string getMessage();

        /// <summary>
        /// Write message to API
        /// </summary>
        /// <param name="value"></param>
        void writeMessage(string value);

    }
}
