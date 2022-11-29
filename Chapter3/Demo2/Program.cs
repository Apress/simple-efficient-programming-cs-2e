// Console.WriteLine("---Chapter2.Demo:2---");
Console.WriteLine("***Measuring the area of a rectangle.***");
Rectangle rectangleObject = new(2.5, 10);
double area = rectangleObject.RectangleArea();
Console.WriteLine($"The area of the rectangle is {area} square units.");

class Rectangle
{
    readonly double length;
    readonly double breadth;
    public Rectangle(double length, double breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }

    public double RectangleArea()
    {
        return length * breadth;
    }
}


