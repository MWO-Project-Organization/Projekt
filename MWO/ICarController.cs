using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWO
{
    public interface ICarController
    {
        bool CreateCar(Car car);
        Car GetCar(int carId);
        bool RemoveCar(int carId);
        bool UpdateCar(int carId, Car car);
    }
}
