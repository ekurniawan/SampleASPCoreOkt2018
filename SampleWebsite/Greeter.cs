using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebsite
{
    public class Greeter : IGreeter
    {
        public string GetMessageOfTheDay()
        {
            return "Hello from Greeter Class";
        }
    }
}
