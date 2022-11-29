Console.WriteLine("*** A demo that follows SRP.***");

Employee robin = new("Robin", "Smith", 7.5);

Helper.PrintEmployeeDetail(robin);
Helper.PrintEmployeeId(robin);
Helper.PrintSeniorityLevel(robin);

Console.WriteLine("*******");

Employee kevin = new("Kevin", "Proctor", 3.2);

Helper.PrintEmployeeDetail(kevin);
Helper.PrintEmployeeId(kevin);
Helper.PrintSeniorityLevel(kevin);

class Employee
{
    public string FirstName, LastName;
    public double ExperienceInYears;
    public Employee(
        string firstName,
        string lastName,
        double experience)
    {
        FirstName = firstName;
        LastName = lastName;
        ExperienceInYears = experience;
    }
  
    public void DisplayEmployeeDetail()
    {
        Console.WriteLine($"The employee name: {LastName}, {FirstName}");
        Console.WriteLine($"This employee has {ExperienceInYears} years of experience.");
    }
}
class SeniorityChecker
{
    public string CheckSeniority(double experienceInYears)
    {
        if (experienceInYears > 5)
            return "senior";
        else
            return "junior";
    }

}
class EmployeeIdGenerator
{
    public string Id = "Not generated yet";
    public string GenerateEmployeeId(string empFirstName)
    {
        int random = new Random().Next(1000);
        Id = string.Concat(empFirstName[0], random);
        return Id;
    }
}
class Helper
{
    public static void PrintEmployeeDetail(Employee emp)
    {
        emp.DisplayEmployeeDetail();
    }

    public static void PrintEmployeeId(Employee emp)
    {
        EmployeeIdGenerator idGenerator = new();
        string empId = idGenerator.GenerateEmployeeId(emp.FirstName);
        Console.WriteLine($"The employee id: {empId}");
    }
    public static void PrintSeniorityLevel(Employee emp)
    {
        SeniorityChecker seniorityChecker = new();
        string seniorityLevel = seniorityChecker.CheckSeniority(emp.ExperienceInYears);
        Console.WriteLine($"This employee is a {seniorityLevel} employee.");
    }
}


