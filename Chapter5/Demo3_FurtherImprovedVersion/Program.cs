//Console.WriteLine("---Chapter 5. Demonstration 3---");
Console.WriteLine("*** Another improved version following the DRY principle. ***");

// Initial setup
GameInfo gameInfo = new("SuperGame");
GamePrice gamePrice = new();

// Create the game instance with the default setup
Game game = new(gameInfo, gamePrice);

// Display the default game detail.
game.AboutGame();
game.DisplayCost();
game.DisplayCostAfterDiscount();
Console.WriteLine("------------");

Console.WriteLine("Changing the game version and price now.");

// Changing some of the game info
gameInfo.Version = "2.0";
gameInfo.MinimumAge = 9.5;

// Changing the game cost
gamePrice.Cost = 1500;
gamePrice.DiscountedCost = 1200;

// Updating the game instance
game = new Game(gameInfo, gamePrice);

// Display the latest detail
game.AboutGame();
game.DisplayCost();
game.DisplayCostAfterDiscount();


class GameInfo
{
    public string CompanyName { get; set; }
    public string GameName { get; set; }
    public string Version { get; set; }
    public double MinimumAge { get; set; }
    public GameInfo(string gameName)
    {
        CompanyName = "AbcCompany";
        GameName = gameName;
        Version = "1.0";
        MinimumAge = 10.5;
    }
}

class GamePrice
{
    public double Cost { get; set; }
    public double DiscountedCost { get; set; }

    public GamePrice()
    {
        Cost = 1000;
        DiscountedCost = 800;
    }
}


class Game
{
    readonly string companyName;
    readonly string gameName;
    readonly double minimumAge;
    readonly string version;
    readonly double actualCost;
    readonly double discountedCost;
    public Game(GameInfo gameInfo, GamePrice gamePrice)
    {
        companyName = gameInfo.CompanyName;
        gameName = gameInfo.GameName;
        version = gameInfo.Version;
        minimumAge = gameInfo.MinimumAge;
        actualCost = gamePrice.Cost;
        discountedCost = gamePrice.DiscountedCost;
    }
    public void AboutGame()
    {
        Console.WriteLine($"Game name: {gameName}");
        Console.WriteLine($"Minimum age: {minimumAge} years and above.");
        Console.WriteLine($"Current version: {version}.");
        Console.WriteLine($"It is the {companyName} product.");
    }
    public void DisplayCost()
    {
        Console.WriteLine($"\n{companyName} {gameName}'s price details:");
        Console.WriteLine($"""
                          Version: {version} 
                          Cost: {actualCost}
                          """);
    }
    public void DisplayCostAfterDiscount()
    {
        Console.WriteLine($"\n{companyName} offers a festive season discount.");
        Console.WriteLine("Discounted price detail:");
        Console.WriteLine($"""
               Game: {gameName}. 
               Version: {version}. 
               Discounted price: {discountedCost}
               """);
    }
}


