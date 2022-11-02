using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWO
{
    internal class CarController : ICarController
    {
        private readonly List<Car> _car = new()
        {
            new Car{Id=1,Brand="Audi",Model="A4",Price=322222}
        };
        public bool CreateCar(Car car)
        {
            _car.Add(new Car { Price=car.Price, Model=car.Model});
            return true;
        }

        public Car GetCar(int carId)
        {
            return _car.Where(c=>c.Id==carId).SingleOrDefault();
        }

        public bool RemoveCar(int carId)
        {
            _car.RemoveAt(carId);
            return true;
        }

        public bool UpdateCar(int carId, Car car)
        {
           // var index = _car.FindIndex(c=>c.Id== carId);
            _car[carId]=car;
            return true;
        }
    }
}
