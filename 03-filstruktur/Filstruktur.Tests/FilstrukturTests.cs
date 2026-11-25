using System.Diagnostics;
using System.Reflection;
using System.Runtime.Loader;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Filstruktur.Tests;

// ÄNDRA INTE I DEN HÄR FILEN.
// Testerna körs automatiskt i GitHub Actions varje gång du pushar.

public class DelA_Fragor
{
    [Fact(DisplayName = "03 · A · Fråga 1: Vilken fil håller ihop flera projekt?")]
    public void Fraga1() => KontrolleraSvar(1, "1a7210b12462297d");

    [Fact(DisplayName = "03 · A · Fråga 2: Vad beskriver en .csproj-fil?")]
    public void Fraga2() => KontrolleraSvar(2, "83b5c4924e919c32");

    [Fact(DisplayName = "03 · A · Fråga 3: Var hamnar de färdigbyggda filerna?")]
    public void Fraga3() => KontrolleraSvar(3, "03b4c095d112b20a");

    [Fact(DisplayName = "03 · A · Fråga 4: Varför står bin och obj i .gitignore?")]
    public void Fraga4() => KontrolleraSvar(4, "e94adad36f3892d2");

    [Fact(DisplayName = "03 · A · Fråga 5: Vad blir ett projekt utan OutputType?")]
    public void Fraga5() => KontrolleraSvar(5, "7d543ba6f97aafac");

    [Fact(DisplayName = "03 · A · Fråga 6: ▶ Start på ett klassbibliotek")]
    public void Fraga6() => KontrolleraSvar(6, "754004182e1ac235");

    [Fact(DisplayName = "03 · A · Fråga 7: Vad krävs för att kunna starta ett projekt?")]
    public void Fraga7() => KontrolleraSvar(7, "9943eab5b87657d0");

    [Fact(DisplayName = "03 · A · Fråga 8: Hur många filer får ha top-level statements?")]
    public void Fraga8() => KontrolleraSvar(8, "ba2b3f65ff8b294c");

    [Fact(DisplayName = "03 · A · Fråga 9: Vad gör en ProjectReference?")]
    public void Fraga9() => KontrolleraSvar(9, "298b271cc5fca520");

    [Fact(DisplayName = "03 · A · Fråga 10: Var kommer xunit ifrån?")]
    public void Fraga10() => KontrolleraSvar(10, "065c928e6c167918");

    [Fact(DisplayName = "03 · A · Fråga 11: Hur körs ett testprojekt?")]
    public void Fraga11() => KontrolleraSvar(11, "2976de33840b220d");

    [Fact(DisplayName = "03 · A · Fråga 12: Kompileras svar.txt?")]
    public void Fraga12() => KontrolleraSvar(12, "1c3dda488bd9eba4");

    // Svaren är krypterade (hashade) så att de inte går att läsa här.
    private static void KontrolleraSvar(int nummer, string ratt)
    {
        var svar = LasSvar(nummer);
        Assert.False(svar == null, $"Du har inte svarat på fråga {nummer} i svar.txt ännu.");

        var hash = Convert.ToHexString(
            SHA256.HashData(Encoding.UTF8.GetBytes($"filstruktur-{nummer}-{svar}"))).ToLowerInvariant()[..16];
        Assert.True(hash == ratt, $"Svaret {svar} på fråga {nummer} är inte rätt. Läs guiden igen.");
    }

    private static string? LasSvar(int nummer)
    {
        var fil = Path.Combine(Hjalp.Ovningsmapp(), "svar.txt");
        foreach (var rad in File.ReadAllLines(fil))
        {
            var traff = Regex.Match(rad, @"^\s*Fr\S{1,2}ga\s*(\d+)\s*:\s*([A-Da-d])?", RegexOptions.IgnoreCase);
            if (traff.Success && int.Parse(traff.Groups[1].Value) == nummer)
            {
                return traff.Groups[2].Success ? traff.Groups[2].Value.ToUpperInvariant() : null;
            }
        }
        return null;
    }
}

public class DelB_ByggMedHjalp
{
    [Fact(DisplayName = "03 · B · 1: Projektet HejApp finns")]
    public void ProjektetFinns() => Hjalp.KravProjekt("HejApp", "Följ steg 1–3 i Del B.");

    [Fact(DisplayName = "03 · B · 2: HejApp är ett körbart program (OutputType Exe)")]
    public void ArKorbart() => Hjalp.KravProgram(Hjalp.KravProjekt("HejApp", "Gör B · 1 först."));

    [Fact(DisplayName = "03 · B · 3: HejApp har en ProjectReference till Verktyg")]
    public void RefererarVerktyg() =>
        Hjalp.KravReferens(Hjalp.KravProjekt("HejApp", "Gör B · 1 först."), "Verktyg", "Följ steg 5 i Del B.");

