using Business_card.Data.Models;
using System.Collections.Generic;

namespace Business_card.Data.Interfaces
{
    interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
