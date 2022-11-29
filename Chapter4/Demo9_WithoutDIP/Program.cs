Console.WriteLine("***A demo without DIP.***");
UserInterface userInterface = new();
userInterface.SaveEmployeeId("E001");

class UserInterface
{
    readonly OracleDatabase oracleDatabase;
    public UserInterface()
    {
        this.oracleDatabase = new OracleDatabase();
    }
    public void SaveEmployeeId(string empId)
    {
        // Assuming that this is valid data.
        // So, storing it in the database.
        oracleDatabase.SaveEmpIdInDatabase(empId);
    }

}
class OracleDatabase
{
    public void SaveEmpIdInDatabase(string empId)
    {
        Console.WriteLine($"The id: {empId} is saved in the oracle database.");
    }
}



