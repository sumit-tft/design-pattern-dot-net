using System;

// Prototype interface
public interface IShape
{
    IShape Clone();
    void Draw();
}

// Concrete prototype
public class Rectangle : IShape
{
    private int width;
    private int height;
    private string color;

    public Rectangle(int width, int height, string color)
    {
        this.width = width;
        this.height = height;
        this.color = color;
    }

    public IShape Clone()
    {
        return new Rectangle(this.width, this.height, this.color);
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a {color} rectangle with width {width} and height {height}");
    }
}

// Client
class Program
{
    static void Main(string[] args)
    {
        // Create a prototype rectangle
        IShape prototypeRectangle = new Rectangle(100, 50, "blue");

        // Clone the prototype to create new rectangles
        IShape rectangle1 = prototypeRectangle.Clone();
        IShape rectangle2 = prototypeRectangle.Clone();

        // Draw the rectangles
        rectangle1.Draw();
        rectangle2.Draw();
    }
}
