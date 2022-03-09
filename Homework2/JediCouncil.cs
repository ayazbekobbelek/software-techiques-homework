using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class JediCouncil
    {
        public delegate void CouncilChangeNotification(string message);
        public event CouncilChangeNotification CouncilChanged;
        List<Jedi> members = new List<Jedi>();
        public void Add(Jedi newJedi)
        {
            members.Add(newJedi);
            if (CouncilChanged != null)
                CouncilChanged("A new member was added to the council."); 
        }
        public void Remove()
        {
     
            members.RemoveAt(0);
            if (CouncilChanged != null)
            {
                if (members.Count > 0)
                    CouncilChanged("I sense a disturbance in the Force.");
                else
                    CouncilChanged("The council is over!");
            }
        }

        public List<Jedi> GetStrongestMembers()
        {
            return members = members.FindAll(member => member.MidiChlorianCount > 17000);
        }



    }
}
