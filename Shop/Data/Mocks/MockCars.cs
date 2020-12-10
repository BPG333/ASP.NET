using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars{
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{name = "Tesla",shortDesc = "Современный и технологичный",longDesc = "Крутой автомобиль со множеством наворотов",img = "/img/Tesla.jpg",price = 45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "BMW M3",shortDesc = "Дерзкий и стильный",longDesc = "Удобный автомобиль для городской жизни",img="/img/BMW M3.jpg",price = 35000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.Last()},
                    new Car{name = "Mercedes C class",shortDesc = "Уютный и просторный",longDesc = "Отличный вариант",img="/img/Mercedes C.jpg",price = 25000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.Last()},
                    new Car{name = "Nissan Leaf",shortDesc = "Бесшумный и экономный",longDesc = "Имеет множество преимуществ для города",img="/img/Nissan Leaf.jpg",price = 20000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()}
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
