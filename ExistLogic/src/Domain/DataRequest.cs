using System;
using System.Collections.Generic;

namespace ExistLogic.Domain
{
    public class DataRequest
    {
        public int? Limit { get; set; }
        public IEnumerable<string> Attributes { get; set; }
        public DateTime? DateMin { get; set; }
        public DateTime? DateMax { get; set; }
    }
}