//Console.WriteLine("***Demo without polymorphism***");
Console.WriteLine("***Sounds of the different animals.***");
Tiger tiger = new();
tiger.Sound();
Dog dog = new();
dog.Sound();
Monkey monkey = new();
monkey.Sound();
Console.ReadKey();
class Tiger
{
    public void Sound()
    {
        Console.WriteLine("Tigers roar.");
    }
}
class Dog
{
    public void Sound()
    {
        Console.WriteLine("Dogs bark.");
    }
}
class Monkey
{
    public void Sound()
    {
        Console.WriteLine("Monkeys whoop.");
    }
}

