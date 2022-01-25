using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            Console.WriteLine(osoba.DatumNarozeni);
            Console.WriteLine("Zadej datum narození:");
            DateTime datum = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(osoba.Vek());
        }
    }
}
