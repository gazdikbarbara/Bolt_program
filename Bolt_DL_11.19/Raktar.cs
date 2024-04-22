using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_DL_11._19_
{
    class Raktar
    {
        public List<Termek> Keszlet { get; }
        public List<Raktaros> Raktarosok { get; }
        private FileManager FM;

        public Raktar()
        {
            Keszlet = new List<Termek>();
            Raktarosok = new List<Raktaros>();
            FM = new FileManager();
        }

        public void AlkalmazottFelvetel(Raktaros raktaros)
        {
            Raktarosok.Add(raktaros);
        }

        public void AlkalmazottKirugas(Raktaros raktaros)
        {
            if (raktaros!=null)
            {
                Raktarosok.Remove(raktaros);
            }  
        }
        public void AlkalmazottKirugas(List<Raktaros> raktaros)
        {
            if (raktaros != null)
            {
                foreach (var r in raktaros)
                {
                    Raktarosok.Remove(r);
                }
            }
        }

        public Raktaros AlkalmazottValaszto()
        {
            Random r = new Random();
            int index = r.Next(0,Raktarosok.Count);
            return Raktarosok[index];
        }

       

        public void KeszletFeltolto(string path, Raktaros raktaros)
        {
            Keszlet.AddRange(raktaros.UjTermek(FM.ReadAllLines(path)));
        }
        public string[] LeltarKiiro(Raktaros raktaros)
        {
            return raktaros.LeltarKiiro(Keszlet);
        }

        public string LegnagyobbAr(Raktaros raktaros)
        {
            return raktaros.LegnagyobbAr(Keszlet);
        }

        public void LeltarMentes(string eleresiut, Raktaros raktaros)
        {
            FM.WriteAllLines(eleresiut, raktaros.LeltarMento(Keszlet));
        }

        public Termek LegolcsobbTermek(Raktaros raktaros)
        {
            return raktaros.LegolcsobbTermek(Keszlet);
        }
    }
}
