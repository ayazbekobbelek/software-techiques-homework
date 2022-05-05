using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signals
{
    class SignalDocument: Document
    {
        List<SignalValue> signalValues = new List<SignalValue>();

        private SignalValue[] testValues = new SignalValue[]
        {
            new SignalValue(10, new DateTime(2015, 1, 1, 0, 0, 0, 111)),
            new SignalValue(20, new DateTime(2015, 1, 1, 0, 0, 1, 876)),
            new SignalValue(30, new DateTime(2015, 1, 1, 0, 0, 2, 300)),
            new SignalValue(10, new DateTime(2015, 1, 1, 0, 0, 3, 232)),
            new SignalValue(-10, new DateTime(2015, 1, 1, 0, 0, 5, 885)),
            new SignalValue(-19, new DateTime(2015, 1, 1, 0, 0, 6, 125))
        };


        public IReadOnlyList<SignalValue> SignalValues
        {
            get { return signalValues; }
        }




        public SignalDocument(string name) : base(name)
        {
            signalValues.AddRange(testValues);
        }

        public override void SaveDocument(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (SignalValue signalValue in signalValues)
                {
                    string dt = signalValue.TimeStamp.ToUniversalTime().ToString("o");
                    sw.WriteLine(signalValue.Value + "\t" + dt);
                }
            }

        }

        public override void LoadDocument(string filePath)
        {
            using (StreamReader sw = new StreamReader(filePath))
            {
                string line;
                while((line = sw.ReadLine()) != null)
                {
                    line = line.Trim();
                    string[] colums = line.Split('\t');
                    double d = double.Parse(colums[0]);
                    DateTime dt = DateTime.Parse(colums[1]);
                    DateTime localDt = dt.ToLocalTime();

                    SignalValue signalValue = new SignalValue(d, localDt);

                    signalValues.Add(signalValue);

                }
            }
            TraceValues();
            UpdateAllViews();
        }

        void TraceValues()
        {
            foreach(SignalValue signalValue in signalValues)
            {
                Trace.WriteLine(signalValue.ToString());
            }
        }
    }
}
