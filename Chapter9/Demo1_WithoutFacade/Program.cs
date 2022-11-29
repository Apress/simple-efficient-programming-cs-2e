Console.WriteLine("Directly interacting with the classes(subsystems).");
Asset asset = new();
LoanStatus loanStatus = new();
string status = "approved";
string reason = string.Empty;
bool assetValue, previousLoanExist;

// Person-1
Person bob = new("Bob", 5000, true);

// Starts background verification
assetValue = asset.HasSufficientAssetValue(bob, 20000);
previousLoanExist = loanStatus.HasPreviousLoans(bob);

if (!assetValue)
{
    status = "Not approved.";
    reason += "\nInsufficient balance.";
}
if (!previousLoanExist)
{
    status = "Not approved.";
    reason += "\nAn old loan exists.";
}
Console.WriteLine($"{bob.name}'s application status: {status}");
Console.WriteLine($"Remarks if any: {reason}");

class Person
{
    public string name;
    public double assetValue;
    public bool previousLoanExist;

    public Person(string name,
        double assetValue = 100000,
        bool previousLoanExist = false)
    {
        this.name = name;
        this.assetValue = assetValue;
        this.previousLoanExist = previousLoanExist;
    }
}

class Asset
{
    public bool HasSufficientAssetValue(Person person, double claimAmount)
    {
        Console.WriteLine($"Validating {person.name}'s asset value.");
        //return person.assetValue >= claimAmount ? true : false;
        // Simplified statement
        return person.assetValue >= claimAmount;
    }
}

class LoanStatus
{
    public bool HasPreviousLoans(Person person)
    {
        Console.WriteLine($"Verifying {person.name}'s existing loan(s).");
        //return !person.previousLoanExist ? true : false;
        // Simplified statement
        return !person.previousLoanExist;
    }
}


