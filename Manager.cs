using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public static class Manager
    {
        public static void SetVocation(Teacher Teacher)
        {
            Teacher.Car.Driver = null;
            Teacher.Car = null;
            Teacher.IsWorked = false;
        }
        public static void SetInstructor(Teacher Teach, Car car)
        {
            if (Teach.Category == car.Category)
            {
                Teach.Car.Driver = null;
                car.Driver = Teach;
                Teach.Car = car;
            }
            else throw new Exception("You are retard");

        }
    }
}
