namespace Traning;

// =========================================================================
//  DEL 3: VILLKOR  (uppgift 17–24)
//  Läs först: guider/villkor-och-loopar.md
// =========================================================================
public static class Villkor
{
    /// <summary>
    /// UPPGIFT 17: Returnera true om talet är större än noll.
    ///   ArPositivt(5)   ->  true
    ///   ArPositivt(0)   ->  false
    ///   ArPositivt(-2)  ->  false
    /// </summary>
    public static bool ArPositivt(int tal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 18: Returnera true om personen är myndig (18 år eller äldre).
    ///   ArMyndig(18)  ->  true
    ///   ArMyndig(17)  ->  false
    /// </summary>
    public static bool ArMyndig(int alder)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 19: Returnera det minsta av tre tal.
    ///   MinstAvTre(4, 2, 9)   ->  2
    ///   MinstAvTre(7, 7, 7)   ->  7
    ///   MinstAvTre(-1, 0, -5) ->  -5
    /// </summary>
    public static int MinstAvTre(int a, int b, int c)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 20: Returnera "positivt", "negativt" eller "noll".
    ///   Tecken(5)   ->  "positivt"
    ///   Tecken(-3)  ->  "negativt"
    ///   Tecken(0)   ->  "noll"
    /// </summary>
    public static string Tecken(int tal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 21: Returnera biljettpriset i kronor:
    ///   under 12 år   ->  50
    ///   65 år eller äldre  ->  70
    ///   alla andra    ->  100
    ///
    ///   Biljettpris(8)   ->  50
    ///   Biljettpris(12)  ->  100
    ///   Biljettpris(65)  ->  70
    /// </summary>
    public static int Biljettpris(int alder)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 22: Returnera namnet på veckodagen, med små bokstäver.
    /// 1 är måndag och 7 är söndag. Andra tal ger "ogiltig".
    ///   Veckodag(1)  ->  "måndag"
    ///   Veckodag(5)  ->  "fredag"
    ///   Veckodag(9)  ->  "ogiltig"
    /// Tips: prova gärna switch.
    /// </summary>
    public static string Veckodag(int nummer)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 23: FizzBuzz! Returnera:
    ///   "FizzBuzz" om talet är delbart med både 3 och 5
    ///   "Fizz"     om talet är delbart med 3
    ///   "Buzz"     om talet är delbart med 5
    ///   annars talet som text
    ///
    ///   FizzBuzz(9)   ->  "Fizz"
    ///   FizzBuzz(10)  ->  "Buzz"
    ///   FizzBuzz(15)  ->  "FizzBuzz"
    ///   FizzBuzz(7)   ->  "7"
    /// Tips: ordningen på villkoren spelar roll!
    /// </summary>
    public static string FizzBuzz(int tal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 24 (utmaning): Returnera true om året är ett skottår.
    /// Regler:
    ///   - delbart med 4 är skottår...
    ///   - ...utom om det är delbart med 100...
    ///   - ...men delbart med 400 är ändå skottår.
    ///
    ///   ArSkottar(2024)  ->  true
    ///   ArSkottar(2023)  ->  false
    ///   ArSkottar(1900)  ->  false
    ///   ArSkottar(2000)  ->  true
    /// </summary>
    public static bool ArSkottar(int ar)
    {
        throw new NotImplementedException();
    }
}
