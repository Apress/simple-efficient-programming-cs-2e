//Console.WriteLine("Chapter3.Demo:Better Design");

using Vehicles;
using Capabilities;

try
{
    Console.WriteLine("***Vehicles with different capabilities demo.***");
    Console.WriteLine("Using a boat.");
    Vehicle vehicle = new Boat("B001");
    vehicle.DisplayDetails();
    Console.WriteLine("****************");

    ICapability currentCapability = new FloatCapability();
    Console.WriteLine("Setting floating capability.");
    vehicle.SetVehicleBehavior(currentCapability);
    vehicle.DisplayDetails();
    Console.WriteLine("****************");

    Console.WriteLine("Using an airplane.");
    vehicle = new Airplane("A002");
    Console.WriteLine("Setting flying capability.");
    currentCapability = new FlyCapability();
    vehicle.SetVehicleBehavior(currentCapability);
    vehicle.DisplayDetails();
    Console.WriteLine("****************");

    Console.WriteLine("Adding floating behavior to it.");
    currentCapability = new FloatCapability();
    vehicle.SetVehicleBehavior(currentCapability);
    vehicle.DisplayDetails();
    Console.WriteLine("****************");
}
catch (Exception ex)
{
    Console.WriteLine($"Error:{ex}");
}
namespace Capabilities
{
    interface ICapability
    {
        void CurrentCapability();
    }
    class FloatCapability : ICapability
    {
        public void CurrentCapability()
        {
            Console.WriteLine("It will float now.");
        }
    }
    class FlyCapability : ICapability
    {
        public void CurrentCapability()
        {
            Console.WriteLine("It will fly now.");
        }
    }
    class DoNothing : ICapability
    {
        public void CurrentCapability()
        {
            Console.WriteLine("It does nothing.");
        }
    }
}

namespace Vehicles
{
    abstract class Vehicle
    {
        protected string vehicleType = string.Empty;
        protected ICapability capability;
        protected string registrationNumber = string.Empty;
        public abstract void SetVehicleBehavior(ICapability capability);
        public abstract void DisplayDetails();
    }

    class Boat : Vehicle
    {
        public Boat(string registrationId)
        {
            registrationNumber = registrationId;
            vehicleType = "Boat";
            capability = new DoNothing();
        }
        public override void SetVehicleBehavior(ICapability capability)
        {
            this.capability = capability;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("**The current status of the boat**");
            Console.WriteLine($"Registration number:{registrationNumber}");
            capability.CurrentCapability();
        }
    }
    class Airplane : Vehicle
    {
        public Airplane(string registrationId)
        {
            registrationNumber = registrationId;
            vehicleType = "Airplane";
            capability = new DoNothing();
        }
        public override void SetVehicleBehavior(ICapability capability)
        {
            this.capability = capability;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("**The current status of the airplane**");
            Console.WriteLine($"Registration number: {registrationNumber}");
            capability.CurrentCapability();
        }
    }
}

// An interface cannot contain instance fields
//interface ITest
//{
//    protected string vehicleType = string.Empty; // ERROR CS0525
//    protected ICapability? capability;// ERROR CS0525
//    protected string registrationNumber = string.Empty;// ERROR CS0525
//}

