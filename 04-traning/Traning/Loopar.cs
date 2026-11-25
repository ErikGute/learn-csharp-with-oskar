namespace Traning;

// =========================================================================
//  DEL 4: LOOPAR  (uppgift 25–32)
//  Läs först: guider/villkor-och-loopar.md
// =========================================================================
public static class Loopar
{
    /// <summary>
    /// UPPGIFT 25: Returnera n stjärnor i rad.
    ///   Stjarnor(5)  ->  "*****"
    ///   Stjarnor(1)  ->  "*"
    ///   Stjarnor(0)  ->  ""
    /// </summary>
    public static string Stjarnor(int antal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 26: Returnera talen 1 till n med ett mellanslag emellan.
    ///   RaknaTill(5)  ->  "1 2 3 4 5"
    ///   RaknaTill(1)  ->  "1"
    /// Obs: inget mellanslag efter sista talet!
    /// </summary>
    public static string RaknaTill(int n)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 27: Räkna ner från ett tal till 1, och avsluta med "Start!".
    ///   Nedrakning(3)  ->  "3 2 1 Start!"
    ///   Nedrakning(1)  ->  "1 Start!"
    /// </summary>
    public static string Nedrakning(int fran)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 28: Returnera summan av alla JÄMNA tal från 1 till och med n.
    ///   SummaJamna(10)  ->  30    (2 + 4 + 6 + 8 + 10)
    ///   SummaJamna(5)   ->  6     (2 + 4)
    ///   SummaJamna(1)   ->  0
    /// </summary>
    public static int SummaJamna(int n)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 29: Returnera n fakultet: 1 * 2 * 3 * ... * n.
    /// 0 fakultet är 1.
    ///   Fakultet(5)  ->  120   (1 * 2 * 3 * 4 * 5)
    ///   Fakultet(1)  ->  1
    ///   Fakultet(0)  ->  1
    /// </summary>
    public static int Fakultet(int n)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 30: Returnera bas upphöjt till exponent, med en loop.
    ///   Potens(2, 3)   ->  8      (2 * 2 * 2)
    ///   Potens(10, 2)  ->  100
    ///   Potens(7, 0)   ->  1
    /// Använd inte Math.Pow.
    /// </summary>
    public static int Potens(int bas, int exponent)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 31: Returnera hur många siffror talet har. Talet är 0 eller större.
    ///   AntalSiffror(12345)  ->  5
    ///   AntalSiffror(7)      ->  1
    ///   AntalSiffror(0)      ->  1
    /// Tips: dela med 10 i en while-loop tills talet blir 0.
    /// </summary>
    public static int AntalSiffror(int tal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 32 (utmaning): Returnera summan av talets siffror.
    ///   Siffersumma(1234)  ->  10    (1 + 2 + 3 + 4)
    ///   Siffersumma(99)    ->  18
    ///   Siffersumma(0)     ->  0
    /// Tips: tal % 10 ger sista siffran, tal / 10 tar bort den.
    /// </summary>
    public static int Siffersumma(int tal)
    {
        throw new NotImplementedException();
    }
}
