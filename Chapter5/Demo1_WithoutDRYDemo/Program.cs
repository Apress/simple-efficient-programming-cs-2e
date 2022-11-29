//Console.WriteLine("---Chapter 5. Demonstration 1---");
Console.WriteLine("***A demo without the DRY principle. ***");
SuperGame superGame = new();
superGame.AboutGame();
superGame.DisplayCost();
superGame.DisplayCostAfterDiscount();

class SuperGame
{

    public void AboutGame()
    {
        Console.WriteLine("Game name: SuperGame");
        Console.WriteLine("Minimum age: 10 years and above.");
        Console.WriteLine("Current version: 1.0.");
        Console.WriteLine("It is the AbcCompany product.");
    }

    public void DisplayCost()
    {
        Console.WriteLine("\nAbcCompany SuperGame's price details:");
        Console.WriteLine("Version:1.0 \nCost: $1000");
    }

    public void DisplayCostAfterDiscount()
    {
        Console.WriteLine("\nAbcCompany offers a festive season discount.");
        Console.WriteLine("Discounted price details:");
        Console.WriteLine("Game: SuperGame. \nVersion: 1.0 \nDiscounted price: $800");
    }
}


