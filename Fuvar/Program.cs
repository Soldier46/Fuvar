using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fuvar
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Class1> EzANeveAlistanak = new List<Class1>();
            foreach (var b in File.ReadAllLines("fuvar.csv").Skip(1)) 
            {
                EzANeveAlistanak.Add(new Class1(b));
            }

            Console.WriteLine($"3.feladat : {EzANeveAlistanak.Count} Fuvar került feljegyzésre ");
            double dij = 0;
            int fuvar = 0;
            
           
            foreach (var i in EzANeveAlistanak)
            {
                if (i.TaxiId == 6185)
                {
                    dij += i.borravalo;
                    fuvar++;
                }
            }
            Console.WriteLine($"6185 ID-s taxisnak ennyi fuvarja volt : {fuvar} és ennyi bevétele {dij} ");

            int bank = 0;
            int kp = 0;
            int free = 0;
            int idk = 0;
            foreach (var i in EzANeveAlistanak)
            {
                if (i.fizetesmodja == "bankkártya")
                {
                    bank++;
                    
                }

                else if (i.fizetesmodja == "készpénz")
                {
                    kp++;
                }
                else if (i.fizetesmodja == "ingyen")
                {
                    free++;
                }
                else if (i.fizetesmodja == "ismeretlen")
                {
                    idk++;
                }
               
               
            }
            Console.WriteLine($"5.feladat:");
            Console.WriteLine($"\tbankártya: {bank} fuvar");
            Console.WriteLine($"\tkészpénz: {kp} fuvar");
            Console.WriteLine($"\tingyenes: {free} fuvar");
            Console.WriteLine($"\tismeretlen: {idk} fuvar");

            double k = 0;
            foreach (var i in EzANeveAlistanak)
            {
                k += i.megtávolság * 1.6;
            }
            Console.WriteLine("6.feladat : {0:0.00}km",k);

        }
    }
}
