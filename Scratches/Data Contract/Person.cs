using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace PersonClass;

[DataContract]
public class Person
{
    [DataMember]
    private string name;

    [DataMember]
    internal int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string GetName()
    {
        return name;
    }
}