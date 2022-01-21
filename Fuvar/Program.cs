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
            

            
            
        }
    }
}
