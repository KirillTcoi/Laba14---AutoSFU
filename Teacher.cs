using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Teacher
    {
        public string Name { get; set; }
        public CategoryType Category { get; set; }
        public Car Car { get; set; }
        public bool IsWorked { get; set; } 
        public Teacher(string Nameq, CategoryType Categoryq, bool IsWorkeds)
        {
            this.Name = Nameq;
            this.Category = Categoryq;
            this.IsWorked = IsWorkeds;
        }
    }
}