    [Fact(DisplayName = "03 · B · 4: Det finns en solution med både HejApp och Verktyg")]
    public void SolutionFinns() => Hjalp.KravSolution("HejApp", "Verktyg");

    [Fact(DisplayName = "03 · B · 5: HejApp skriver ut \"Hej, klassen!\"")]
    public void SkriverUtHalsning()
    {
        var utdata = Hjalp.KorProgram(Hjalp.KravProjekt("HejApp", "Gör B · 1 först."));
        Assert.True(utdata.Contains("Hej, klassen!"),
            "HejApp skrev inte ut \"Hej, klassen!\". Programmet skrev:\n" + utdata);
    }
}

public class DelC_ByggSjalv
{
    [Fact(DisplayName = "03 · C · 1: Kalkylator finns och är ett klassbibliotek")]
    public void KalkylatorArBibliotek()
    {
        var projekt = Hjalp.KravProjekt("Kalkylator", "Skapa ett klassbibliotek med namnet Kalkylator.");
        Assert.False(Hjalp.ArProgram(projekt),
            "Kalkylator.csproj har <OutputType>Exe</OutputType>, men Kalkylator ska vara ett klassbibliotek.");
    }

    [Fact(DisplayName = "03 · C · 2: RaknaApp finns och är ett körbart program")]
    public void RaknaAppArProgram() =>
        Hjalp.KravProgram(Hjalp.KravProjekt("RaknaApp", "Skapa ett konsolprogram med namnet RaknaApp."));

    [Fact(DisplayName = "03 · C · 3: RaknaApp har en ProjectReference till Kalkylator")]
    public void RaknaAppRefererar() =>
        Hjalp.KravReferens(Hjalp.KravProjekt("RaknaApp", "Gör C · 2 först."), "Kalkylator", "Se steg 5 i receptet.");

    [Fact(DisplayName = "03 · C · 4: Det finns en solution med både RaknaApp och Kalkylator")]
    public void SolutionFinns() => Hjalp.KravSolution("RaknaApp", "Kalkylator");

    [Fact(DisplayName = "03 · C · 5: Kalkylator räknar rätt")]
    public void KalkylatorRaknarRatt()
    {
        var projekt = Hjalp.KravProjekt("Kalkylator", "Gör C · 1 först.");
        var dll = Hjalp.ByggBibliotek(projekt);

        var kontext = new AssemblyLoadContext("Kalkylator", isCollectible: true);
        try
        {
            var assembly = kontext.LoadFromAssemblyPath(dll);
            var klass = assembly.GetType("Kalkylator.Rakna");
            Assert.True(klass != null,
                "Hittade ingen klass Rakna i namespace Kalkylator. Kontrollera att det står 'namespace Kalkylator;' och 'public static class Rakna'.");

            int Anropa(string metod, int a, int b)
            {
                var m = klass!.GetMethod(metod, BindingFlags.Public | BindingFlags.Static, new[] { typeof(int), typeof(int) });
                Assert.True(m != null, $"Hittade ingen metod 'public static int {metod}(int a, int b)' i klassen Rakna.");
                try { return (int)m!.Invoke(null, new object[] { a, b })!; }
                catch (TargetInvocationException e) { throw e.InnerException!; }
            }

            Assert.True(Anropa("Addera", 7, 8) == 15, "Addera(7, 8) ska bli 15.");
            Assert.True(Anropa("Addera", -4, 4) == 0, "Addera(-4, 4) ska bli 0.");
            Assert.True(Anropa("Multiplicera", 6, 7) == 42, "Multiplicera(6, 7) ska bli 42.");
            Assert.True(Anropa("Multiplicera", -3, 5) == -15, "Multiplicera(-3, 5) ska bli -15.");
        }
        finally
        {
            kontext.Unload();
        }
    }

    [Fact(DisplayName = "03 · C · 6: RaknaApp skriver ut rätt rader")]
    public void RaknaAppSkriverUt()
    {
        var projekt = Hjalp.KravProjekt("RaknaApp", "Gör C · 2 först.");

        var kod = string.Join("\n", Directory.EnumerateFiles(Path.GetDirectoryName(projekt)!, "*.cs", SearchOption.AllDirectories)
            .Where(f => !Hjalp.ArByggmapp(f))
            .Select(File.ReadAllText));
        Assert.True(kod.Contains("Addera(") && kod.Contains("Multiplicera("),
            "RaknaApp ska räkna ut svaren med Rakna.Addera och Rakna.Multiplicera, inte skriva in dem för hand.");

        var utdata = Hjalp.KorProgram(projekt);
        Assert.True(utdata.Contains("2 + 3 = 5") && utdata.Contains("4 * 5 = 20"),
            "RaknaApp ska skriva ut \"2 + 3 = 5\" och \"4 * 5 = 20\". Programmet skrev:\n" + utdata);
    }
}

