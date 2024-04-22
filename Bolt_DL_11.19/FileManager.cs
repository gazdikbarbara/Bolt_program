using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bolt_DL_11._19_
{
    class FileManager
    {
        public void WriteAllText(string eleresiut, string szoveg)
        {
            File.WriteAllText(eleresiut, szoveg);
        }

        public void WriteAllLines(string eleresiut, string[] szoveg)
        {
            File.WriteAllLines(eleresiut, szoveg);
        }
        public void WriteAllLines(string eleresiut, List<string> szoveg)
        {
            File.WriteAllLines(eleresiut, szoveg);
        }

        public string ReadAllText(string eleresiut)
        {
            string result = "";
            if (File.Exists(eleresiut))
            {
                result = File.ReadAllText(eleresiut);
            }
            return result;
        }

        public string[] ReadAllLines(string eleresiut)
        {
            string[] result;
            if (File.Exists(eleresiut))
            {
                return result = File.ReadAllLines(eleresiut);
            }
            return result = new string[0];
        }


    }


}
