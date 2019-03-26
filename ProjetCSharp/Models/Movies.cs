using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetCSharp.Models
{

    public class Movies
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Status status { get; set; }
    }

    public enum Status
    {
        Enabled,
        Disabled,
        Unknown
    }
}
