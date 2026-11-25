namespace Verktyg;

/// <summary>
/// Ett litet klassbibliotek. Det här projektet kan INTE startas med ▶ Start,
/// eftersom det inte är ett program, bara en samling metoder.
///
/// Du ska inte ändra i den här filen. Använd den från ditt eget program
/// i Del B (se README.md).
/// </summary>
public static class Halsning
{
    /// <summary>
    /// Skapar en hälsning.
    /// Exempel:  Halsning.Skapa("klassen")  ->  "Hej, klassen!"
    /// </summary>
    public static string Skapa(string namn)
    {
        return $"Hej, {namn}!";
    }
}
