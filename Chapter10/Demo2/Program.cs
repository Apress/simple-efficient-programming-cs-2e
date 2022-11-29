using LocalNumberProcessor;

Console.WriteLine("Chapter 10.Demo-2.");
//LocalProcessor processor = new(39);
//LocalProcessor processor = new(-2);
LocalProcessor processor = new(57);
//LocalProcessor processor = new(150);

try
{
    processor.ProcessNumber();
}
catch (InvalidInputException e)
{
    Console.WriteLine("Invalid number.");
    Console.WriteLine($"Logging the error: {e}");
}
finally
{
    // Some clean-up code
}


