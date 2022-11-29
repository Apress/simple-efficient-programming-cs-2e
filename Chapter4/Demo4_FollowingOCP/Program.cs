Console.WriteLine("*** A demo that follows OCP.***");
List<Student> scienceStudents = Helper.MakeScienceStudentList();
List<Student> artsStudents = Helper.MakeArtsStudentList();

Console.WriteLine("===Results:===");
foreach (Student student in scienceStudents)
{
    Console.WriteLine(student);
}
foreach (Student student in artsStudents)
{
    Console.WriteLine(student);
}


Console.WriteLine("===Distinctions:===");

// For the Science stream students.
IDistinctionDecider distinctionDecider = new ScienceDistinctionDecider();
foreach (Student student in scienceStudents)
{
    distinctionDecider.EvaluateDistinction(student);
}

// For the Arts stream students.
distinctionDecider = new ArtsDistinctionDecider();
foreach (Student student in artsStudents)
{
    distinctionDecider.EvaluateDistinction(student);
}
class Student
{
    internal string name;
    internal string registrationNumber;
    internal double score;
    public Student(
      string name,
      string registrationNumber,
      double score)
    {
        this.name = name;
        this.registrationNumber = registrationNumber;
        this.score = score;

    }
    public override string ToString()
    {
        return ($"""
        Name: {name}
        Reg Number: {registrationNumber}        
        Score: {score}
        *******
        """);
    }
}

interface IDistinctionDecider
{
    void EvaluateDistinction(Student student);
}
class ArtsDistinctionDecider : IDistinctionDecider
{
    public void EvaluateDistinction(Student student)
    {
        if (student.score > 70)
        {
            Console.WriteLine($"{student.registrationNumber} has received a distinction in arts.");
        }
    }
}

class ScienceDistinctionDecider : IDistinctionDecider
{
    public void EvaluateDistinction(Student student)
    {
        if (student.score > 80)
        {
            Console.WriteLine($"{student.registrationNumber} has received a distinction in science.");
        }
    }
}

class Helper
{
    public static List<Student> MakeScienceStudentList()
    {
        Student sam = new("Sam", "R001", 81.5);
        Student bob = new("Bob", "R002", 72);
        List<Student> students = new()
        {
            sam,
            bob
        };
        return students;
    }
    public static List<Student> MakeArtsStudentList()
    {
        Student john = new("John", "R003", 71);
        Student kate = new("Kate", "R004", 66.5);
        List<Student> students = new()
        {
            john,
            kate
        };
        return students;
    }
}


