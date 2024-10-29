





/*class Program
         {
            static void Main(string[] args)
            {
                // Deklarácia premenných
                string meno = "Simon";
                int vek = 15;
                bool jeProgramator = true;  // 'je' znamená, že je programátor, teda true
                double vyska = 185.0;

                // Výpis do konzoly
                Console.WriteLine("Meno: " + meno);
                Console.WriteLine("Vek: " + vek);
//                Console.WriteLine("Je programátor: " + (jeProgramator ? "Áno" : "Nie"));
//                Console.WriteLine("Výška: " + vyska + " cm");
//            }
//         }*/


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        /*  // Nacitanie veku pouzivateľa z konzoly
//            Console.WriteLine("Zadaj svoj vek:");
//            int vek = int.Parse(Console.ReadLine()); // Nacita vstup a skonvertuje ho na int

//            // Podmienka if-else na kontrolu veku
//            if (vek >= 18)
//            {
//                Console.WriteLine("Si dospely prijaty pristup.");
//            }
//            else
//            {
//                Console.WriteLine("Nie si dospely pristup zamietnuty.");
//            }
//        }
//    }*/


//        using System;
//        using System.Text.Json;












  namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int nahodneCislo = rnd.Next(1, 101); // Generovanie cisla od 1 do 100
            int pokus = 0;
            int maxPokusov =10;
            int tip = 0;

            Console.WriteLine("Uhadni cislo od 1 do 100!");

            while (tip != nahodneCislo)
            {
                Console.WriteLine("Zadaj svoj tip:");
                tip = int.Parse(Console.ReadLine()); // Nacita číslo od používateľa
                pokus++;

                if (tip < nahodneCislo)
                {
                    Console.WriteLine("Tvoj tip je prilis maly.");
                }
                else if (tip > nahodneCislo)
                {
                    Console.WriteLine("Tvoj tip je prilis velky.");
                    Console.WriteLine("Pocet pokusov:+pokus)");
                }
                if (pokus==maxPokusov)
                {
                    Console.WriteLine("Dosli ti pokusy.Spravnecislo" + nahodneCislo);
                }
                    
                else
                {
                    
                    Console.WriteLine("Pocet pokusov: " + pokus);
                }
            }
        }
    }
}

