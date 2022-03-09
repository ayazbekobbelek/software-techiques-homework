using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework2
{
    [XmlRoot("My Jedi")]
    public class Jedi
    {
        private string name;
        private int midiChlorianCount;
        

        [XmlAttribute("name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        [XmlAttribute("midiChlorianCount")]
        public int MidiChlorianCount { 
            get { return midiChlorianCount; } 
            set
            {
              
                if (value < 0)
                {
                    throw new ArgumentException("You are not a true Jedi!");
                }
                midiChlorianCount = value;
            }
        }


    }
}
