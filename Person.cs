using System;

class Person
{

private string name;
private int age;
private string address;


public Person(string name, int age, string address)
{
this.name = name;
this.age = age;
this.address = address;
}


public string Name
{
get { return name; }
set { name = value; }
}

public int Age
{
get { return age; }
set
{
if (value >= 0) // Adding basic validation for age
age = value;
else
throw new ArgumentException("Age cannot be negative.");
}
}

public string Address
{
get { return address; }
set { address = value; }
}
}


class Program
{
static void Main(string[] args)
{

Person person = new Person("Bilibli, Jan Wayne", 27, "Camp 5 Acupan Virac Itogon Benguet");

Console.WriteLine("Name: " + person.Name);
Console.WriteLine("Age: " + person.Age);
Console.WriteLine("Address: " + person.Address);

person.Name = "Jan Wayne Saculles Bilibli";
person.Age = 28;
person.Address = "Camp 5 Acupan Virac Itogon Benguet";

Console.WriteLine("\nUpdated Details:");
Console.WriteLine("Name: " + person.Name);
Console.WriteLine("Age: " + person.Age);
Console.WriteLine("Address: " + person.Address);
}
}
