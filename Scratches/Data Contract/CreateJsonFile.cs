using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace PersonClass;

public class JsonTryAdd
{
	public void Trial()
	{
		var p = new Person("John", 123);
        var p2 = new Person("Yusuf", 444);
        List<Person> people = new();
        people.Add(p);
        people.Add(p2);

        var ser = new DataContractJsonSerializer(typeof(List<Person>));
        using (FileStream stream = new FileStream("person.json", FileMode.OpenOrCreate))
        {
            ser.WriteObject(stream, people);
        }

//         List<Person> importPerson;
//         using (FileStream stream2 = new FileStream("person.json", FileMode.OpenOrCreate))
//         {
//             importPerson = (List<Person>)ser?.ReadObject(stream2);
//         }

//         foreach (var person in importPerson)
//         {
//             Console.WriteLine(person.GetName());
//         }
	}
}