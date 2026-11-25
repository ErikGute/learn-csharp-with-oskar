namespace Traning;

// =========================================================================
//  DEL 5: ARRAYER  (uppgift 33–40)
//  Läs först: guider/villkor-och-loopar.md (avsnittet Arrayer)
//
//  Bra att veta:
//    tal.Length            antal tal i arrayen
//    tal[0]                första talet
//    tal[tal.Length - 1]   sista talet
//    new int[5]            en ny array med plats för 5 tal
// =========================================================================
public static class Arrayer
{
    /// <summary>
    /// UPPGIFT 33: Returnera det första talet. Arrayen har minst ett tal.
    ///   Forsta([4, 8, 1])  ->  4
    /// </summary>
    public static int Forsta(int[] tal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 34: Returnera det sista talet. Arrayen har minst ett tal.
    ///   Sista([4, 8, 1])  ->  1
    ///   Sista([7])        ->  7
    /// </summary>
    public static int Sista(int[] tal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 35: Returnera det minsta talet. Arrayen har minst ett tal.
    ///   Minsta([4, 8, 1, 6])  ->  1
    ///   Minsta([-2, -9, 0])   ->  -9
    /// </summary>
    public static int Minsta(int[] tal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 36: Returnera true om talet sokt finns i arrayen.
    ///   Innehaller([4, 8, 1], 8)  ->  true
    ///   Innehaller([4, 8, 1], 5)  ->  false
    ///   Innehaller([], 5)         ->  false
    /// </summary>
    public static bool Innehaller(int[] tal, int sokt)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 37: Returnera hur många tal som är negativa (mindre än 0).
    ///   AntalNegativa([3, -1, 0, -7])  ->  2
    ///   AntalNegativa([1, 2])          ->  0
    /// </summary>
    public static int AntalNegativa(int[] tal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 38: Returnera platsen (indexet) där talet sokt finns första gången.
    /// Finns talet inte, returnera -1.
    ///   IndexAv([4, 8, 1, 8], 8)  ->  1
    ///   IndexAv([4, 8, 1], 4)     ->  0
    ///   IndexAv([4, 8, 1], 5)     ->  -1
    /// </summary>
    public static int IndexAv(int[] tal, int sokt)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 39: Returnera en NY array där varje tal är dubbelt så stort.
    ///   Dubblera([1, 2, 3])  ->  [2, 4, 6]
    ///   Dubblera([])         ->  []
    /// </summary>
    public static int[] Dubblera(int[] tal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 40 (utmaning): Returnera en NY array med bara de jämna talen,
    /// i samma ordning.
    ///   BaraJamna([1, 2, 3, 4, 6])  ->  [2, 4, 6]
    ///   BaraJamna([1, 3])           ->  []
    /// Tips: räkna först hur många jämna tal det finns, skapa sedan arrayen.
    /// </summary>
    public static int[] BaraJamna(int[] tal)
    {
        throw new NotImplementedException();
    }
}
