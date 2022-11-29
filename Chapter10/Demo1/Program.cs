using RemoteNumberProcessor;

Console.WriteLine("Chapter 10.Demo-1.");
// Testing the input values:39,-2,57,150
//RemoteProcessor processor = new(39);
//RemoteProcessor processor = new(-2);
RemoteProcessor processor = new(57);
//RemoteProcessor processor = new(150);
try
{
    processor.ProcessNumber();
}
catch (NumberTooSmallException e)
{
    Console.WriteLine("Supplied number is too small.");
    Console.WriteLine($"Logging the error: {e}");
}
catch (NumberTooBigException e)
{
    Console.WriteLine("Supplied number is too big.");
    Console.WriteLine($"Logging the error: {e}");
}
catch (ReservedNumberException e)
{
    Console.WriteLine("Tried to use a special number.");
    Console.WriteLine($"Logging the error: {e}");
}

finally
{
    // Some clean-up code
}