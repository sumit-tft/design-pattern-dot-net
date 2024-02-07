using System;
using System.Collections.Generic;

// Product: Meal
public class Meal
{
    private List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void Show()
    {
        Console.WriteLine("Meal contains:");
        foreach (var item in items)
        {
            Console.WriteLine($" - {item}");
        }
    }
}

// Builder interface
public interface IMealBuilder
{
    void BuildMainDish();
    void BuildSide();
    void BuildDrink();
    Meal GetMeal();
}

// Concrete Builders
public class BurgerMealBuilder : IMealBuilder
{
    private Meal meal = new Meal();

    public void BuildMainDish()
    {
        meal.AddItem("Burger");
    }

    public void BuildSide()
    {
        meal.AddItem("Fries");
    }

    public void BuildDrink()
    {
        meal.AddItem("Coke");
    }

    public Meal GetMeal()
    {
        return meal;
    }
}

public class SaladMealBuilder : IMealBuilder
{
    private Meal meal = new Meal();

    public void BuildMainDish()
    {
        meal.AddItem("Salad");
    }

    public void BuildSide()
    {
        meal.AddItem("Breadsticks");
    }

    public void BuildDrink()
    {
        meal.AddItem("Water");
    }

    public Meal GetMeal()
    {
        return meal;
    }
}

// Director
public class MealDirector
{
    public Meal Construct(IMealBuilder mealBuilder)
    {
        mealBuilder.BuildMainDish();
        mealBuilder.BuildSide();
        mealBuilder.BuildDrink();
        return mealBuilder.GetMeal();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Burger meal
        IMealBuilder burgerMealBuilder = new BurgerMealBuilder();
        MealDirector mealDirector = new MealDirector();
        Meal burgerMeal = mealDirector.Construct(burgerMealBuilder);
        Console.WriteLine("Burger Meal:");
        burgerMeal.Show();

        // Create a Salad meal
        IMealBuilder saladMealBuilder = new SaladMealBuilder();
        Meal saladMeal = mealDirector.Construct(saladMealBuilder);
        Console.WriteLine("\nSalad Meal:");
        saladMeal.Show();
    }
}
