Console.WriteLine("Chapter 11.Demo-1.");
Console.WriteLine("This program has a potential bug.");
IVehicle[] vehicles = new IVehicle[3];
int vehicleCount = 0;
while (vehicleCount < 3)
{
    Console.WriteLine("Enter your choice(Type 'b' for a bus, 't' for a train.)");
    string input = Console.ReadLine();
    switch (input)
    {
        case "b":
            vehicles[vehicleCount] = new Bus();
            break;
        case "t":
            vehicles[vehicleCount] = new Train();
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
    vehicleCount++;
}

Console.WriteLine("**Checking the vehicle's status sequentially:**");
foreach (IVehicle vehicle in vehicles)
{
    // The following is a BAD practise
    //vehicle.ShowStatus();

    // The following is OK
    //if (vehicle != null)
    //{
    //    vehicle.ShowStatus();
    //}

    // The following is better
    vehicle?.ShowStatus();
}


interface IVehicle
{
    void ShowStatus();
}
class Bus : IVehicle
{
    public void ShowStatus()
    {
        Console.WriteLine("One bus is ready to travel.");
    }
}
class Train : IVehicle
{
    public void ShowStatus()
    {
        Console.WriteLine("One train is ready to travel.");
    }
}



