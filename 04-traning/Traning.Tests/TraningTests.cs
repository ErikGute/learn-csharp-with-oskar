using Traning;

namespace Traning.Tests;

// ÄNDRA INTE I DEN HÄR FILEN.
// Varje test anropar din metod med några värden och jämför svaret.
// Om något blir fel står det exakt vilket anrop som gav fel svar.

public class Del1_Rakna
{
    [Fact(DisplayName = "04 · Uppgift 1: Dubbla")]
    public void U01()
    {
        Kolla.Lika(8, () => Rakna.Dubbla(4), "Dubbla(4)");
        Kolla.Lika(-6, () => Rakna.Dubbla(-3), "Dubbla(-3)");
        Kolla.Lika(0, () => Rakna.Dubbla(0), "Dubbla(0)");
    }

    [Fact(DisplayName = "04 · Uppgift 2: Kvadrat")]
    public void U02()
    {
        Kolla.Lika(25, () => Rakna.Kvadrat(5), "Kvadrat(5)");
        Kolla.Lika(16, () => Rakna.Kvadrat(-4), "Kvadrat(-4)");
        Kolla.Lika(1, () => Rakna.Kvadrat(1), "Kvadrat(1)");
    }

    [Fact(DisplayName = "04 · Uppgift 3: Medel")]
    public void U03()
    {
        Kolla.Lika(3.5, () => Rakna.Medel(3, 4), "Medel(3, 4)");
        Kolla.Lika(15.0, () => Rakna.Medel(10, 20), "Medel(10, 20)");
        Kolla.Lika(0.5, () => Rakna.Medel(0, 1), "Medel(0, 1)");
    }

    [Fact(DisplayName = "04 · Uppgift 4: Rest")]
    public void U04()
    {
        Kolla.Lika(2, () => Rakna.Rest(17, 5), "Rest(17, 5)");
        Kolla.Lika(0, () => Rakna.Rest(10, 2), "Rest(10, 2)");
        Kolla.Lika(3, () => Rakna.Rest(3, 7), "Rest(3, 7)");
    }

    [Fact(DisplayName = "04 · Uppgift 5: HelaMinuter")]
    public void U05()
    {
        Kolla.Lika(2, () => Rakna.HelaMinuter(130), "HelaMinuter(130)");
        Kolla.Lika(0, () => Rakna.HelaMinuter(59), "HelaMinuter(59)");
        Kolla.Lika(1, () => Rakna.HelaMinuter(60), "HelaMinuter(60)");
    }

    [Fact(DisplayName = "04 · Uppgift 6: CelsiusTillFahrenheit")]
    public void U06()
    {
        Kolla.Lika(212.0, () => Rakna.CelsiusTillFahrenheit(100), "CelsiusTillFahrenheit(100)");
        Kolla.Lika(32.0, () => Rakna.CelsiusTillFahrenheit(0), "CelsiusTillFahrenheit(0)");
        Kolla.Lika(99.5, () => Rakna.CelsiusTillFahrenheit(37.5), "CelsiusTillFahrenheit(37.5)");
        Kolla.Lika(-40.0, () => Rakna.CelsiusTillFahrenheit(-40), "CelsiusTillFahrenheit(-40)");
    }

    [Fact(DisplayName = "04 · Uppgift 7: Rektangelarea")]
    public void U07()
    {
        Kolla.Lika(12.0, () => Rakna.Rektangelarea(3, 4), "Rektangelarea(3, 4)");
        Kolla.Lika(5.0, () => Rakna.Rektangelarea(2.5, 2), "Rektangelarea(2.5, 2)");
    }

    [Fact(DisplayName = "04 · Uppgift 8: MedMoms")]
    public void U08()
    {
        Kolla.Lika(125.0, () => Rakna.MedMoms(100), "MedMoms(100)");
        Kolla.Lika(100.0, () => Rakna.MedMoms(80), "MedMoms(80)");
        Kolla.Lika(0.0, () => Rakna.MedMoms(0), "MedMoms(0)");
    }
}

public class Del2_Text
{
    [Fact(DisplayName = "04 · Uppgift 9: Halsa")]
    public void U09()
    {
        Kolla.Lika("Hej, Ali!", () => Text.Halsa("Ali"), "Halsa(\"Ali\")");
        Kolla.Lika("Hej, Sara!", () => Text.Halsa("Sara"), "Halsa(\"Sara\")");
    }

