using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Tovar
    {
        public Nomenklatura ID { get; set; }
        public double Price { get; set; }

        public Tovar (Nomenklatura ID, double Price)
        {
            this.ID = ID;
            this.Price = Price;
        }
        public abstract string tv();

    }
}
