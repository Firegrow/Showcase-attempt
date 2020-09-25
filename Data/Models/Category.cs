using System.Collections.Generic;

namespace Business_card.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string descript { set; get; }
        public List<Car> cars { set; get; }
    }
}
