Console.WriteLine("*** A demo without SRP.***");
Employee robin = new("Robin", "Smith", 7.5);
robin.DisplayEmployeeDetail();
string empId = robin.GenerateEmployeeId(robin.FirstName);
Console.WriteLine($"The employee id: {empId}");

Console.WriteLine($"This employee is a " +
    $"{robin.CheckSeniority(robin.ExperienceInYears)} employee.");

Console.WriteLine("*******");

Employee kevin = new("Kevin", "Proctor", 3.2);
kevin.DisplayEmployeeDetail();
empId = kevin.GenerateEmployeeId(kevin.FirstName);
Console.WriteLine($"The employee id: {empId}");
Console.WriteLine($"This employee is a " +
    $"{kevin.CheckSeniority(kevin.ExperienceInYears)} employee.");

class Employee
{
    public string FirstName, LastName;
    public string Id;
    public double ExperienceInYears;
    public Employee(
        string firstName,
        string lastName,
        double experience)
    {
        FirstName = firstName;
        LastName = lastName;
        ExperienceInYears = experience;
        Id = "Not generated yet";
    }
    public void DisplayEmployeeDetail()
    {
        Console.WriteLine($"The employee name: {LastName}, {FirstName}");
        Console.WriteLine($"This employee has {ExperienceInYears} years of experience.");
    }

    public string CheckSeniority(double experienceInYears)
    {
        if (experienceInYears > 5)
            return "senior";
        else
            return "junior";
    }
    public string GenerateEmployeeId(string empFirstName)
    {
        int random = new Random().Next(1000);
        Id = string.Concat(empFirstName[0], random);
        return Id;
    }
}

