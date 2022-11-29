using System.Runtime.Serialization;

namespace RemoteNumberProcessor
{
    public class RemoteProcessor
    {
        private int _number;
        public RemoteProcessor(int number)
        {
            _number = number;
            // Some other code, if any
        }
        public void ProcessNumber()
        {
            if (_number < 0)
                throw new NumberTooSmallException($"The input {_number} is less than the lower boundary(00.");
            else if (_number > 100)
                throw new NumberTooBigException($"The input {_number} is greater than the upper boundary (100).");
            else if (50 < _number && _number < 60)
                throw new ReservedNumberException($"The input is {_number}.The numbers 51 to 59 are reserved for special uses.");
            else
                Console.WriteLine($"The input {_number} is valid. Processing it.");
        }
    }

    [Serializable]
    public class ReservedNumberException : Exception
    {
        public ReservedNumberException()
        {
        }

        public ReservedNumberException(string? message) : base(message)
        {
        }
        //public ReservedNumberException(string? message, Exception? innerException) : base(message, innerException)
        //{
        //}

        //protected ReservedNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }

    [Serializable]
    public class NumberTooBigException : Exception
    {
        public NumberTooBigException()
        {
        }

        public NumberTooBigException(string? message) : base(message)
        {
        }

        //public NumberTooBigException(string? message, Exception? innerException) : base(message, innerException)
        //{
        //}

        //protected NumberTooBigException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }

    [Serializable]
    public class NumberTooSmallException : Exception
    {
        //public NumberTooSmallException()
        //{
        //}

        public NumberTooSmallException(string? message) : base(message)
        {
        }

        //public NumberTooSmallException(string? message, Exception? innerException) : base(message, innerException)
        //{
        //}

        //protected NumberTooSmallException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }
}