Console.WriteLine("***A demo without LSP.***");
PaymentHelper helper = new();

// Instantiating two registered users
RegisteredUser robin = new("Robin");
RegisteredUser jack = new("Jack");

// Adding the users to the helper
helper.AddUser(robin);
helper.AddUser(jack);

// Processing the payments using
// the helper class instance.            
helper.ShowPreviousPayments();
helper.ProcessNewPayments();

GuestUser guestUser1 = new();
helper.AddUser(guestUser1);

// Processing the payments using 
// the helper class instance.
// You can see the problem now.
//helper.ShowPreviousPayments();
//helper.ProcessNewPayments();


interface IPayment
{
    void LoadPreviousPaymentInfo();
    void ProcessNewPayment();
}
class RegisteredUser : IPayment
{
    readonly string name = string.Empty;
    public RegisteredUser(string name)
    {
        this.name = name;
    }
    public void LoadPreviousPaymentInfo()
    {
        Console.WriteLine($"Retrieving {name}'s last payment details.");
    }

    public void ProcessNewPayment()
    {
        Console.WriteLine($"Processing {name}'s current payment request.");
    }
}

class GuestUser : IPayment
{
    readonly string name = string.Empty;
    public GuestUser()
    {
        name = "guest user";
    }

    public void LoadPreviousPaymentInfo()
    {
        throw new NotImplementedException();
    }

    public void ProcessNewPayment()
    {
        Console.WriteLine($"Processing {name}'s current payment request.");
    }
}

class PaymentHelper
{
    readonly List<IPayment> users = new();
    public void AddUser(IPayment user)
    {
        users.Add(user);
    }
    public void ShowPreviousPayments()
    {
        foreach (IPayment user in users)
        {
            user.LoadPreviousPaymentInfo();   
            Console.WriteLine("------");
        }
    }
    public void ProcessNewPayments()
    {
        foreach (IPayment user in users)
        {
            user.ProcessNewPayment();
            Console.WriteLine("***********");
        }
    }
}

