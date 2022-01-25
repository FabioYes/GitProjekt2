using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2
{
    class Osoba
    {
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }

        public string Vek()
        {
            DateTime Dnes = DateTime.Now;
            return ((Dnes - DatumNarozeni).ToString("y"));
        }

    }
}
