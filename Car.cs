using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Car
    {
        public string Title { get; set; }
        public CategoryType Category { get; set; }
        public Teacher Driver { get; set; }

        public Car(string Title, CategoryType Category)
        {
            this.Title = Title;
            this.Category = Category;
        }
    }
}
