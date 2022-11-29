using BasicGameInfo;
//Console.WriteLine("---Chapter 5. Demonstration 4---");
Console.WriteLine("*** Applying the DRY principle using a DLL. ***");

// Initial setup
GameInfo gameInfo = new ("NewPokemonKid");
GamePrice gamePrice = new ();

// Create the game instance with a
// default setup
Game game = new(gameInfo, gamePrice);

// Display the default game detail.
game.AboutGame();
game.DisplayCost();
game.DisplayCostAfterDiscount();

Console.WriteLine("------------");

Console.WriteLine("Changing the game version and price now.");

// Changing some of the game info
gameInfo.Version = "2.1";
gameInfo.MinimumAge = 12.5;

// Changing the game cost
gamePrice.Cost = 3500;
gamePrice.DiscountedCost = 2000;

// Updating the game instance
game = new Game(gameInfo, gamePrice);

// Display the latest detail
game.AboutGame();
game.DisplayCost();
game.DisplayCostAfterDiscount();





