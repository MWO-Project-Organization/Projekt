using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWO
{
    public class CarController : ICarController
    {

        public readonly List<Car> _car = new()
        {
            new Car{Id=1,Brand="Audi",Model="A4",Price=322222}
        };

        private List<Car> cars = new();

        public bool CreateCar(Car car)
        {
            if(cars.Contains(car)) return false;
            cars.Add(car);
            return true;
        }

        public Car GetCar(int carId)
        {
            return cars.FirstOrDefault(x => x.Id == carId);
        }

        public bool RemoveCar(int carId)
        {
            if(cars.FirstOrDefault(x => x.Id == carId) is null) return false;
            cars.Remove(GetCar(carId));
            return true;
        }

        public bool UpdateCar(int carId, Car car)
        {
            if(cars.FirstOrDefault(x => x.Id == carId) is null) return false;
            cars.Remove(GetCar(carId));
            if(!CreateCar(car)) return false;
            return true;
        }
    }
}
