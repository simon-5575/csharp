using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Obcaan_a_Mesto
{
    public class Mesto
    {
        
        public string Nazov { get; set; }
        private List<lekar> lekari = new List<lekar>();
        private List<programator> programatori = new List<programator>();
        private List<ucitel> ucitelia = new List<ucitel>();
        private List<Obcan> obcania = new List<Obcan>();

        
        public void PridajLekara(lekar lekar)
        {
            lekari.Add(lekar);
        }

        public void PridajProgramatora(programator programator)
        {
            programatori.Add(programator);
        }


        public Mesto(string nazov)
        {
            Nazov = nazov;
        }

        public void PridajUcitela(ucitel ucitel)
        {
            ucitelia.Add(ucitel);
        }

        public void VypisObcanov()
        {
            Console.WriteLine($"Obcania mesta {Nazov}:");

            foreach (var lekar in lekari)
            {
                lekar.VypisInfo();
            }

            foreach (var programator in programatori)
            {
                programator.VypisInfo();
            }

            foreach (var ucitel in ucitelia)
            {
                ucitel.VypisInfo();
            }
        }
    } 
}



