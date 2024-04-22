using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_DL_11._19_
{
    class Elado : Alkalmazott, IEmber
    {
        public int Penz { get; }

        public Elado(string nev, int eletkor, int fizetes, int penz) : base(nev, eletkor, fizetes)
        {
            Penz = penz;
        }

        private Termek LegOlcsobbTermek(List<Termek> polc)
        {
            int min = 0;
            for (int i = 1; i < polc.Count; i++)
            {
                if (polc[min].AR() > polc[i].AR())
                {
                    min = i;
                }
            }
            return polc[min];

        }

        public List<string> Elad(Vevo vevo, List<Termek> keszlet)
        {
            List<string> blokk = new List<string>();
            if (keszlet.Count > 0)
            {
                while (vevo.Penz >= LegOlcsobbTermek(keszlet).AR())
                {
                    Termek t = LegOlcsobbTermek(keszlet);
                    vevo.Vasarol(t);
                    blokk.Add($"A eladott termék azonosítója: {t.ID} a vásárló: {vevo.Nev} az eladó: {this.Nev}!");
                    keszlet.Remove(t);
                    if (keszlet.Count <= 0)
                    {
                        return blokk;
                    }
                }
            }
            else blokk.Add($"Nem volt készlet {vevo.Nev} számára.");
            
            return blokk;

        }
    }
}
