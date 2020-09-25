using Business_card.Data.Interfaces;
using Business_card.Data.Models;
using System.Collections.Generic;

namespace Business_card.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электрокары", descript = "Современный вид транспорта" },
                    new Category { categoryName = "ДВСкар", descript = "Классические автомобили с ДВС" }
                };

            }
        }
    }
}
