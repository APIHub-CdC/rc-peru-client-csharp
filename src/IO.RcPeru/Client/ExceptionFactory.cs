using System;
using RestSharp;

namespace IO.RcPeru.Client
{
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
