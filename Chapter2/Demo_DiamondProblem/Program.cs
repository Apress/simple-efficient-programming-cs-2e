Console.WriteLine("---Chapter3.Demo: Diamon Problem---");
class Shape
{
    public virtual void AboutMe()
    {
        Console.WriteLine("It is an arbitrary Shape.");
    }
}
class Triangle : Shape
{
    public override void AboutMe()
    {
        Console.WriteLine("It is a Triangle.");
    }
}
class Rectangle : Shape
{
    public override void AboutMe()
    {
        Console.WriteLine("It is a Rectangle");
    }
}
// ERROR CS1721 due to diamond effect
//class GrandShape : Triangle, Rectangle
//{
//    // Some  code
//}