    [Fact(DisplayName = "04 · Uppgift 10: AntalTecken")]
    public void U10()
    {
        Kolla.Lika(3, () => Text.AntalTecken("hej"), "AntalTecken(\"hej\")");
        Kolla.Lika(6, () => Text.AntalTecken("hej då"), "AntalTecken(\"hej då\")");
        Kolla.Lika(0, () => Text.AntalTecken(""), "AntalTecken(\"\")");
    }

    [Fact(DisplayName = "04 · Uppgift 11: ForstaTecknet")]
    public void U11()
    {
        Kolla.Lika('S', () => Text.ForstaTecknet("Sara"), "ForstaTecknet(\"Sara\")");
        Kolla.Lika('ö', () => Text.ForstaTecknet("ö"), "ForstaTecknet(\"ö\")");
        Kolla.Lika('1', () => Text.ForstaTecknet("123"), "ForstaTecknet(\"123\")");
    }

    [Fact(DisplayName = "04 · Uppgift 12: Versaler")]
    public void U12()
    {
        Kolla.Lika("HEJ", () => Text.Versaler("hej"), "Versaler(\"hej\")");
        Kolla.Lika("HEJ DÅ 2", () => Text.Versaler("Hej Då 2"), "Versaler(\"Hej Då 2\")");
    }

    [Fact(DisplayName = "04 · Uppgift 13: Presentera")]
    public void U13()
    {
        Kolla.Lika("Jag heter Sara och är 16 år.", () => Text.Presentera("Sara", 16), "Presentera(\"Sara\", 16)");
        Kolla.Lika("Jag heter Ali och är 17 år.", () => Text.Presentera("Ali", 17), "Presentera(\"Ali\", 17)");
    }

    [Fact(DisplayName = "04 · Uppgift 14: AntalA")]
    public void U14()
    {
        Kolla.Lika(2, () => Text.AntalA("banan"), "AntalA(\"banan\")");
        Kolla.Lika(1, () => Text.AntalA("Anna"), "AntalA(\"Anna\")");
        Kolla.Lika(0, () => Text.AntalA("hej"), "AntalA(\"hej\")");
        Kolla.Lika(0, () => Text.AntalA(""), "AntalA(\"\")");
    }

    [Fact(DisplayName = "04 · Uppgift 15: Baklanges")]
    public void U15()
    {
        Kolla.Lika("cba", () => Text.Baklanges("abc"), "Baklanges(\"abc\")");
        Kolla.Lika("!jeh", () => Text.Baklanges("hej!"), "Baklanges(\"hej!\")");
        Kolla.Lika("", () => Text.Baklanges(""), "Baklanges(\"\")");
    }

    [Fact(DisplayName = "04 · Uppgift 16: ArPalindrom")]
    public void U16()
    {
        Kolla.Lika(true, () => Text.ArPalindrom("anna"), "ArPalindrom(\"anna\")");
        Kolla.Lika(true, () => Text.ArPalindrom("kajak"), "ArPalindrom(\"kajak\")");
        Kolla.Lika(false, () => Text.ArPalindrom("bil"), "ArPalindrom(\"bil\")");
        Kolla.Lika(false, () => Text.ArPalindrom("abca"), "ArPalindrom(\"abca\")");
    }
}

public class Del3_Villkor
{
    [Fact(DisplayName = "04 · Uppgift 17: ArPositivt")]
    public void U17()
    {
        Kolla.Lika(true, () => Villkor.ArPositivt(5), "ArPositivt(5)");
        Kolla.Lika(false, () => Villkor.ArPositivt(0), "ArPositivt(0)");
        Kolla.Lika(false, () => Villkor.ArPositivt(-2), "ArPositivt(-2)");
    }

    [Fact(DisplayName = "04 · Uppgift 18: ArMyndig")]
    public void U18()
    {
        Kolla.Lika(true, () => Villkor.ArMyndig(18), "ArMyndig(18)");
        Kolla.Lika(false, () => Villkor.ArMyndig(17), "ArMyndig(17)");
        Kolla.Lika(true, () => Villkor.ArMyndig(40), "ArMyndig(40)");
    }

    [Fact(DisplayName = "04 · Uppgift 19: MinstAvTre")]
    public void U19()
    {
        Kolla.Lika(2, () => Villkor.MinstAvTre(4, 2, 9), "MinstAvTre(4, 2, 9)");
        Kolla.Lika(1, () => Villkor.MinstAvTre(1, 5, 3), "MinstAvTre(1, 5, 3)");
        Kolla.Lika(3, () => Villkor.MinstAvTre(8, 6, 3), "MinstAvTre(8, 6, 3)");
        Kolla.Lika(7, () => Villkor.MinstAvTre(7, 7, 7), "MinstAvTre(7, 7, 7)");
        Kolla.Lika(-5, () => Villkor.MinstAvTre(-1, 0, -5), "MinstAvTre(-1, 0, -5)");
    }

