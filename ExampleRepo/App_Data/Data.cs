using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using ExampleCommon.Interfaces;

namespace ExampleRepo
{
    public class ExampleDTO : IExampleData
    {
        public int routine { get; set; }
        public int gummieBears { get; set; }
        public int recipients { get; set; }
        public string mode { get; set; }
    }
}