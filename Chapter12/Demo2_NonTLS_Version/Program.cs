namespace Demo2_NonTLS_Version
{
    class Sample : IDisposable
    {
        public void SomeMethod()
        {
            Console.WriteLine("Sample's SomeMethod is invoked.");
        }
        public void Dispose()
        {
            // GC.SuppressFinalize(this);
            Console.WriteLine("Sample's Dispose() is called");
            // Release unmanaged resource(s) if any
        }
        ~Sample()
        {
            Console.WriteLine("Sample's Destructor is called.");

        }
    }
    class A : IDisposable
    {
        public A()
        {
            Console.WriteLine("Inside A's constructor.");

            //using (Sample sample = new Sample())
            //{
            //    sample.SomeMethod();
            //}
            // Simplified statement (C# 8 onwards it works).            
            using Sample sample = new();
            sample.SomeMethod();
        }
        public void Dispose()
        {
            //GC.SuppressFinalize(this);
            Console.WriteLine("A's Dispose() is called.");
            // Release any other resource(s)
        }
        ~A()
        {
            Console.WriteLine("A's Destructor is Called.");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Exploring the Dispose() method.***");
            A obA = new();
            obA = null;
            Console.WriteLine("GC is about to start.");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("GC is completed.");
            Console.ReadKey();
        }
    }

}
