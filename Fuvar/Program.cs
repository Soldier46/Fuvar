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
            int Fuvar = 0;
            double viteldíj = 0;
           
            foreach (var i in EzANeveAlistanak)
            {
                if (i.TaxiId == 6185)
                {
                    viteldíj += i.borravalo;
                    Fuvar++;
                }
            }
            Console.WriteLine($"6185 ID-s taxisnak ennyi fuvarja volt : {Fuvar} és ennyi bevétele {viteldíj} ");
            
            
        }
    }
}
