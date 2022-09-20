using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class DBLayer
    {
        public List<Car> GetAllCars()//pretending to get this from db
        {
            List<Car> cars = new List<Car>();
            Car car = new Car();
            car.Name = "Ford";
            car.RegNumber = 123;

            Car car2 = new Car();
            car2.Name = "Volvo";
            car2.RegNumber = 321;

            cars.Add(car);
            cars.Add(car2);

            return cars;
        }
    }
}
