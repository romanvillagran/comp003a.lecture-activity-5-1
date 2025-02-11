// Author: Roman
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Demonstrate the creation and usage of classes in C#

using System.Security.Cryptography.X509Certificates;

namespace comp003a.lecture_activity_5_1
{
    internal class Car
    {
        //fields
        private static int carCount = 0;
        public string Make;
        public string Model;
        public int Year;


        public string make
        {
            get { return make; }
            set { make = value; }
        }
        public string model
        {
            get { return model; }
            set { model = value; }
        }
        public int year
        {
            get { return year; }
            set { year = value; }
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            carCount++;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Year} {Make} {Model}");
        }
        public static void DisplayCarCount()
        {
            Console.WriteLine($"Total cars created: {carCount}");
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Civic", 2021);
            myCar.DisplayInfo();

            myCar.Make = "toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2020;
            myCar.DisplayInfo();

            Car myCar2 = new Car("Ford", "mustang", 2020);
            Car myCar3 = new Car("chevrolet", "camero", 2021);
            Car.DisplayCarCount();

        }
    }
}
