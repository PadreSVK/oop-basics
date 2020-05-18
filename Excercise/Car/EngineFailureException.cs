using System;

namespace Excercise
{
    public class EngineFailureException : CarFailureExceptionBase
    {
        public EngineFailureException(string message) : base(message)
        {
        }

        public EngineFailureException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
