Console.WriteLine("***Simplifying the usage of a complex system using a facade.***");
// Using a facade
LoanApprover loanApprover = new();

// Person-1
Person bob = new("Bob", 5000, true);
string approvalStatus = loanApprover.CheckLoanEligibility(bob, 20000);
Console.WriteLine($"{bob.name}'s application status: {approvalStatus}");

// Person-2
Person jack = new("Jack");
approvalStatus = loanApprover.CheckLoanEligibility(jack, 30000);
Console.WriteLine($"{jack.name}'s application status: {approvalStatus}");

// Person-3
Person tony = new("Tony", 125000, true);
approvalStatus = loanApprover.CheckLoanEligibility(tony, 50000);
Console.WriteLine($"{tony.name}'s application status: {approvalStatus}");

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

class LoanApprover
{
    readonly Asset asset;
    readonly LoanStatus loanStatus;
    public LoanApprover()
    {
        asset = new Asset();
        loanStatus = new LoanStatus();
    }
    public string CheckLoanEligibility(Person person, double claimAmount)
    {
        string status = "Approved";
        string reason = String.Empty;
        Console.WriteLine($"\nChecking loan approval status of {person.name}.");
        //Console.WriteLine($"[Current asset value:{person.assetValue}," +
        //    $"claim amount:{claimAmount}," +
        //    $"existing loan?:{person.previousLoanExist}.]\n");
        // Using raw string literals in C# 11 (Preview)
        Console.WriteLine($"""
         [Current Status of the applicant:
          Asset value:${person.assetValue}.
          Claim amount:${claimAmount}.
          Has existing loan(s)?:{person.previousLoanExist}.
         ]
         """);

        if (!asset.HasSufficientAssetValue(person, claimAmount))
        {
            status = "Not approved.";
            reason += "\nInsufficient balance.";
        }
        if (!loanStatus.HasPreviousLoans(person))
        {
            status = "Not approved.";
            reason += "\nAn old loan exists.";
        }

        return string.Concat(status, "\nRemarks if any:", reason);
    }
}

