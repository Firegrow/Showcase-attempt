using Business_card.Data.Interfaces;
using Business_card.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business_card.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "TESLA",
                        shortDiscr="Бесшумная убийца",
                        longDiscr="Революционный электромобиль, призванный полностью уничтожить двигатель внутреннего сгорания и привить человечеству желание передвигаться исключительно  на экологически чистом транспорте",
                        img="https://110km.ru/attachment/9bef71e81d7da1df881ba957df2e12187a480b2f/6720421acca7ce1cef1cdee2dd3ca9a7.jpg",
                        price=45000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
