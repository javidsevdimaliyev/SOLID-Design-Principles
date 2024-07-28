using Single_Responsibility_Principle;

namespace Single_Responsibility_Principle_IdealCode;
class Database
{
    public void Connect()
    {
        //...
        Console.WriteLine("Database connection is provided.");
    }
    public void Disconnect()
    {
        //...
        Console.WriteLine("The database is disconnected.");
    }
    public string State { get; set; }
}

class PersonService
{
    public List<Person> GetPersons()
    {
        return new() {
            new(){ Name = "Cavid", Surname = "Sevdimaliyev" },
            new(){ Name = "Parviz", Surname = "Aliyev" },
            new(){ Name = "Rashad", Surname = "Novruzlu" }
        };
    }
}

class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
}