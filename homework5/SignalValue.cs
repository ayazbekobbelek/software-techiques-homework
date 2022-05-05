using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signals
{
    internal class SignalValue
    {
        public readonly double Value;
        public readonly DateTime TimeStamp;

        public SignalValue(double value, DateTime timeStamp)
        {
            this.Value = value;
            this.TimeStamp = timeStamp;  
        }

        public override string ToString()
        {
            return String.Format("Value: {0}, Timestamp: {1}", Value, TimeStamp);
        }
    }
}
