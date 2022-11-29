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
AnimalProducer.MakeSound(animal);
animal = AnimalProducer.GetAnimal();
AnimalProducer.MakeSound(animal);
animal = AnimalProducer.GetAnimal();
AnimalProducer.MakeSound(animal);

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
        Random random = new Random();
        // Get a number between 0 and 3(exclusive)
        int temp = random.Next(0, 3);

        animal =
        temp switch
        {
            0 => new Tiger(),
            1 => new Dog(),
            _ => new Monkey()
        };

        return animal;
    }
    internal static void MakeSound(IAnimal animal)
    {
        animal.Sound();
    }
}

