Console.WriteLine("*** A demo without OCP.***");
List<Student> enrolledStudents = Helper.MakeStudentList();

// Display results.
Console.WriteLine("===Results:===");
foreach (Student student in enrolledStudents)
{
    Console.WriteLine(student);
}

// Evaluate distinctions.
DistinctionDecider distinctionDecider = new();
Console.WriteLine("===Distinctions:===");
foreach (Student student in enrolledStudents)
{
    distinctionDecider.EvaluateDistinction(student);
}


class Student
{
    internal string name;
    internal string registrationNumber;
    internal string department;
    internal double score;
    public Student(
     string name,
     string registrationNumber,
     double score,
     string department)
    {
        this.name = name;
        this.registrationNumber = registrationNumber;
        this.score = score;
        this.department = department;
    }

    // Using C# 11 feature: Raw string literals
    public override string ToString()
    {
        return ($"""
        Name: {name}
        Reg Number: {registrationNumber}
        Dept: {department}
        Score: {score}
        *******
        """);
    }
}
class DistinctionDecider
{
    public void EvaluateDistinction(Student student)
    {

        if (student.department == "Science")
        {
            if (student.score > 80)
            {
                Console.WriteLine($"{student.registrationNumber} has received a distinction in science.");
            }
        }

        if (student.department == "Arts")
        {
            if (student.score > 70)
            {
                Console.WriteLine($"{student.registrationNumber} has received a distinction in arts.");
            }
        }
    }
}

class Helper
{
    public static List<Student> MakeStudentList()
    {
        Student sam = new("Sam", "R001", 81.5, "Science");
        Student bob = new("Bob", "R002", 72, "Science");
        Student john = new("John", "R003", 71, "Arts");
        Student kate = new("Kate", "R004", 66.5, "Arts");
        List<Student> students = new()
        {
            sam,
            bob,
            john,
            kate
        };
        return students;
    }
}


