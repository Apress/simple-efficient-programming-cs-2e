//Console.WriteLine("***Chapter 7. Demo-1.***"); 
Console.WriteLine("***Using wrappers.***");
Console.WriteLine("Scenario-1: A basic home with basic facilities.");
Home home = new BasicHome();
home.BuildHome();

Console.WriteLine("\nScenario-2: A basic home with an additional playground.");
Luxury homeWithOnePlayground = new Playground(home);
homeWithOnePlayground.BuildHome();

Console.WriteLine("\nScenario-3: A basic home with two additional playgrounds.");
Luxury homeWithDoublePlaygrounds = new Playground(homeWithOnePlayground);
homeWithDoublePlaygrounds.BuildHome();

Console.WriteLine("\nScenario-4: A basic home with one additional playground and swimming pool.");
Luxury homeWithOnePlaygroundAndOneSwimmingPool = new SwimmingPool(homeWithOnePlayground);
homeWithOnePlaygroundAndOneSwimmingPool.BuildHome();

Console.WriteLine("\nScenario-5: Adding a swimming pool and then a playground to a basic home.");
Luxury homeWithOneSwimmingPool = new SwimmingPool(home);
Luxury homeWithSwimmingPoolAndPlayground = new Playground(homeWithOneSwimmingPool);
homeWithSwimmingPoolAndPlayground.BuildHome();

Console.WriteLine("\nScenario-6: An advanced home with some more facilities.");
home = new AdvancedHome();
home.BuildHome();

Console.WriteLine("\nScenario-7: An advanced home with an additional playground.");
homeWithOnePlayground = new Playground(home);
homeWithOnePlayground.BuildHome();
abstract class Home
{
    public double basePrice = 100000;
    public double AdditionalCost { get; set; }
    public abstract void BuildHome();
    public virtual double GetPrice()
    {
        return basePrice + AdditionalCost;
    }
}
class BasicHome : Home
{
    public BasicHome()
    {
        AdditionalCost = 0;
    }
    public override void BuildHome()
    {
        Console.WriteLine($"""
          A home with basic facilities is made.
          It costs ${GetPrice()}.
          """);
    }
}

class AdvancedHome : Home
{
    public AdvancedHome()
    {
        AdditionalCost = 25000;
    }
    public override void BuildHome()
    {
        Console.WriteLine($"""
          A home with advanced facilities is made.
          It costs ${GetPrice()}.
          """);
    }
}
abstract class Luxury : Home
{
    protected Home home;
    public double LuxuryCost { get; set; }
    public Luxury(Home home)
    {
        this.home = home;
    }
    public override void BuildHome()
    {
        home.BuildHome();
    }
}
class Playground : Luxury
{
    public Playground(Home home) : base(home)
    {
        this.LuxuryCost = 20000;
    }
    public override void BuildHome()
    {
        base.BuildHome();
        AddPlayground();
    }

    private void AddPlayground()
    {
        Console.WriteLine($"""
          For a playground, you pay an extra ${this.LuxuryCost}.
          Now the total cost is ${GetPrice()}.
          """);
    }
    public override double GetPrice()
    {
        return home.GetPrice() + LuxuryCost;
    }
}

class SwimmingPool : Luxury
{
    public SwimmingPool(Home home) : base(home)
    {
        this.LuxuryCost = 55000;
    }
    public override void BuildHome()
    {
        base.BuildHome();
        AddSwimmingPool();
    }

    private void AddSwimmingPool()
    {
        Console.WriteLine($"""
          For a swimming pool, you pay an extra ${this.LuxuryCost}.
          Now the total cost is ${GetPrice()}.
          """);
    }
    public override double GetPrice()
    {
        return home.GetPrice() + LuxuryCost;
    }
}


