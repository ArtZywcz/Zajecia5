using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajecia5.Props;

namespace Zajecia5
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new TPHContext();
            tph.Computers.Add(new Laptop() { price = 1000, description = "Standard Laptop", weight = 3 });
            tph.SaveChanges();
            var tpt = new TPTContext();
            tpt.Computers.Add(new Laptop() { price = 1000, description = "Standard Laptop", weight = 1 });
            tpt.SaveChanges();
            var tpc = new TPTContext();
            tpc.Computers.Add(new Laptop() { price = 1000, description = "Standard Laptop", weight = 1 });
            tpc.SaveChanges();
        }
    }
}
