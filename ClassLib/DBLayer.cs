using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class DBLayer
    {
        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();
            Car car = new Car();
            car.ID = 1;
            car.Name = "Ford";
            car.RegNumber = 123;

            Car car2 = new Car();
            car2.ID = 2;
            car2.Name = "Volvo";
            car2.RegNumber = 321;

            cars.Add(car);
            cars.Add(car2);

            return cars;
        }
        public List<Plane> GetAllPlanes()
        {
            List<Plane> planes = new List<Plane>();
            Plane plane = new Plane();
            plane.ID = 1;
            plane.Type = "X-23";
            plane.RegNumber = 123;

            Plane plane2 = new Plane();
            plane2.ID = 2;
            plane2.Type = "X-24";
            plane2.RegNumber = 321;

            planes.Add(plane);
            planes.Add(plane2);

            return planes;
        }
    }
}
