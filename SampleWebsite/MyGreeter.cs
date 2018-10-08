using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebsite
{
    public class MyGreeter : IGreeter
    {
        public string GetMessageOfTheDay()
        {
            return "Message from MyGreeter";
        }

        public string HelloWorld()
        {
            return "Hello MyGreeter";
        }
    }
}
