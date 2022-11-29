// Console.WriteLine("Chapter 6. Demo-4.");
Console.WriteLine("***Modifying demonstration 2 (an alternative approach).***");
// The CatFactory creates cats
AnimalFactory animalFactory = new CatFactory();
IAnimal animal = animalFactory.MakeAnimal("black");
animal.DisplayBehavior();

// The TigerFactory creates tigers
animalFactory = new TigerFactory();
animal = animalFactory.MakeAnimal("white");
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
        Console.WriteLine("A tiger is created.");
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
        Console.WriteLine("A cat is created.");
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

abstract class AnimalFactory
{
    public IAnimal MakeAnimal(string color)
    {
        Console.WriteLine($"\nThe following animal color is {color}.");
        IAnimal animal = CreateAnimal();
        return animal;
    }
    public abstract IAnimal CreateAnimal();
}
class CatFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Cat();
    }
}
class TigerFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Tiger();
    }
}
#endregion



