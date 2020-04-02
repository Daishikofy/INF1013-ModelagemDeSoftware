using System;
using System.Collections.Generic;
using System.Text;

class AnimalId
{
    public int age;
    public string name { get; }   
    AnimalType type { get; }

    public void ShowAnimalId()
    {
        string head = "___ " + name.ToUpper() + " ___";
        System.Console.WriteLine(head);
        System.Console.WriteLine("Age:\t" + age + " days");
        System.Console.WriteLine("Specie:\t" + type.SpecieName);
    }
}

