// Console.WriteLine("Chapter 12. Demo-1.");
Console.WriteLine("***Exploring Garbage Collections.***");
try
{
    Console.WriteLine($"Maximum GC Generation is {GC.MaxGeneration}");
    Sample sample = new();
    GCHelper.CheckObjectStatus(sample);

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"\n After GC.Collect({i})");
        GC.Collect(i, GCCollectionMode.Forced, false, true);
        System.Threading.Thread.Sleep(10000);
        GC.WaitForPendingFinalizers();
        GCHelper.ShowAllocationStatus();
        GCHelper.CheckObjectStatus(sample);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error:" + ex.Message);
}

class Sample
{
    public Sample()
    {
        // Some code            
    }
}

class GCHelper
{
    public static void CheckObjectStatus(Sample sample)
    {
        if (sample is not null) // C# 9.0 onwards
        {
            Console.WriteLine($" The {sample} object is in Generation:{GC.GetGeneration(sample)}");
        }
    }

    public static void ShowAllocationStatus()
    {
        Console.WriteLine("---------");
        Console.WriteLine($"Gen-0 collection count:{GC.CollectionCount(0)}");
        Console.WriteLine($"Gen-1 collection count:{GC.CollectionCount(1)}");
        Console.WriteLine($"Gen-2 collection count:{GC.CollectionCount(2)}");
        Console.WriteLine($"Total Memory allocation:{GC.GetTotalMemory(false)}");
        Console.WriteLine("---------");
    }
}


