using System;

class Program
{
    static void Main(string[] args)
    {

    Square thisSquare = new Square();
    Circle thisCircle = new Circle();
    thisSquare.SetColor("red");
    thisSquare.SetSide(6);
    thisCircle.setRadius(7);
    thisCircle.SetColor("blue");


    List<Shape> shapes = new List<Shape>();
    shapes.Add(thisCircle);
    shapes.Add(thisSquare);

    foreach (Shape s in shapes)
    {
        Console.WriteLine();
        Console.WriteLine(s.getArea());
        Console.WriteLine(s.GetColor());
        Console.WriteLine();
    }
    }
    
}

public abstract class Shape
{
    private string _color;

    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract double getArea();
    
}

public class Square : Shape
{
    private double _side;

    public void SetSide(double side)
    {
        _side = side;
    }

    public override double getArea()
    {
        return _side * _side;
    }
}

public class Circle : Shape
{
    private double _radius;

    public void setRadius(double radius)
    {
        _radius = radius;
    }

    public override double getArea()
    {
        return (3.14*(_radius*_radius));
    }
} 
