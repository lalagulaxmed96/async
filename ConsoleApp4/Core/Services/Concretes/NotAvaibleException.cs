using System.Runtime.Serialization;

namespace Core.Services.Concretes
{
    [Serializable]
    internal class NotAvaibleException : Exception
    {
        public NotAvaibleException()
        {
        }

        public NotAvaibleException(string? message) : base(message)
        {
        }

        public NotAvaibleException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotAvaibleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}