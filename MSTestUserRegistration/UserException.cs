﻿using System;
using System.Runtime.Serialization;

namespace MSTestUserRegistration
{
    [Serializable]
    internal class UserException : Exception
    {
        public UserException()
        {
        }

        public UserException(string message) : base(message)
        {
        }

        public UserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}