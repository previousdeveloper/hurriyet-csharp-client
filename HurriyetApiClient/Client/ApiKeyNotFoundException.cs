using System;

namespace HurriyetApiClient
{
    public class ApiKeyNotFoundException : Exception
    {
        public ApiKeyNotFoundException()
            : base() { }

        public ApiKeyNotFoundException(string message)
            : base(message) { }

        public ApiKeyNotFoundException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public ApiKeyNotFoundException(string message, Exception innerException)
            : base(message, innerException) { }

        public ApiKeyNotFoundException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }
    }
}