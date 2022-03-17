﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P224Nest.Models
{
    public class Provide
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Content { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
    }
}