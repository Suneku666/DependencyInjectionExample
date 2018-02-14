using System;
using System.Net;

namespace ExampleCommon.Exceptions
{
    public abstract class ExampleException : Exception
    {
        public abstract HttpStatusCode GetStatusCode();
    }

    public class ExampleStatusNotFound : ExampleException
    {
        public override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.NotFound;
        }
    }

    public class IllegalExampleUserException :  ExampleException
    {
        public override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.Unauthorized;
        }
    }

    
}