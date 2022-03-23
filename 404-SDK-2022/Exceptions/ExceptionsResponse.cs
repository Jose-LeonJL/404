using System;
using System.Collections.Generic;
using System.Text;

namespace DVStudio.SDK.Exceptions
{
    public class ExceptionsResponse:Exception
    {
        public Data data { get; set; }
        public string status { get; set; }
        public int code { get; set; } 
        public struct Data { public string error { get; set; } }
    }
    public struct Exception2
    {
        public Data data { get; set; }
        public string status { get; set; }
        public int code { get; set; }
        public struct Data { public string error { get; set; } }
    }
}
