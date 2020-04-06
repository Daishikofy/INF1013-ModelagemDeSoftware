using System;
using System.Collections.Generic;
using System.Text;

class AnimalId
{
    public int age;
    public string name { get; private set; }
    public AnimalType type { get; private set; }

    public AnimalId(string name, AnimalType type)
    {
        this.name = name;
        this.type = type;
    }
    public AnimalId(int age, string name, AnimalType type)
    {
        this.age = age;
        this.name = name;
        this.type = type;
    }

    public void ShowAnimalId()
    {
        string head = "___ " + name.ToUpper() + " ___";
        System.Console.WriteLine(head);
        System.Console.WriteLine("Age:\t" + age + " days");
        System.Console.WriteLine("Specie:\t" + type.SpecieName);
    }
}