    [Fact(DisplayName = "04 · Uppgift 20: Tecken")]
    public void U20()
    {
        Kolla.Lika("positivt", () => Villkor.Tecken(5), "Tecken(5)");
        Kolla.Lika("negativt", () => Villkor.Tecken(-3), "Tecken(-3)");
        Kolla.Lika("noll", () => Villkor.Tecken(0), "Tecken(0)");
    }

    [Fact(DisplayName = "04 · Uppgift 21: Biljettpris")]
    public void U21()
    {
        Kolla.Lika(50, () => Villkor.Biljettpris(8), "Biljettpris(8)");
        Kolla.Lika(50, () => Villkor.Biljettpris(11), "Biljettpris(11)");
        Kolla.Lika(100, () => Villkor.Biljettpris(12), "Biljettpris(12)");
        Kolla.Lika(100, () => Villkor.Biljettpris(64), "Biljettpris(64)");
        Kolla.Lika(70, () => Villkor.Biljettpris(65), "Biljettpris(65)");
    }

    [Fact(DisplayName = "04 · Uppgift 22: Veckodag")]
    public void U22()
    {
        Kolla.Lika("måndag", () => Villkor.Veckodag(1), "Veckodag(1)");
        Kolla.Lika("onsdag", () => Villkor.Veckodag(3), "Veckodag(3)");
        Kolla.Lika("fredag", () => Villkor.Veckodag(5), "Veckodag(5)");
        Kolla.Lika("söndag", () => Villkor.Veckodag(7), "Veckodag(7)");
        Kolla.Lika("ogiltig", () => Villkor.Veckodag(0), "Veckodag(0)");
        Kolla.Lika("ogiltig", () => Villkor.Veckodag(9), "Veckodag(9)");
    }

    [Fact(DisplayName = "04 · Uppgift 23: FizzBuzz")]
    public void U23()
    {
        Kolla.Lika("Fizz", () => Villkor.FizzBuzz(9), "FizzBuzz(9)");
        Kolla.Lika("Buzz", () => Villkor.FizzBuzz(10), "FizzBuzz(10)");
        Kolla.Lika("FizzBuzz", () => Villkor.FizzBuzz(15), "FizzBuzz(15)");
        Kolla.Lika("FizzBuzz", () => Villkor.FizzBuzz(30), "FizzBuzz(30)");
        Kolla.Lika("7", () => Villkor.FizzBuzz(7), "FizzBuzz(7)");
    }

    [Fact(DisplayName = "04 · Uppgift 24: ArSkottar")]
    public void U24()
    {
        Kolla.Lika(true, () => Villkor.ArSkottar(2024), "ArSkottar(2024)");
        Kolla.Lika(false, () => Villkor.ArSkottar(2023), "ArSkottar(2023)");
        Kolla.Lika(false, () => Villkor.ArSkottar(1900), "ArSkottar(1900)");
        Kolla.Lika(true, () => Villkor.ArSkottar(2000), "ArSkottar(2000)");
    }
}

public class Del4_Loopar
{
    [Fact(DisplayName = "04 · Uppgift 25: Stjarnor")]
    public void U25()
    {
        Kolla.Lika("*****", () => Loopar.Stjarnor(5), "Stjarnor(5)");
        Kolla.Lika("*", () => Loopar.Stjarnor(1), "Stjarnor(1)");
        Kolla.Lika("", () => Loopar.Stjarnor(0), "Stjarnor(0)");
    }

    [Fact(DisplayName = "04 · Uppgift 26: RaknaTill")]
    public void U26()
    {
        Kolla.Lika("1 2 3 4 5", () => Loopar.RaknaTill(5), "RaknaTill(5)");
        Kolla.Lika("1", () => Loopar.RaknaTill(1), "RaknaTill(1)");
        Kolla.Lika("1 2 3 4 5 6 7 8 9 10", () => Loopar.RaknaTill(10), "RaknaTill(10)");
    }

    [Fact(DisplayName = "04 · Uppgift 27: Nedrakning")]
    public void U27()
    {
        Kolla.Lika("3 2 1 Start!", () => Loopar.Nedrakning(3), "Nedrakning(3)");
        Kolla.Lika("1 Start!", () => Loopar.Nedrakning(1), "Nedrakning(1)");
        Kolla.Lika("5 4 3 2 1 Start!", () => Loopar.Nedrakning(5), "Nedrakning(5)");
    }

