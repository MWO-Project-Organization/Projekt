using System.Linq;
using System.Collections.Generic;

namespace MWO;

public class CarController : ICarController
{
    public CarController()
    {
        _cars = new List<Car>();
    }

    private List<Car> _cars;

    bool CreateCar(Car car)
    {
        _cars.Add(car);
        return true;
    }

    Car GetCar(int carId)
    {
        return _cars.FirstOrDefault(c => c.Id == carId);
    }

    bool RemoveCar(int carId)
    {
        _cars.Remove(_cars.FirstOrDefault(c => c.Id == carId));
        return true;
    }
    bool UpdateCar(int carId, Car car)
    {
        _cars[_cars.IndexOf(_cars.FirstOrDefault(c => c.Id == carId))] = car;
        return true;
    }
}