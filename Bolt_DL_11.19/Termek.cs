using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_DL_11._19_
{
    enum Kategoria
    {
        film, jatek, konyv, lego
    }


    class Termek
    {
        public int korhatar { get; }
        int ar;
        int ertekeles; //egy tizes skálán
        Kategoria kategoria; 
        public int ID { get; }


        public Termek(int id, int korhatar, int ar) 
        {
            this.korhatar = korhatar;
            this.ar = ar;
            ID = id;
            KategoriaValaszto();
        }

        public int AR()
        {
            return ar;
        }

        public int ERTEKELES()
        {
            return ertekeles;
        }

        public Kategoria KATEG()
        {
            return kategoria;
        }


        public void ErtekelesBeallito(int ertekeles)
        {
            this.ertekeles = ertekeles;
        }


        private void KategoriaValaszto()
        {
            kategoria = (Kategoria)korhatar;
        }
    }
}
