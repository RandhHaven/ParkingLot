namespace EstacionamientoNetCore.ApiHelpers
{
    using System;
    public class MissingTokenException : Exception
    {
        public MissingTokenException(String message) : base(message)
        {
        }
    }
}
