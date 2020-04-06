using System;
using System.Collections.Generic;

public class Player
{
    string name;
    //ToRemove
    public static int money;
    Dictionary<string,int> minigamesExperience;

    FoodInventory foodInventory;
    Animal animal;
    AnimalsLog animalsLog;

    public void AskToSleep()
    {
        if(animal.Sleep())
        {
            Console.WriteLine(animal.identity.name + "is going to sleep");
        }
        else 
        {
            Console.WriteLine(animal.identity.name + "doesn't want to sleep");
        }
    }

    public void AskToEat(Food food, int quantity)
    {
        if (!foodInventory.CheckFood(food, quantity)) return;
        if (animal.Eat(food, quantity))
            foodInventory.UseFood(food, quantity);
    }

    public void AskToPlay()
    {
        if (!animal.Play()) return;
        //minigame.Play();
    }

    public void OpenInventory()
    {
        System.Console.WriteLine("MONEY: " + money + "£");
        foodInventory.ShowFoodInventory();
    }
    public void CloseInventory()
    {
        System.Console.Clear();
    }

    public void CreateNewAnimal()
    {
        AnimalType type = new AnimalType("RandomSpecie");
        AnimalId newId = new AnimalId("Random Name", type);
        Animal newAnimal = new Animal(newId);
        animal = newAnimal;
    }

    public void AnimalPassedOut()
    {
        animalsLog.AddAnimal(animal);
        CreateNewAnimal();
    }
}
