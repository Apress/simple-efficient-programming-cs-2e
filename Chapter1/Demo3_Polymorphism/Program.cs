//Console.WriteLine("***Polymorphism (Demo-3)***");
Console.WriteLine("***Sounds of the different animals.***");

//IAnimal animal = new Tiger();
//animal.Sound();
//animal = new Dog();
//animal.Sound();
//animal = new Monkey();
//animal.Sound();

// Additional discussions:
// You cannot predict the output
// in advance in this case.
IAnimal animal = AnimalProducer.GetAnimal();
animal.Sound();
animal = AnimalProducer.GetAnimal();
animal.Sound();
animal = AnimalProducer.GetAnimal();
animal.Sound();

interface IAnimal
{
    void Sound();
}
class Tiger : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Tigers roar.");
    }
}
class Dog : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Dogs bark.");
    }
}
class Monkey : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Monkeys whoop.");
    }
}

class AnimalProducer
{
    internal static IAnimal GetAnimal()
    {
        IAnimal animal;
        //Random random = new Random();
        Random random = new();
        // Get a number between 0 and 3(exclusive)
        int temp = random.Next(0, 3);

        //if (temp == 0)
        //{
        //    animal = new Tiger();
        //}
        //else if (temp == 1)
        //{
        //    animal = new Dog();
        //}
        //else
        //{
        //    animal = new Monkey();
        //}

        animal =
        temp switch
        {
            0 => new Tiger(),
            1 => new Dog(),
            _ => new Monkey()
        };

        return animal;
    }
}

