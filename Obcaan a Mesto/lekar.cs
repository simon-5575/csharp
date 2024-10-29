using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obcaan_a_Mesto
{
    
    
        public class lekar
        {
            public string Meno { get; set; }
            public int Vek { get; set; }

            public lekar(string meno, int vek)
            {
                Meno = meno;
                Vek = vek;
            }

            public void VypisInfo()
            {
                Console.WriteLine($"{Meno}, {Vek} rokov, lieci ludi.");
            }
        }
    



}
