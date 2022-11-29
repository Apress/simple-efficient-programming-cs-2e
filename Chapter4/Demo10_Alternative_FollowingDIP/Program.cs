Console.WriteLine("***Alternative version of Demo-10.***");

// Using Oracle now
IDatabase database = new OracleDatabase();
UserInterface userInterface = new(database);
userInterface.SaveEmployeeId("E001");

// Using MySQL now
database = new MySQLDatabase();
userInterface = new UserInterface(database);
userInterface.SaveEmployeeId("E002");

// Additional code for demonstration purpose
userInterface.Database = new OracleDatabase();
userInterface.SaveEmployeeId("E003");


class UserInterface
{
    //readonly IDatabase database;
    public IDatabase Database { get; set; }
    public UserInterface(IDatabase database)
    {
        //this.database = database;
        this.Database = database;
    }
    public void SaveEmployeeId(string empId)
    {
        //database.SaveEmpIdInDatabase(empId);
        Database.SaveEmpIdInDatabase(empId);
    }
}

interface IDatabase
{
    void SaveEmpIdInDatabase(string empId);
}
class OracleDatabase : IDatabase
{
    public void SaveEmpIdInDatabase(string empId)
    {
        Console.WriteLine($"The id: {empId} is saved in the Oracle database.");
    }
}

class MySQLDatabase : IDatabase
{
    public void SaveEmpIdInDatabase(string empId)
    {
        Console.WriteLine($"The id: {empId} is saved in the MySQL database.");
    }
}




