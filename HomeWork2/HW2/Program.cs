using System;
using System.Diagnostics.CodeAnalysis;

namespace HW2
{
    public class Program
    {
        static void Main()
        {

            Car car = new Car("BatMobil", 500, 1968);
            PassengerCar passenger = new PassengerCar("Sokol1000", 600, 1980, 5);
            Truck truck = new Truck("teslaTruck", 1000, 2019, 800, "Elon");

            List<Car> cars = new List<Car>();
            cars.Add(car);
            cars.Add(passenger);
            cars.Add(truck);

            Autopark park = new Autopark("GlavniyAutoparkGalaktiki", cars);

        }

    }
}