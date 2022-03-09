using System.Xml.Serialization;

namespace Homework2
{
    public class Program
    {
        static void Main(string[] args)
        {
            exercise2();
            exercise3();
            exercise4();


            Console.ReadKey();

        }
        static void MessageReceived(string message)
        {
            Console.WriteLine(message);
        }

        static void exercise2()
        {
            Jedi belek = new Jedi();
            belek.Name = "Belek";
            belek.MidiChlorianCount = 10000;

            //serializing into the text file
            XmlSerializer serializer = new XmlSerializer(typeof(Jedi));
            FileStream stream = new FileStream("jedi.txt", FileMode.Create);
            serializer.Serialize(stream, belek);
            stream.Close();


            //reading back the serialized file
            XmlSerializer ser = new XmlSerializer(typeof(Jedi));
            FileStream fs = new FileStream("jedi.txt", FileMode.Open);
            Jedi belekClone = (Jedi)ser.Deserialize(fs);
            fs.Close();

            // Printing the clones name
            Console.WriteLine("Clones name " + belekClone.Name);

        }

        static void exercise3()
        {
            JediCouncil council = new JediCouncil();
            council.CouncilChanged += MessageReceived;
            // Add two members to the council
            Jedi jedi1 = new Jedi();
            jedi1.Name = "Yoda";
            jedi1.MidiChlorianCount = 15000;
            council.Add(jedi1);
            Jedi jedi2 = new Jedi();
            jedi2.Name = "Anakin Skywalker";
            jedi2.MidiChlorianCount = 20000;
            council.Add(jedi2);
            council.Remove();
            council.Remove();

        }


        static void exercise4()
        {
            // Initializing new jedi council
            JediCouncil jediCouncil = new JediCouncil();
            // Initializing new Jedis
            Jedi yoda = new Jedi();
            yoda.Name = "Yoda"; yoda.MidiChlorianCount = 20000;
            Jedi anakin = new Jedi();
            anakin.Name = "Anakin"; anakin.MidiChlorianCount = 50000;
            Jedi belek = new Jedi();
            belek.Name = "Belek"; belek.MidiChlorianCount = 15000;

            // adding jedis to the council
            jediCouncil.Add(belek); 
            jediCouncil.Add(yoda);
            jediCouncil.Add(anakin);

            // Initializing list of strongest members

            List<Jedi> strongestMembers = new List<Jedi>();

            // adding strongest members to the list from the council

            strongestMembers = jediCouncil.GetStrongestMembers();

            //Printing out their names (output should be Anakin and Yoda)

            foreach (Jedi strongestMember in strongestMembers)
            {
                Console.WriteLine(strongestMember.Name);
            }

        }
    }
}
