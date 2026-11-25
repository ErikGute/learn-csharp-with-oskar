using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace SorteraLista;

/// <summary>
/// Här skriver du din kod. Ändra bara i den här filen.
///
/// REGEL: Du får INTE använda inbyggd sortering, till exempel
/// lista.Sort(), OrderBy(), Order() eller Array.Sort().
/// Du ska skriva sorteringen själv med loopar.
/// </summary>
public static class Sortering
{
    /// <summary>
    /// UPPGIFT 1 (uppvärmning)
    /// Returnera true om listan är sorterad i stigande ordning,
    /// annars false. En tom lista och en lista med ett tal räknas som sorterade.
    ///
    /// Exempel:
    ///   [1, 2, 2, 5]  ->  true
    ///   [3, 1, 2]     ->  false
    /// </summary>
    public static bool ArSorterad(List<int> lista)
    {
        // Skriv din kod här
        /* didnt work
        bool sort = true;
        if (sort == true){
            return true;
        } 
        else
        {
        for (int i = 0; i < lista.Count -1 && sort; i++) 
        {
          sort = false;
           for (int j = 0; j < lista.Count; j++) 
            { 
            if (lista [j] > lista [j - 1])
                {
                    int tmp = lista [j + 1];
                    lista[j + 1] = lista [j];
                    lista[j] = tmp;
                    sort = true;
                }
          }
        }
        }
        if (number == 1)
            return false;
        for (int i = 0; i < lista.Count; i++)
        {
            if ((i + 1 < number) && (lista[i] > lista[i + 1]))
            {
                int temp = lista[i];
                lista[i] = lista[i + 1];
                lista[i + 1] = temp;
            }
            else continue;
        }
        return ArSorterad(lista, number - 1);
        */
        //if (lista == null)
        //    return true;
        
    }

    /// <summary>
    /// UPPGIFT 2
    /// Returnera en NY lista med samma tal sorterade i stigande ordning
    /// (minst först). Originallistan får inte ändras.
    ///
    /// Exempel:
    ///   [5, 3, 8, 1]  ->  [1, 3, 5, 8]
    ///
    /// Tips: Börja med att kopiera listan: var kopia = new List&lt;int&gt;(lista);
    /// Bubbelsortering är en bra algoritm att börja med.
    /// </summary>
    public static List<int> SorteraStigande(List<int> lista)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 3
    /// Returnera en NY lista med samma tal sorterade i fallande ordning
    /// (störst först). Originallistan får inte ändras.
    ///
    /// Exempel:
    ///   [5, 3, 8, 1]  ->  [8, 5, 3, 1]
    /// </summary>
    public static List<int> SorteraFallande(List<int> lista)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }
}
