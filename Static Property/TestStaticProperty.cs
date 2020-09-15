using System;

namespace Static_Property
{
    class TestStaticProperty
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mazda 3", "Skyactiv 3");
            Console.WriteLine(Car.numberOfCars);
            Console.WriteLine(car1.getName() + car1.getEngine());
            Car car2 = new Car("Mazda 6", "Skyactiv 6");
            Console.WriteLine(Car.numberOfCars);
            Console.WriteLine(car2.getName() + car2.getEngine());
            Console.ReadLine();
        }
    }
}
