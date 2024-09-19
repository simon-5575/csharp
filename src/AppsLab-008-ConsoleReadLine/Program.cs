/*Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno);
Console.WriteLine();

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");
Console.WriteLine();    

Console.WriteLine("Ake je tvoje oblubene jedlo?");
string jedlo = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Hmm " + jedlo + " od gizky je dobry/a");

Console.WriteLine($"Volam sa {meno},je mi {vek} a moje oblubene jedlo je {jedlo}");*/




//Z databazy
var menoUzivatela = "Simon";
var heslouzivatela = "0000";

//zadane uzivatelom
var zadanemeno = "Simon";
var zadaneheslo = "0000";

var porovnanieMena = menoUzivatela == zadanemeno;
var porovnavanieHesiel = heslouzivatela == zadaneheslo;

var prijatPristup = porovnanieMena || porovnavanieHesiel;

if (prijatPristup)
{

    Console.WriteLine("Heslo sa zhoduje,vitaj " + menoUzivatela);
}
else
{
    Console.WriteLine("Heslo sa NEZHODUJE");
}  