internal static class Hjalp
{
    // Mappen 03-filstruktur, hittas genom att gå uppåt från testprojektets byggmapp.
    public static string Ovningsmapp()
    {
        var mapp = new DirectoryInfo(AppContext.BaseDirectory);
        while (mapp != null)
        {
            if (File.Exists(Path.Combine(mapp.FullName, "svar.txt"))
                && Directory.Exists(Path.Combine(mapp.FullName, "Verktyg")))
            {
                return mapp.FullName;
            }
            mapp = mapp.Parent;
        }
        throw new DirectoryNotFoundException("Hittade inte mappen 03-filstruktur.");
    }

    public static string KravProjekt(string namn, string tips)
    {
        var projekt = Directory.EnumerateFiles(Ovningsmapp(), namn + ".csproj", SearchOption.AllDirectories)
            .FirstOrDefault(f => !ArByggmapp(f));
        Assert.True(projekt != null, $"Hittade ingen {namn}.csproj i mappen 03-filstruktur. {tips}");
        return projekt!;
    }

    public static bool ArProgram(string projekt)
    {
        var outputType = XDocument.Load(projekt).Descendants("OutputType").FirstOrDefault()?.Value.Trim();
        return string.Equals(outputType, "Exe", StringComparison.OrdinalIgnoreCase);
    }

    public static void KravProgram(string projekt)
    {
        Assert.True(ArProgram(projekt),
            $"{Path.GetFileName(projekt)} är inte ett program. Ett program behöver <OutputType>Exe</OutputType>.");
    }

    public static void KravReferens(string projekt, string till, string tips)
    {
        var referenser = XDocument.Load(projekt).Descendants("ProjectReference")
            .Select(r => (r.Attribute("Include")?.Value ?? "").Replace('\\', '/'));
        Assert.True(referenser.Any(r => r.EndsWith($"{till}.csproj", StringComparison.OrdinalIgnoreCase)),
            $"{Path.GetFileName(projekt)} saknar en <ProjectReference> till {till}. {tips}");
    }

    public static void KravSolution(params string[] projekt)
    {
        var losningar = Directory.EnumerateFiles(Ovningsmapp(), "*", SearchOption.AllDirectories)
            .Where(f => f.EndsWith(".sln") || f.EndsWith(".slnx"))
            .Where(f => !ArByggmapp(f))
            .ToList();

        bool ok = losningar.Any(f =>
        {
            var text = File.ReadAllText(f);
            return projekt.All(p => text.Contains(p + ".csproj", StringComparison.OrdinalIgnoreCase));
        });
        Assert.True(ok,
            $"Hittade ingen .sln- eller .slnx-fil i 03-filstruktur som innehåller både {string.Join(" och ", projekt)}.");
    }

    public static string KorProgram(string projekt) => KorDotnet(Path.GetDirectoryName(projekt)!, "run", "--project", projekt);

    public static string ByggBibliotek(string projekt)
    {
        var ut = Path.Combine(Path.GetTempPath(), "filstruktur-" + Guid.NewGuid().ToString("N"));
        KorDotnet(Path.GetDirectoryName(projekt)!, "build", projekt, "-o", ut);
        return Path.Combine(ut, Path.GetFileNameWithoutExtension(projekt) + ".dll");
    }

    private static string KorDotnet(string mapp, params string[] argument)
    {
        var start = new ProcessStartInfo("dotnet")
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            WorkingDirectory = mapp,
        };
        foreach (var a in argument) start.ArgumentList.Add(a);
        start.Environment["DOTNET_NOLOGO"] = "1";
        start.Environment["DOTNET_CLI_TELEMETRY_OPTOUT"] = "1";

        using var process = Process.Start(start)!;
        var utdata = process.StandardOutput.ReadToEndAsync();
        var fel = process.StandardError.ReadToEndAsync();
        if (!process.WaitForExit(180_000))
        {
            process.Kill(entireProcessTree: true);
            Assert.Fail("Det tog för lång tid. Väntar programmet kanske på Console.ReadLine()?");
        }

        var text = utdata.Result + fel.Result;
        Assert.True(process.ExitCode == 0, "Det gick inte att bygga eller köra:\n" + SistaRader(text));
        return text;
    }

    private static string SistaRader(string text) =>
        string.Join("\n", text.Split('\n', StringSplitOptions.RemoveEmptyEntries).TakeLast(8));

    public static bool ArByggmapp(string fil)
    {
        var delar = fil.Replace('\\', '/').Split('/');
        return delar.Contains("bin") || delar.Contains("obj");
    }
}
