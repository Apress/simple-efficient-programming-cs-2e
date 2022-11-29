namespace Demo_DisposePatternSample
{
    class Sample : IDisposable
    {
        bool _disposedAlready = false;
        protected virtual void Dispose(bool disposing)
        {
            // Checking whether the object
            // is already disposed
            if (_disposedAlready)
            {
                return;
            }
            if (disposing)
            {
                // Some code to dispose managed objects
            }
            // Dispose the unmanaged objects 
            // and large files(if any) here
            _disposedAlready = true;
        }

        public void Dispose()
        {
            // Dispose the unmanaged resources
            Dispose(true);
            // Supress the finalizer call
            // to tell: "GC, you do not need
            // to do anything more."
            GC.SuppressFinalize(this);
        }
        ~Sample()
        {
            Dispose(false);
        }
        // Some other code
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}