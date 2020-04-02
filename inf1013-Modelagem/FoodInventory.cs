using System;
using System.Collections.Generic;
using System.Text;


class FoodInventory
{
    Dictionary<Food, int> foodStock;

    public void BuyFood(Food food, int quantity)
    {
        if (!foodStock.ContainsKey(food)) return;
        int price = food.price * quantity;
        //Todo Player.money, needs refactoring
        if (price > Player.money) return;
        int value = foodStock[food] + quantity;
        foodStock.Remove(food);
        foodStock.Add(food, value);
        //Todo Player.money, needs refactoring
        Player.money -= price;
    }

    public bool CheckFood(Food food, int quantity)
    {
        if (!foodStock.ContainsKey(food)) return false;
        if (foodStock[food] < quantity) return false;
        return true;
    }
        public void UseFood(Food food, int quantity)
    {
        if (!foodStock.ContainsKey(food)) return;
        if (foodStock[food] < quantity) return;

        int value = foodStock[food] - quantity;
        foodStock.Remove(food);
        foodStock.Add(food, value);
    }

    public void ShowFoodInventory()
    {
        System.Console.WriteLine("___ FOOD STOCK ___");
        System.Console.WriteLine("Name\tQuantity");
        foreach (var food in foodStock)
        {
            System.Console.WriteLine(food.Key.name + '\t' + food.Value);
        }
        System.Console.WriteLine("___ ____ _____ ___");
    }
}

