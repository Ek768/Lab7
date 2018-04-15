﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Skripka: Tovar
    {
        public string Marka_instrumenta { get; set; }
        public double Size { get; set; }
        public DateTime Release_data { get; set; }

        public Skripka(Nomenklatura ID, string Marka_instrumenta, double Size,double Price, DateTime Release_data):base (ID, Price)
        {
            this.Marka_instrumenta = Marka_instrumenta;
            this.Size = Size;
            this.Release_data = Release_data;
        }
        public override string tv()
        {
            return ID + ", " + Marka_instrumenta + ", " + Size + ", " + Price + ", " + Release_data.ToString("dd MMMM yyyy")  ;
        }
    }
}
