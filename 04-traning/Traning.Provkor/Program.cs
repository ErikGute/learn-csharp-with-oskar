// =========================================================================
//  PROVKÖR – testa dina träningsuppgifter med EGNA värden
// =========================================================================
//
//  Så kör du:
//    1. Högerklicka på projektet Traning.Provkor i Solution Explorer
//       och välj "Set as Startup Project".
//    2. Tryck på ▶ Start (eller F5).
//
//  Den här filen rättas INTE. Ändra fritt, byt värden och lägg till egna rader.
//  Tips: kommentera bort delar du inte jobbar med (markera + Ctrl+K, Ctrl+C).
// =========================================================================

using Traning;

Console.WriteLine("=== Del 1: Räkna ===");
Prova("Dubbla(4)", () => Rakna.Dubbla(4));
Prova("Kvadrat(5)", () => Rakna.Kvadrat(5));
Prova("Medel(3, 4)", () => Rakna.Medel(3, 4));
Prova("Rest(17, 5)", () => Rakna.Rest(17, 5));
Prova("HelaMinuter(130)", () => Rakna.HelaMinuter(130));
Prova("CelsiusTillFahrenheit(100)", () => Rakna.CelsiusTillFahrenheit(100));
Prova("Rektangelarea(3, 4)", () => Rakna.Rektangelarea(3, 4));
Prova("MedMoms(100)", () => Rakna.MedMoms(100));

Console.WriteLine();
Console.WriteLine("=== Del 2: Text ===");
Prova("Halsa(\"Ali\")", () => Text.Halsa("Ali"));
Prova("AntalTecken(\"hej då\")", () => Text.AntalTecken("hej då"));
Prova("ForstaTecknet(\"Sara\")", () => Text.ForstaTecknet("Sara"));
Prova("Versaler(\"hej\")", () => Text.Versaler("hej"));
Prova("Presentera(\"Sara\", 16)", () => Text.Presentera("Sara", 16));
Prova("AntalA(\"banan\")", () => Text.AntalA("banan"));
Prova("Baklanges(\"abc\")", () => Text.Baklanges("abc"));
Prova("ArPalindrom(\"kajak\")", () => Text.ArPalindrom("kajak"));

Console.WriteLine();
Console.WriteLine("=== Del 3: Villkor ===");
Prova("ArPositivt(5)", () => Villkor.ArPositivt(5));
Prova("ArMyndig(17)", () => Villkor.ArMyndig(17));
Prova("MinstAvTre(4, 2, 9)", () => Villkor.MinstAvTre(4, 2, 9));
Prova("Tecken(-3)", () => Villkor.Tecken(-3));
Prova("Biljettpris(8)", () => Villkor.Biljettpris(8));
Prova("Veckodag(5)", () => Villkor.Veckodag(5));
Prova("FizzBuzz(15)", () => Villkor.FizzBuzz(15));
Prova("ArSkottar(2024)", () => Villkor.ArSkottar(2024));

Console.WriteLine();
Console.WriteLine("=== Del 4: Loopar ===");
Prova("Stjarnor(5)", () => Loopar.Stjarnor(5));
Prova("RaknaTill(5)", () => Loopar.RaknaTill(5));
Prova("Nedrakning(3)", () => Loopar.Nedrakning(3));
Prova("SummaJamna(10)", () => Loopar.SummaJamna(10));
Prova("Fakultet(5)", () => Loopar.Fakultet(5));
Prova("Potens(2, 3)", () => Loopar.Potens(2, 3));
Prova("AntalSiffror(12345)", () => Loopar.AntalSiffror(12345));
Prova("Siffersumma(1234)", () => Loopar.Siffersumma(1234));

Console.WriteLine();
Console.WriteLine("=== Del 5: Arrayer ===");
int[] mittaTal = { 4, 8, -1, 6, -3 };      // ändra talen!
Prova("Forsta(mittaTal)", () => Arrayer.Forsta(mittaTal));
Prova("Sista(mittaTal)", () => Arrayer.Sista(mittaTal));
Prova("Minsta(mittaTal)", () => Arrayer.Minsta(mittaTal));
Prova("Innehaller(mittaTal, 6)", () => Arrayer.Innehaller(mittaTal, 6));
Prova("AntalNegativa(mittaTal)", () => Arrayer.AntalNegativa(mittaTal));
Prova("IndexAv(mittaTal, 6)", () => Arrayer.IndexAv(mittaTal, 6));
Prova("Dubblera(mittaTal)", () => Arrayer.Dubblera(mittaTal));
Prova("BaraJamna(mittaTal)", () => Arrayer.BaraJamna(mittaTal));


// =========================================================================
//  Hjälpmetod. Du behöver inte förstå koden här nedanför än.
// =========================================================================
static void Prova(string beskrivning, Func<object> kod)
{
    try
    {
        object svar = kod();
        string text = svar switch
        {
            int[] lista => "[" + string.Join(", ", lista) + "]",
            string s => $"\"{s}\"",
            char c => $"'{c}'",
            _ => $"{svar}",
        };
        Console.WriteLine($"{beskrivning,-30} = {text}");
    }
    catch (NotImplementedException)
    {
        Console.WriteLine($"{beskrivning,-30} = (inte gjord ännu)");
    }
    catch (Exception fel)
    {
        Console.WriteLine($"{beskrivning,-30} = KRASCH: {fel.GetType().Name}");
    }
}
