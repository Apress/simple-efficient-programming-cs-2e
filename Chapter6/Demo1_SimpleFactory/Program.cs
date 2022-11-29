// Console.WriteLine("Chapter 6. Demo-1.");
Console.WriteLine("***Creating animals and learning about them. ***");
AnimalFactory animalFactory = new();

IAnimal animal = animalFactory.CreateAnimal("cat");
animal.DisplayBehavior();

animal = animalFactory.CreateAnimal("tiger");
animal.DisplayBehavior();
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
        //Console.WriteLine("It meows.");
        //Console.WriteLine("It loves to stay at a home.");
        Console.WriteLine("""
         It meows.
         It loves to stay at a home.
         """);
    }
}

class AnimalFactory
{
    public IAnimal CreateAnimal(string animalType)
    {
        IAnimal animal;
        if (animalType.Equals("cat"))
        {
            animal = new Cat();
        }
        else if (animalType.Equals("tiger"))
        {
            animal = new Tiger();
        }
        else
        {
            Console.WriteLine("You can create either a cat or a tiger. ");
            throw new ApplicationException("An unknown animal cannot be instantiated.");
        }
        return animal;
    }
}



