using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224DbContext.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<StudentGroup> StudentGroups { get; set; }

    }
}
