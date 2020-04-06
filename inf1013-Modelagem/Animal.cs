using System;
using System.Collections.Generic;
using System.Text;


class Animal
{
    public AnimalId identity { get; }
    public int lifePoints { get; }
    public int energyPoints { get; private set; }
    public int hungerPoints { get; private set; }
    public int happinessPoints { get; private set; }

    public bool isSleeping { get; private set; }

    public Animal (AnimalId id)
    {
        identity = id;
    }
    public Animal(AnimalId id, int life, int energy, int happiness, bool sleep)
    {
        identity = id;
        lifePoints = life;
        energyPoints = energy;
        happinessPoints = happiness;
        isSleeping = sleep;
    }

    public bool Eat(Food food, int quantity)
    {
        if (!WantsToEat(food)) return false;
        hungerPoints += food.nutricionalValue * quantity;
        energyPoints += food.energeticValue * quantity;
        happinessPoints += 5 * quantity;
        return true;
    }
    private bool WantsToEat (Food food)
    {
        if (hungerPoints >= 90)
            return false;
        else
            return true;
    }

    public bool Sleep()
    {
        isSleeping = WantsToSleep();
        return isSleeping;
    }
    private bool WantsToSleep()
    {
        if (energyPoints > 50) return false;
        if (happinessPoints < 25) return false;
        return true;
    }

    public bool Play()
    {
        if (WantsToPlay())
        {
            happinessPoints += 10;
            energyPoints -= 10;
            return true;
        }
        return false;
    }
    private bool WantsToPlay()
    {
        if (energyPoints <= 0)
            return false;
        return true;
    }
}

