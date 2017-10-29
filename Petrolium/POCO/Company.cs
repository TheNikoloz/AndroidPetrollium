using System;
using System.Collections.Generic;

namespace Petrolium.DataObjects
{
    public class Company
    {
        public IList<Details> Fuels { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
