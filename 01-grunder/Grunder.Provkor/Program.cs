// =========================================================================
//  PROVKÖR – testa dina metoder med EGNA värden
// =========================================================================
//
//  Så kör du:
//    1. Högerklicka på projektet Grunder.Provkor i Solution Explorer
//       och välj "Set as Startup Project".
//    2. Tryck på ▶ Start (eller F5).
//
//  Den här filen rättas INTE. Ändra fritt, byt värden och lägg till egna rader.
//  Läs mer i guiden: guider/testkora.md
// =========================================================================

using Grunder;

Console.WriteLine("=== Provkör: Grunder ===");
Console.WriteLine();

// --- Del 1: Villkor ---------------------------------------------------------
Prova("StorstAvTva(3, 8)", () => Ovningar.StorstAvTva(3, 8));
Prova("ArJamnt(7)", () => Ovningar.ArJamnt(7));
Prova("Betyg(85)", () => Ovningar.Betyg(85));

// --- Del 2: Loopar ----------------------------------------------------------
Prova("SummaUppTill(4)", () => Ovningar.SummaUppTill(4));
Prova("AntalJamnaUppTill(10)", () => Ovningar.AntalJamnaUppTill(10));
Prova("Gangertabell(3)", () => Ovningar.Gangertabell(3));

// --- Del 3: Arrayer ---------------------------------------------------------
int[] mittaTal = { 4, 9, 2, 7 };          // ändra talen och se vad som händer!

Prova("Summa(mittaTal)", () => Ovningar.Summa(mittaTal));
Prova("Storsta(mittaTal)", () => Ovningar.Storsta(mittaTal));
Prova("AntalStorreAn(mittaTal, 5)", () => Ovningar.AntalStorreAn(mittaTal, 5));
Prova("Medelvarde(mittaTal)", () => Ovningar.Medelvarde(mittaTal));
Prova("Vand(mittaTal)", () => Ovningar.Vand(mittaTal));

// --- Egna försök ------------------------------------------------------------
// Du kan också anropa metoderna "som vanligt" och spara svaret i en variabel.
// Ta bort // framför raderna när du har löst uppgift 4:
//
// int resultat = Ovningar.SummaUppTill(100);
// Console.WriteLine($"Summan av 1 till 100 är {resultat}");

Console.WriteLine();
Console.WriteLine("Klart!");


// =========================================================================
//  Hjälpmetod. Du behöver inte förstå koden här nedanför än.
//  Den kör en metod, skriver ut svaret och visar "inte gjord ännu" om
//  metoden fortfarande innehåller  throw new NotImplementedException();
// =========================================================================
static void Prova(string beskrivning, Func<object> kod)
{
    try
    {
        object svar = kod();
        string text = svar is int[] lista ? "[" + string.Join(", ", lista) + "]" : $"{svar}";
        Console.WriteLine($"{beskrivning,-30} = {text}");
    }
    catch (NotImplementedException)
    {
        Console.WriteLine($"{beskrivning,-30} = (inte gjord ännu)");
    }
}
