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

    public void AskToSleep()
    {
        if(animal.Sleep())
        {
            //Implement recuperation
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

    }

    public void AnimalPassedOut()
    {

    }
}
