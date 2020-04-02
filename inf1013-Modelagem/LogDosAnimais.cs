using System;
using System.Collections.Generic;
using System.Text;

class LogDosAnimais
{
    List<AnimalId> animals;

    public void AddAnimal(Animal animal)
    {
        if (animals == null)
            animals = new List<AnimalId>();
        animals.Add(animal.identity);
    }

    public void ShowAnimals()
    {
        if (animals == null)
        {
            System.Console.WriteLine("___ THERE ARE NO ANIMALS IN YOUR LOG ___ ");
            return;
        }
        foreach (var animal in animals)
        {
            animal.ShowAnimalId();
        }
    }

}

