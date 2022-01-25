using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class fuvar
    {
        public int TaxiId { get; set; }
        public DateTime indIdo { get; set; }
        public int utazasidotar { get; set; }

        public double megtávolság { get; set; }

        public double viteldíj { get; set; }

        public double borravalo { get; set; }

        public string fizetesmodja { get; set; }


        public fuvar(string valami)
        {
            string[] s = valami.Split(';');
            TaxiId = int.Parse(s[0]);
            indIdo = DateTime.Parse(s[1]);
            utazasidotar = int.Parse(s[2]);
            megtávolság = double.Parse(s[3]);
            viteldíj = double.Parse(s[4]);
            borravalo = double.Parse(s[5]);
            fizetesmodja = s[6];
        }
    }
}
