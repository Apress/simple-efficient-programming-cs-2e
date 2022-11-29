// Console.WriteLine("Chapter 6. Demo-2.");
Console.WriteLine("***Modified version of demonstration 1. ***");
// The CatFactory creates cats
AnimalFactory animalFactory = new CatFactory();
IAnimal animal = animalFactory.CreateAnimal();
animal.DisplayBehavior();

// The TigerFactory creates tigers
animalFactory = new TigerFactory();
animal = animalFactory.CreateAnimal();
animal.DisplayBehavior();

#region Animal hierarchy

interface IAnimal
{
    void DisplayBehavior();
}
class Tiger : IAnimal
{
    public Tiger()
    {
        Console.WriteLine("\nA tiger is created.");
    }
    public void DisplayBehavior()
    {
        Console.WriteLine("""
         It roars.
         It loves to roam in the jungle.
         """);
    }
}
class Cat : IAnimal
{
    public Cat()
    {
        Console.WriteLine("\nA cat is created.");
    }
    public void DisplayBehavior()
    {
        Console.WriteLine("""
         It meows.
         It loves to stay at a home.
         """);
    }
}
#endregion

#region Factory hierarchy

/// <summary>
/// This class contains the "factory method"
/// </summary>
abstract class AnimalFactory
{
    // Deferring the instantiation process
    // to the subclasses.
    public abstract IAnimal CreateAnimal();
}
/// <summary>
/// CatFactory creates cats.
/// </summary>
class CatFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Cat();
    }
}
/// <summary>
/// TigerFactory creates tigers.
/// </summary>
class TigerFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Tiger();
    }
}
#endregion



