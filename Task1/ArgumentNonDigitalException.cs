using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ArgumentNonDigitalException : ArgumentException
    {
        public ArgumentNonDigitalException(string _exceptionMessage) : base(_exceptionMessage)
        { }
    }
}
