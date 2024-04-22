using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_DL_11._19_
{
    class Vevo : IEmber
    {
        public int Penz { get; set; }
        public string Nev { get; }
        public List<Termek> BevKosar { get; }

        public Vevo(int penz, string nev)
        {
            BevKosar = new List<Termek>();
            Penz = penz;
            Nev = nev;
        }

        public void Vasarol(Termek termek)
        {
            BevKosar.Add(termek);
            Penz = Penz - termek.AR();
        }
    }
}
