using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class AutoSchool
    {
        public string Title { get; set; }
        public List<Teacher> Teacher { get; set; }
        public List<Car> Car { get; set; }

        public AutoSchool(string Title)
        {
            this.Title = Title;
        }

    }
}
