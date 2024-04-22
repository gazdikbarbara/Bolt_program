using System;

namespace Bolt_DL_11._19_
{
    class Program
    {
        public static void TombKiiro(string[] tomb)
        {
            foreach (var line in tomb)
            {
                Console.WriteLine(line);
            }
        }
        public static void Kiiro(string szoveg)
        {
            Console.WriteLine(szoveg);
        }

        static void Main(string[] args)
        {
            string[] paths = new string[] { "raktar_keszlet_1.txt", "raktar_keszlet_2.txt"};
            
            Bolt b = new Bolt();
            b.AlkalmazottFelvetel<Raktaros>(new Raktaros("Béla", 30, 130000, 0));
            b.AlkalmazottFelvetel<Raktaros>(new Raktaros("Sándor", 27, 257000, 0));
            b.AlkalmazottFelvetel<Raktaros>(new Raktaros("Péter", 34, 256000, 0));
            b.AlkalmazottFelvetel<Elado>(new Elado("Barbara", 26, 350000,0));
            b.AlkalmazottFelvetel<Elado>(new Elado("Bence", 21, 350000, 0));
            b.AlkalmazottFelvetel<Elado>(new Elado("Anna", 31, 290000, 0));
            b.Vevok.Add(new Vevo(5000000, "Judit"));
            b.Vevok.Add(new Vevo(4000, "Károly"));
            
            b.Raktar.KeszletFeltolto(paths[0], b.Raktar.AlkalmazottValaszto());
            TombKiiro(b.Raktar.LeltarKiiro(b.Raktar.AlkalmazottValaszto()));
            Console.WriteLine();
            b.Raktar.Raktarosok.ForEach(t => Kiiro(t.AlkalmazottAdatok()));
            Console.WriteLine();
            
            b.Eladok.ForEach(t => Kiiro(t.AlkalmazottAdatok()));
            Console.WriteLine();
            
            b.Elad().ForEach(a => Kiiro(a));
            Console.WriteLine();
            b.Elad().ForEach(a => Kiiro(a));

        }
    }
}
