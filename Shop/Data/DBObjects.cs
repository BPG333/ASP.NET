using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
                 
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car { name = "Tesla", shortDesc = "Современный и технологичный", longDesc = "Крутой автомобиль со множеством наворотов", img = "/img/Tesla.jpg", price = 45000, isFavourite = true, available = true, Category = Categories["Электромобили"]},
                    new Car { name = "BMW M3", shortDesc = "Дерзкий и стильный", longDesc = "Удобный автомобиль для городской жизни", img = "/img/BMW M3.jpg", price = 35000, isFavourite = true, available = true, Category = Categories["Классические автомобили"] },
                    new Car { name = "Mercedes C class", shortDesc = "Уютный и просторный", longDesc = "Отличный вариант", img = "/img/Mercedes C.jpg", price = 25000, isFavourite = true, available = true, Category = Categories["Классические автомобили"] },
                    new Car { name = "Nissan Leaf", shortDesc = "Бесшумный и экономный", longDesc = "Имеет множество преимуществ для города", img = "/img/Nissan Leaf.jpg", price = 20000, isFavourite = true, available = true, Category = Categories["Электромобили"] }
                    );
            }

            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName = "Электромобили",desc = "Современный вид транспорта"},
                        new Category{categoryName = "Классические автомобили",desc = "Машины с двигателем внутреннего сгорания"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}
