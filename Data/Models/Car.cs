using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_card.Data.Models
{
    public class Car
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDiscr { set; get; }
        public string longDiscr { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isFavourite { set; get; }
        public bool available { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
