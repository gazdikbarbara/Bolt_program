using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_DL_11._19_
{
    class Bolt
    {
        public List<Vevo> Vevok { get; set; }
        public List<Elado> Eladok { get; }

        public Raktar Raktar { get; }

        public Bolt()
        {
            Vevok = new List<Vevo>();
            Eladok = new List<Elado>();
            Raktar = new Raktar();
        }

        public void AlkalmazottFelvetel<T>(T alkalmazott)//string nev, int eletkor, int fizetes, int penz)
        {
            if (alkalmazott.GetType() == typeof(Elado) )
            {
                Eladok.Add(alkalmazott as Elado); 
            }
            else if (alkalmazott.GetType() == typeof(Raktaros))
            {
                Raktar.AlkalmazottFelvetel(alkalmazott as Raktaros);
            }
            
        }

        public void AlkalmazottKirugas(Elado elado)
        {
            if (elado != null)
            {
                Eladok.Remove(elado);
            }
        }
        public void AlkalmazottKirugas(List<Elado> eladok)
        {
            if (eladok != null)
            {
                foreach (var e in eladok)
                {
                    Eladok.Remove(e);
                }
            }
        }

        public Elado AlkalmazottValaszto()
        {
            Random r = new Random();
            int index = r.Next(0, Eladok.Count);
            return Eladok[index];
        }


        public Vevo VevoValaszto()
        {
            Random r = new Random();
            int index = r.Next(0, Vevok.Count);
            return Vevok[index];
        }

        public List<string> Elad()
        {
            Vevo  v = VevoValaszto();
            List<string> list = AlkalmazottValaszto().Elad(v, Raktar.Keszlet);
            Vevok.Remove(v);
            return list;
            

        }
    }
}
