using System;

namespace Excercise
{
    public class MaxSpeedExceededException : CarFailureExceptionBase
    {
        public MaxSpeedExceededException(string message) : base(message)
        {
        }

        public MaxSpeedExceededException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
