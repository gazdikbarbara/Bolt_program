using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_DL_11._19_
{
    internal class Alkalmazott 
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public int Fizetes { get; set; }

        public Alkalmazott(string nev, int eletkor, int fizetes)
        {
            AlkalmazottFelvétel(nev, eletkor, fizetes);
        }

        private void AlkalmazottFelvétel(string nev, int eletkor, int fizetes)
        {
            Nev = nev;
            Eletkor = eletkor;
            Fizetes = fizetes;
        }

        public string AlkalmazottAdatok()
        {
            return $"Név: {Nev}\tÉletkor: {Eletkor.ToString()}\tFizetés: {Fizetes.ToString()}";
        }


    }
}