    [Fact(DisplayName = "04 · Uppgift 28: SummaJamna")]
    public void U28()
    {
        Kolla.Lika(30, () => Loopar.SummaJamna(10), "SummaJamna(10)");
        Kolla.Lika(6, () => Loopar.SummaJamna(5), "SummaJamna(5)");
        Kolla.Lika(0, () => Loopar.SummaJamna(1), "SummaJamna(1)");
    }

    [Fact(DisplayName = "04 · Uppgift 29: Fakultet")]
    public void U29()
    {
        Kolla.Lika(120, () => Loopar.Fakultet(5), "Fakultet(5)");
        Kolla.Lika(1, () => Loopar.Fakultet(1), "Fakultet(1)");
        Kolla.Lika(1, () => Loopar.Fakultet(0), "Fakultet(0)");
        Kolla.Lika(5040, () => Loopar.Fakultet(7), "Fakultet(7)");
    }

    [Fact(DisplayName = "04 · Uppgift 30: Potens")]
    public void U30()
    {
        Kolla.Lika(8, () => Loopar.Potens(2, 3), "Potens(2, 3)");
        Kolla.Lika(100, () => Loopar.Potens(10, 2), "Potens(10, 2)");
        Kolla.Lika(1, () => Loopar.Potens(7, 0), "Potens(7, 0)");
        Kolla.Lika(1024, () => Loopar.Potens(2, 10), "Potens(2, 10)");
    }

    [Fact(DisplayName = "04 · Uppgift 31: AntalSiffror")]
    public void U31()
    {
        Kolla.Lika(5, () => Loopar.AntalSiffror(12345), "AntalSiffror(12345)");
        Kolla.Lika(1, () => Loopar.AntalSiffror(7), "AntalSiffror(7)");
        Kolla.Lika(1, () => Loopar.AntalSiffror(0), "AntalSiffror(0)");
        Kolla.Lika(3, () => Loopar.AntalSiffror(100), "AntalSiffror(100)");
    }

    [Fact(DisplayName = "04 · Uppgift 32: Siffersumma")]
    public void U32()
    {
        Kolla.Lika(10, () => Loopar.Siffersumma(1234), "Siffersumma(1234)");
        Kolla.Lika(18, () => Loopar.Siffersumma(99), "Siffersumma(99)");
        Kolla.Lika(0, () => Loopar.Siffersumma(0), "Siffersumma(0)");
        Kolla.Lika(1, () => Loopar.Siffersumma(1000), "Siffersumma(1000)");
    }
}

public class Del5_Arrayer
{
    [Fact(DisplayName = "04 · Uppgift 33: Forsta")]
    public void U33()
    {
        Kolla.Lika(4, () => Arrayer.Forsta(new[] { 4, 8, 1 }), "Forsta([4, 8, 1])");
        Kolla.Lika(-3, () => Arrayer.Forsta(new[] { -3 }), "Forsta([-3])");
    }

    [Fact(DisplayName = "04 · Uppgift 34: Sista")]
    public void U34()
    {
        Kolla.Lika(1, () => Arrayer.Sista(new[] { 4, 8, 1 }), "Sista([4, 8, 1])");
        Kolla.Lika(7, () => Arrayer.Sista(new[] { 7 }), "Sista([7])");
        Kolla.Lika(9, () => Arrayer.Sista(new[] { 1, 2, 3, 4, 5, 9 }), "Sista([1, 2, 3, 4, 5, 9])");
    }

    [Fact(DisplayName = "04 · Uppgift 35: Minsta")]
    public void U35()
    {
        Kolla.Lika(1, () => Arrayer.Minsta(new[] { 4, 8, 1, 6 }), "Minsta([4, 8, 1, 6])");
        Kolla.Lika(-9, () => Arrayer.Minsta(new[] { -2, -9, 0 }), "Minsta([-2, -9, 0])");
        Kolla.Lika(3, () => Arrayer.Minsta(new[] { 3, 5, 7 }), "Minsta([3, 5, 7])");
        Kolla.Lika(2, () => Arrayer.Minsta(new[] { 9, 5, 2 }), "Minsta([9, 5, 2])");
    }

