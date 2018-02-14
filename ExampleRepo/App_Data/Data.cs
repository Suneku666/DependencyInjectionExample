using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using ExampleCommon.Interfaces;

namespace ExampleRepo
{
    public class ExampleDTO : IExampleData
    {
        public int gunTemp { get; set; }
        public int rounds { get; set; }
        public int targets { get; set; }
        public string mode { get; set; }
    }
}