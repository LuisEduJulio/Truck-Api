using System;
using Truck.Domain.Enums;

namespace Truck.Infraestructure.Exceptions
{
    public class ConflictException : CustomException
    {
        public ConflictException()
        {
        }

        public ConflictException(string message) : base(message)
        {
        }

        public ConflictException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ConflictException(string message, EExceptionType type) : base(message, type)
        {
        }

        public ConflictException(string message, Exception ex, EExceptionType type) : base(message, ex, type)
        {
        }
    }
}