Console.WriteLine("---Chapter3.Demo:Different Inheritance Chains---");

#region Animal class hierarchy
abstract class Animal
{
    public abstract void Sound();
}
class Tiger : Animal
{
    public override void Sound()
    {
        // Some code
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        // Some code
    }
}
#endregion

#region SoftToy class hierarchy
abstract class SoftToys
{
    public abstract void Sound();
}
class TigerToy : SoftToys
{
    public override void Sound()
    {
        // Some code
    }
}

class JumpingDog : SoftToys
{
    public override void Sound()
    {
        // Some code
    }
}
#endregion