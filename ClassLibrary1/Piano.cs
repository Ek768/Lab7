using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Piano: Tovar
    {
        public string Firm { get; set; }
        public string Material { get; set; }
        public DateTime Release_data { get; set; }

        public Piano(Nomenklatura ID, string Firm, string Material, double Price, DateTime Release_data) : base(ID, Price)
        {
            this.Firm = Firm;
            this.Material = Material;
            this.Release_data = Release_data;
        }
        public override string tv()
        {
            return ID.ToString() + ", " + Firm.ToString() + ", " + Material.ToString() + ", " + Price.ToString() + ", " + Release_data.ToString("dd MMMM yyyy");
        }
    }
}
