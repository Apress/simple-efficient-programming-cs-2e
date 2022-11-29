Console.WriteLine("Chapter 11.Demo-2.");
IVehicle[] vehicles = new IVehicle[3];
int vehicleCount = 0;
while (vehicleCount < 3)
{
    Console.WriteLine("Enter your choice(Type 'b' for a bus, 't' for a train.)");
    string input = Console.ReadLine();
    //vehicle = null;
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
            vehicles[vehicleCount] = new IncompleteVehicle();
            break;
    }
    vehicleCount++;
}

Console.WriteLine("**Checking the vehicle's status sequentially:**");
foreach (IVehicle vehicle in vehicles)
{
    vehicle.ShowStatus();
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

class IncompleteVehicle : IVehicle
{
    public void ShowStatus()
    {
        Console.WriteLine("This vehicle cannot travel.");
    }
}


