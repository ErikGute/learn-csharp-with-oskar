// =========================================================================
//  PROVKÖR – testa dina sorteringsmetoder med EGNA värden
// =========================================================================
//
//  Så kör du:
//    1. Högerklicka på projektet SorteraLista.Provkor i Solution Explorer
//       och välj "Set as Startup Project".
//    2. Tryck på ▶ Start (eller F5).
//
//  Den här filen rättas INTE. Ändra fritt, byt värden och lägg till egna rader.
//  Läs mer i guiden: guider/testkora.md
// =========================================================================

using SorteraLista;

Console.WriteLine("=== Provkör: Sortera en lista ===");
Console.WriteLine();

List<int> minLista = new List<int> { 5, 3, 8, 1, 9, 2 };   // ändra talen!

Console.WriteLine($"Originallistan: [{string.Join(", ", minLista)}]");
Console.WriteLine();

Prova("ArSorterad(minLista)", () => Sortering.ArSorterad(minLista));
Prova("SorteraStigande(minLista)", () => Sortering.SorteraStigande(minLista));
Prova("SorteraFallande(minLista)", () => Sortering.SorteraFallande(minLista));

Console.WriteLine();
Console.WriteLine($"Originallistan efteråt: [{string.Join(", ", minLista)}]");
Console.WriteLine("(Har originallistan ändrats? Det får den inte göra!)");


// =========================================================================
//  Hjälpmetod. Du behöver inte förstå koden här nedanför än.
// =========================================================================
static void Prova(string beskrivning, Func<object> kod)
{
    try
    {
        object svar = kod();
        string text = svar is List<int> lista ? "[" + string.Join(", ", lista) + "]" : $"{svar}";
        Console.WriteLine($"{beskrivning,-30} = {text}");
    }
    catch (NotImplementedException)
    {
        Console.WriteLine($"{beskrivning,-30} = (inte gjord ännu)");
    }
}
