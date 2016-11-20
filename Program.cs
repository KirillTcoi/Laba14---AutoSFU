using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary;

namespace AutoSFU
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AutoSchool Sfu = new AutoSchool("SFU");
                Sfu.Car = new List<Car>();
                Sfu.Teacher = new List<Teacher>();
                Sfu.Car.Add ( new Car("LADA SEDAN", CategoryType.B));
                Sfu.Car.Add ( new Car("LADA BOMBA", CategoryType.B));
                Sfu.Car.Add ( new Car("LADA YAMBA", CategoryType.B));
                Sfu.Car.Add ( new Car("Gazelka", CategoryType.C));

                Sfu.Teacher.Add ( new Teacher("Trump", CategoryType.B, true ) { Car = Sfu.Car[0]});
                Sfu.Car[0].Driver = Sfu.Teacher[0];
                Sfu.Teacher.Add(new Teacher("Putin", CategoryType.C, true) { Car = Sfu.Car[3] });
                Sfu.Car[3].Driver = Sfu.Teacher[1];

                Manager.SetVocation(Sfu.Teacher[1]);
                Manager.SetInstructor(Sfu.Teacher[0], Sfu.Car[3]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
