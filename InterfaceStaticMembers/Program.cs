Console.WriteLine("Hello, World!");

var rect = new Rectangle(2, 4);

public interface IShape
{
    double CalculateArea();
}

public class Rectangle : IShape
{
    private readonly double _width;
    private readonly double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public double CalculateArea() => _width * _height;
}

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea() => _radius * _radius * Math.PI;
}