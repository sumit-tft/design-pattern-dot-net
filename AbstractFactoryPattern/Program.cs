using System;

// Abstract Product A
public interface Button
{
    void Render();
}

// Concrete Products A
public class LightButton : Button
{
    public void Render()
    {
        Console.WriteLine("Rendering a light button.");
    }
}

public class DarkButton : Button
{
    public void Render()
    {
        Console.WriteLine("Rendering a dark button.");
    }
}

// Abstract Product B
public interface Checkbox
{
    void Render();
}

// Concrete Products B
public class LightCheckbox : Checkbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a light checkbox.");
    }
}

public class DarkCheckbox : Checkbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a dark checkbox.");
    }
}

// Abstract Factory
public interface UIToolkitFactory
{
    Button CreateButton();
    Checkbox CreateCheckbox();
}

// Concrete Factories
public class LightUIToolkitFactory : UIToolkitFactory
{
    public Button CreateButton()
    {
        return new LightButton();
    }

    public Checkbox CreateCheckbox()
    {
        return new LightCheckbox();
    }
}

public class DarkUIToolkitFactory : UIToolkitFactory
{
    public Button CreateButton()
    {
        return new DarkButton();
    }

    public Checkbox CreateCheckbox()
    {
        return new DarkCheckbox();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a light theme UI toolkit
        UIToolkitFactory lightFactory = new LightUIToolkitFactory();
        Button lightButton = lightFactory.CreateButton();
        Checkbox lightCheckbox = lightFactory.CreateCheckbox();

        // Render UI components with light theme
        lightButton.Render();
        lightCheckbox.Render();

        // Create a dark theme UI toolkit
        UIToolkitFactory darkFactory = new DarkUIToolkitFactory();
        Button darkButton = darkFactory.CreateButton();
        Checkbox darkCheckbox = darkFactory.CreateCheckbox();

        // Render UI components with dark theme
        darkButton.Render();
        darkCheckbox.Render();
    }
}
