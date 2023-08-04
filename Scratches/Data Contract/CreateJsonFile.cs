using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace PersonClass;

public class JsonTryAdd
{
    List<Person> people = new();

	public void AddMember()
	{
        people.Add(new Person("John", 123));
        people.Add(new Person("Type", 444));
	}
	public void Trial()
	{
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