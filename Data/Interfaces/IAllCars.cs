using Business_card.Data.Models;
using System.Collections.Generic;

namespace Business_card.Data.Interfaces
{
    interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; set; }
        Car getObjectCar(int carID);
    }
}
