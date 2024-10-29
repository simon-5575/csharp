namespace AppsLab_001_StartHere;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zadajte text");
        string text = Console.ReadLine();
        int pocetsamohlasok = PocetSamohlasok(text);
        Console.WriteLine("Text obsahuje" + pocetsamohlasok + "samohlasok");
    }


    public static int PocetSamohlasok(string text)
    {
        int pocet = 0;

        for (int i = 0; i < text.Length; i++)
        {

            if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
            {
                pocet++;
            }


        }
        return pocet;

    }  
}