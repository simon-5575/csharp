


namespace Obcaan_a_Mesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto mesto = new Mesto("Bratislava");

            mesto.PridajLekara(new lekar("Igor", 34));
            mesto.PridajProgramatora(new programator("Anna", 28));
            mesto.PridajUcitela(new ucitel("Peter", 40));
            
           
            mesto.VypisObcanov();
        }
    }
}