    [Fact(DisplayName = "04 · Uppgift 36: Innehaller")]
    public void U36()
    {
        Kolla.Lika(true, () => Arrayer.Innehaller(new[] { 4, 8, 1 }, 8), "Innehaller([4, 8, 1], 8)");
        Kolla.Lika(true, () => Arrayer.Innehaller(new[] { 4, 8, 1 }, 1), "Innehaller([4, 8, 1], 1)");
        Kolla.Lika(false, () => Arrayer.Innehaller(new[] { 4, 8, 1 }, 5), "Innehaller([4, 8, 1], 5)");
        Kolla.Lika(false, () => Arrayer.Innehaller(new int[0], 5), "Innehaller([], 5)");
    }

    [Fact(DisplayName = "04 · Uppgift 37: AntalNegativa")]
    public void U37()
    {
        Kolla.Lika(2, () => Arrayer.AntalNegativa(new[] { 3, -1, 0, -7 }), "AntalNegativa([3, -1, 0, -7])");
        Kolla.Lika(0, () => Arrayer.AntalNegativa(new[] { 1, 2 }), "AntalNegativa([1, 2])");
        Kolla.Lika(0, () => Arrayer.AntalNegativa(new int[0]), "AntalNegativa([])");
    }

    [Fact(DisplayName = "04 · Uppgift 38: IndexAv")]
    public void U38()
    {
        Kolla.Lika(1, () => Arrayer.IndexAv(new[] { 4, 8, 1, 8 }, 8), "IndexAv([4, 8, 1, 8], 8)");
        Kolla.Lika(0, () => Arrayer.IndexAv(new[] { 4, 8, 1 }, 4), "IndexAv([4, 8, 1], 4)");
        Kolla.Lika(2, () => Arrayer.IndexAv(new[] { 4, 8, 1 }, 1), "IndexAv([4, 8, 1], 1)");
        Kolla.Lika(-1, () => Arrayer.IndexAv(new[] { 4, 8, 1 }, 5), "IndexAv([4, 8, 1], 5)");
    }

    [Fact(DisplayName = "04 · Uppgift 39: Dubblera")]
    public void U39()
    {
        Kolla.Lika(new[] { 2, 4, 6 }, () => Arrayer.Dubblera(new[] { 1, 2, 3 }), "Dubblera([1, 2, 3])");
        Kolla.Lika(new int[0], () => Arrayer.Dubblera(new int[0]), "Dubblera([])");
        Kolla.Lika(new[] { -10, 0 }, () => Arrayer.Dubblera(new[] { -5, 0 }), "Dubblera([-5, 0])");
    }

    [Fact(DisplayName = "04 · Uppgift 40: BaraJamna")]
    public void U40()
    {
        Kolla.Lika(new[] { 2, 4, 6 }, () => Arrayer.BaraJamna(new[] { 1, 2, 3, 4, 6 }), "BaraJamna([1, 2, 3, 4, 6])");
        Kolla.Lika(new int[0], () => Arrayer.BaraJamna(new[] { 1, 3 }), "BaraJamna([1, 3])");
        Kolla.Lika(new[] { 0, -2 }, () => Arrayer.BaraJamna(new[] { 0, -1, -2 }), "BaraJamna([0, -1, -2])");
    }
}

/// <summary>
/// Hjälpmetoder som jämför svar och skriver tydliga felmeddelanden på svenska.
/// </summary>
internal static class Kolla
{
    public static void Lika<T>(T forvantat, Func<T> anrop, string beskrivning)
    {
        T faktiskt;
        try
        {
            faktiskt = anrop();
        }
        catch (NotImplementedException)
        {
            Assert.Fail("Inte påbörjad ännu.");
            return;
        }
        catch (Exception fel)
        {
            Assert.Fail($"{beskrivning} kraschade med {fel.GetType().Name}: {fel.Message}");
            return;
        }

        if (!ArLika(forvantat, faktiskt))
        {
            Assert.Fail($"{beskrivning} ska bli {Visa(forvantat)}, men blev {Visa(faktiskt)}.");
        }
    }

    private static bool ArLika<T>(T a, T b) => (a, b) switch
    {
        (double x, double y) => Math.Abs(x - y) < 0.0001,
        (int[] x, int[] y) => x.SequenceEqual(y),
        _ => Equals(a, b),
    };

    private static string Visa(object? varde) => varde switch
    {
        null => "null",
        string s => $"\"{s}\"",
        char c => $"'{c}'",
        bool b => b ? "true" : "false",
        double d => d.ToString(System.Globalization.CultureInfo.InvariantCulture),
        int[] a => "[" + string.Join(", ", a) + "]",
        _ => varde.ToString() ?? "",
    };
}
