using System;
using System.Runtime.Serialization;

namespace Koshenya.Core.Exceptions
{
    internal class BadFrameFileNameException : Exception
    {
        private readonly string _directoryName;

        public BadFrameFileNameException() : base() { }

        public BadFrameFileNameException(string directoryName) : base()
        {
            _directoryName = directoryName;
        }

        public BadFrameFileNameException(string directoryName, string message) : base(message)
        {
            _directoryName = directoryName;
        }

        public BadFrameFileNameException(string directoryName, string message, Exception innerException) : base(message, innerException)
        {
            _directoryName = directoryName;
        }

        protected BadFrameFileNameException(string directoryName, SerializationInfo info, StreamingContext context) : base(info, context)
        {
            _directoryName = directoryName;
        }

        public string DirectoryName => _directoryName;
    }
}
