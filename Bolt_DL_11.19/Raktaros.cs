using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_DL_11._19_
{
    class Raktaros : Alkalmazott, IEmber
    {
        public int Penz { get; }
        public Raktaros(string nev, int eletkor, int fizetes, int penz) : base(nev, eletkor, fizetes)
        {

        }


        public Termek[] UjTermek(string[] lines)
        {
            Termek[] termekek = new Termek[lines.Length];
            for (int i = 0; i < termekek.Length; i++)
            {
                string[] aktualissor = lines[i].Split(' ');
                termekek[i] = new Termek(int.Parse(aktualissor[0]), int.Parse(aktualissor[1]), int.Parse(aktualissor[2]));
                termekek[i].ErtekelesBeallito(int.Parse(aktualissor[3]));
            }
            return termekek;
        }

        public List<string> LeltarMento(List<Termek> keszlet)
        {
            List<string> tartalom = new List<string>();
            foreach (var termek in keszlet)
            {
                tartalom.Add($"{termek.ID} {termek.korhatar} {termek.AR()} {termek.ERTEKELES()}");

            }
            return tartalom;
        }

        public string[] LeltarKiiro(List<Termek> keszlet)
        {
            string[] tartalom = new string[keszlet.Count];
            for (int i = 0; i < keszlet.Count; i++)
            {
                tartalom[i] = $"Az {i + 1}. polc tartalma korhatár: {keszlet[i].korhatar}, ár: {keszlet[i].AR()}, értékelés: {keszlet[i].ERTEKELES()}, a termék maga: {keszlet[i].KATEG()}.";
            }
            return tartalom;
        }

        public string LegnagyobbAr(List<Termek> polc)
        {
            int max = 0;
            for (int i = 1; i < polc.Count; i++)
            {
                if (polc[max].AR() < polc[i].AR())
                {
                    max = i;
                }
            }
            return $"A legdrágább termék: korhatár: {polc[max].korhatar}, ár: {polc[max].AR()}, értékelés: {polc[max].ERTEKELES()}, a termék maga: {polc[max].KATEG()}.";
        }

        public Termek LegolcsobbTermek(List<Termek> polc)
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
    }
}
