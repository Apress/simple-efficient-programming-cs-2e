// Console.WriteLine("Chapter3.Demonstration3");

Console.WriteLine("Dealing with TODO comments.");
Sample sample = new();
sample.SayHello();
sample.SayHi();

//#region Version 1(Not recommended)
//class Sample
//{
//    readonly string name = "Reader";
//    // TODO-We'll replace this method shortly.
//    // Use SayHi() from the next release(Version-2.0).
//    public void SayHello()
//    {
//        Console.WriteLine($"Hello, {name}!");
//    }

//    public void SayHi()
//    {
//        Console.WriteLine($"\nHi, {name}!");
//        Console.WriteLine("This is the latest method.");
//    }
//}
//#endregion

#region Version 2(Recommended)
class Sample
{
    readonly string name = "Reader";
    [Obsolete("This method is obsolete. Use SayHi() instead.")]
    public void SayHello()
    {
        Console.WriteLine($"Hello, {name}!");
    }
    public void SayHi()
    {
        Console.WriteLine($"Hi, {name}!");
        Console.WriteLine("This is the latest method.");
    }
}
#endregion

//// The following code was used to show 
//// the in-built Next() method description
//class Test
//{
//    void SomeMethod()
//    {
//        Random r = new();
//        r.Next(12);
//    }
//}
