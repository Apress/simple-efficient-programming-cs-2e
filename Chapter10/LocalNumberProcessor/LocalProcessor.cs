using RemoteNumberProcessor;
using System.Runtime.Serialization;

namespace LocalNumberProcessor
{
    public class LocalProcessor
    {
        private RemoteProcessor processor;
        public LocalProcessor(int number)
        {
            processor = new RemoteProcessor(number);
        }
        public void ProcessNumber()
        {
            try
            {
                processor.ProcessNumber();
            }
            catch (NumberTooSmallException e)
            {
                throw new InvalidInputException(e.Message);
            }
            catch (NumberTooBigException e)
            {
                throw new InvalidInputException(e.Message);
            }
            catch (ReservedNumberException e)
            {
                throw new InvalidInputException(e.Message);
            }

            finally
            {
                // Some clean up code
            }
        }
    }

    [Serializable]
    public class InvalidInputException : Exception
    {
        public InvalidInputException()
        {
        }

        public InvalidInputException(string? message) : base(message)
        {
        }

        public InvalidInputException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidInputException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    
}