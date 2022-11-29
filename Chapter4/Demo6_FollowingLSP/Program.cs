Console.WriteLine("***A demo that follows LSP.***");
PaymentHelper helper = new();

// Instantiating two registered users.
RegisteredUser robin = new("Robin");
RegisteredUser jack = new("Jack");

// Adding the users to the helper.
helper.AddPreviousPayment(robin);
helper.AddPreviousPayment(jack);
helper.AddNewPayment(robin);
helper.AddNewPayment(jack);

// Instantiating a guest user.
GuestUser guestUser1 = new();
helper.AddNewPayment(guestUser1);

// Retrieve all the previous payments
// of registered users.
helper.ShowPreviousPayments();

// Process all new payment requests
// from all users.
helper.ProcessNewPayments();


interface IPreviousPayment
{
    void LoadPreviousPaymentInfo();
}
interface INewPayment
{
    void ProcessNewPayment();
}
class RegisteredUser : IPreviousPayment, INewPayment
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

class GuestUser : INewPayment
{
    readonly string name = string.Empty;
    public GuestUser()
    {
        this.name = "guest user";
    }

    public void ProcessNewPayment()
    {
        Console.WriteLine($"Processing a {name}'s current payment request.");
    }
}

class PaymentHelper
{
    readonly List<IPreviousPayment> previousPayments = new();
    readonly List<INewPayment> newPaymentRequests = new();
    public void AddPreviousPayment(IPreviousPayment previousPayment)
    {
        previousPayments.Add(previousPayment);
    }

    public void AddNewPayment(INewPayment newPaymentRequest)
    {
        newPaymentRequests.Add(newPaymentRequest);
    }
    public void ShowPreviousPayments()
    {
        foreach (IPreviousPayment user in previousPayments)
        {
            user.LoadPreviousPaymentInfo();
            Console.WriteLine("------");
        }
    }
    public void ProcessNewPayments()
    {
        foreach (INewPayment payment in newPaymentRequests)
        {
            payment.ProcessNewPayment();
            Console.WriteLine("***********");
        }
    }
}



