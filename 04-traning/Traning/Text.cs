namespace Traning;

// =========================================================================
//  DEL 2: TEXT (string och char)  (uppgift 9–16)
//  Läs först: guider/variabler-och-datatyper.md
//
//  Bra att veta:
//    text.Length        antal tecken
//    text[0]            första tecknet (en char)
//    text.ToUpper()     texten med stora bokstäver
//    $"Hej {namn}"      sätt ihop text och variabler
// =========================================================================
public static class Text
{
    /// <summary>
    /// UPPGIFT 9: Returnera en hälsning.
    ///   Halsa("Ali")   ->  "Hej, Ali!"
    ///   Halsa("Sara")  ->  "Hej, Sara!"
    /// </summary>
    public static string Halsa(string namn)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 10: Returnera antalet tecken i texten (mellanslag räknas också).
    ///   AntalTecken("hej")      ->  3
    ///   AntalTecken("hej då")   ->  6
    ///   AntalTecken("")         ->  0
    /// </summary>
    public static int AntalTecken(string text)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 11: Returnera det första tecknet i texten.
    /// Texten har alltid minst ett tecken.
    ///   ForstaTecknet("Sara")  ->  'S'
    ///   ForstaTecknet("ö")     ->  'ö'
    /// Obs: en char skrivs med enkla citattecken: 'S'
    /// </summary>
    public static char ForstaTecknet(string text)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 12: Returnera texten med bara stora bokstäver.
    ///   Versaler("hej")        ->  "HEJ"
    ///   Versaler("Hej Då 2")   ->  "HEJ DÅ 2"
    /// </summary>
    public static string Versaler(string text)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 13: Returnera en presentation.
    ///   Presentera("Sara", 16)  ->  "Jag heter Sara och är 16 år."
    ///   Presentera("Ali", 17)   ->  "Jag heter Ali och är 17 år."
    /// </summary>
    public static string Presentera(string namn, int alder)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 14: Returnera hur många gånger bokstaven 'a' finns i texten.
    /// Räkna bara små a.
    ///   AntalA("banan")   ->  2
    ///   AntalA("Anna")    ->  1     (stora A räknas inte)
    ///   AntalA("hej")     ->  0
    /// Tips: foreach (char tecken in text)
    /// </summary>
    public static int AntalA(string text)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 15: Returnera texten baklänges.
    ///   Baklanges("abc")    ->  "cba"
    ///   Baklanges("hej!")   ->  "!jeh"
    ///   Baklanges("")       ->  ""
    /// Tips: börja med en tom sträng och lägg till tecken ett i taget.
    /// </summary>
    public static string Baklanges(string text)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 16 (utmaning): Returnera true om texten är en palindrom,
    /// alltså samma framlänges som baklänges. Bara små bokstäver används.
    ///   ArPalindrom("anna")     ->  true
    ///   ArPalindrom("kajak")    ->  true
    ///   ArPalindrom("bil")      ->  false
    /// Tips: du kan använda din metod Baklanges.
    /// </summary>
    public static bool ArPalindrom(string text)
    {
        throw new NotImplementedException();
    }
}
