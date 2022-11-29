using System.Runtime.Serialization;
Console.WriteLine("Chapter 10.Demo-4.");

Console.WriteLine("***A case study on exception filters.***");
try
{
    int a = 10;
    // Returns a random number between 0(inclusive)
    // and 2(exclusive)
    int b = new Random().Next(0, 2);
    Console.WriteLine($"b={b}");
    int c = b > 0 ? throw new CustomWebException("Protocol error") :
                    throw new CustomWebException("Temporary error");
    Console.WriteLine("Thank you.");
}
catch (Exception ex) when (ex.Message.Contains("Protocol"))
{
    Console.WriteLine($"Caught: {ex.GetType()}");
    Console.WriteLine($"Exception message: {ex.Message}");
}

catch (Exception ex) when (Logger.Log(ex))
{
}
finally
{
    // Some clean-up code
}

class Logger
{
    public static bool Log(Exception ex)
    {
        Console.WriteLine($"Logging the following exception.:");
        Console.WriteLine($"Caught: {ex.GetType()}");
        Console.WriteLine($"Exception message: {ex.Message}");
        return false;
    }
}



[Serializable]
public class CustomWebException : Exception
{
    public CustomWebException()
    {
    }

    public CustomWebException(string? message) : base(message)
    {
    }

    public CustomWebException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected CustomWebException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}