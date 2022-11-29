//Console.WriteLine("***Polymorphism Demo***");
Console.WriteLine("***Sounds of the different animals.***");

//IAnimal animal = new Tiger();
//animal.Sound();
//animal = new Dog();
//animal.Sound();
//animal = new Monkey();
//animal.Sound();

// Additional discussions(alternative uses):

List<IAnimal> animals = new List<IAnimal>
{
    new Tiger(),
    new Dog(),
    new Monkey()
};
foreach (IAnimal animal in animals)
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









