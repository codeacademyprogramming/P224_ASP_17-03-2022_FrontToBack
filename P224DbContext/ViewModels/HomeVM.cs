using P224DbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224DbContext.ViewModels
{
    public class HomeVM
    {
        public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }
        public List<StudentGroup> StudentGroups { get; set; }
    }
}
