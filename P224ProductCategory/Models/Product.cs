using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224ProductCategory.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
