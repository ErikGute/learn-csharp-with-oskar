# Guide: Filstrukturen i C#

Den här guiden förklarar hur ett C#-repo hänger ihop: vad en solution, ett
projekt och en kodfil är, och varför vissa projekt går att starta med
▶ Start och andra inte.

Använd guiden som uppslagsbok. Du behöver inte kunna den utantill.

---

## Tre nivåer: solution → projekt → kodfil

```
learn-csharp-with-oskar/                  ← repots rotmapp (en vanlig mapp)
│
├── learn-csharp-with-oskar.sln           ← SOLUTION: en lista över projekt
│
├── 01-grunder/                           ← vanlig mapp, bara för ordningens skull
│   ├── Grunder/                          ← ett PROJEKT (klassbibliotek)
│   │   ├── Grunder.csproj                ← projektfilen: projektets inställningar
│   │   ├── Grunder.cs                    ← en KODFIL: här skriver du C#
│   │   ├── bin/                          ← skapas när du bygger
│   │   └── obj/                          ← skapas när du bygger
│   │
│   └── Grunder.Tests/                    ← ett annat PROJEKT (testprojekt)
│       ├── Grunder.Tests.csproj
│       └── GrunderTests.cs
│
└── 03-filstruktur/
```

| Fil | Vad den är | Liknelse |
|---|---|---|
| `.sln` / `.slnx` | **Solution.** En lista över vilka projekt som hör ihop. Det är den du öppnar i Visual Studio. | En pärm |
| `.csproj` | **Projektfil.** Inställningar för *ett* projekt: .NET-version, om det är ett program eller ett bibliotek, och vilka andra projekt och paket det använder. | Ett kapitel i pärmen |
| `.cs` | **Kodfil.** Själva C#-koden. Alla `.cs`-filer i projektets mapp ingår automatiskt i projektet. | Sidorna i kapitlet |

**Bra att veta:**
- En solution innehåller ingen kod. Den pekar bara ut projekt.
- Samma projekt kan finnas med i flera solutions. Det finns ändå bara *en* kopia av projektet på disken.
- Vanliga mappar, som `01-grunder`, betyder ingenting för C#. De finns bara för att hålla ordning.
- Filer som inte slutar på `.cs`, till exempel `README.md` eller `svar.txt`, kompileras aldrig.

---

## `bin` och `obj`: det som skapas när du bygger

När du bygger (**Ctrl+Shift+B** eller `dotnet build`) gör kompilatorn om
dina `.cs`-filer till en `.dll`-fil, och för program även en `.exe`-fil.

| Mapp | Innehåll |
|---|---|
| `obj/` | Mellanfiler som kompilatorn behöver under arbetet |
| `bin/` | Resultatet: de färdiga `.dll`- och `.exe`-filerna |

Båda mapparna skapas på nytt varje gång man bygger. Därför står de i
`.gitignore` och laddas aldrig upp till GitHub. Det gör inget om du raderar
dem. De kommer tillbaka nästa gång du bygger.

---

## Körbart program eller bibliotek?

Det är **projektfilen** som avgör vilken sorts projekt det är:

| Typ | I `.csproj` | Kan startas med ▶? | Används till |
|---|---|---|---|
| **Program** | `<OutputType>Exe</OutputType>` | ✅ Ja | Något som ska köras, till exempel ett konsolprogram |
| **Klassbibliotek** | Ingen `OutputType` alls (eller `Library`) | ❌ Nej | Klasser och metoder som andra projekt använder |
| **Testprojekt** | Paket som `xunit` och `Microsoft.NET.Test.Sdk` | ❌ Nej, körs i **Test Explorer** | Tester |

Trycker du på ▶ Start när ett klassbibliotek är valt får du felet:
> *A project with an output type of class library cannot be started directly.*

Ett bibliotek är som en verktygslåda: den gör ingenting själv, men ett
program kan använda verktygen.

I Visual Studio är det **startprojektet** som körs när du trycker på ▶.
Det står i fetstil i Solution Explorer. Byt med högerklick på ett projekt
och **Set as Startup Project**.

---

## Startpunkten: var programmet börjar

Ett program måste ha **exakt en** startpunkt. Det finns två sätt att skriva den:

**Med `Main`-metod** (klassiskt sätt):
```csharp
class Program
{
    static void Main()
    {
        Console.WriteLine("Hej!");
    }
}
```

**Med top-level statements** (nyare och kortare). Koden ligger direkt i
filen, utan klass och `Main`:
```csharp
Console.WriteLine("Hej!");
```

Bara **en** fil i ett projekt får ha top-level statements. Kompilatorn
måste veta var programmet börjar. Det är vanligt att filen heter
`Program.cs`, men namnet spelar ingen roll.

---

## Referenser: hur projekt använder varandra

Ett projekt kan använda kod från två håll. Båda anges i `.csproj`:

```xml
<!-- Ett annat projekt i samma repo -->
<ProjectReference Include="..\Grunder\Grunder.csproj" />

<!-- Ett färdigt paket som laddas ner från NuGet (internet) -->
<PackageReference Include="xunit" Version="2.9.3" />
```

Så fungerar testerna: testprojektet har en `ProjectReference` till ditt
projekt och kan därför anropa dina metoder.

En referens går bara **åt ett håll**. Om programmet refererar till
biblioteket kan programmet använda bibliotekets klasser, men inte tvärtom.

---

## Namespace och `using`

Överst i en kodfil står till exempel `namespace Grunder;`. Ett namespace är
ett efternamn för klasser. Det håller isär klasser som råkar heta likadant.

Vill du använda en klass från ett annat namespace skriver du `using`
högst upp i filen:

```csharp
using Verktyg;   // nu kan du använda klasserna i namespace Verktyg
```

För att använda en klass från ett annat projekt behövs **båda** delarna:
1. en `<ProjectReference>` i `.csproj`, så att projektet *har tillgång* till det andra projektet
2. `using` i `.cs`-filen, så att koden *hittar* klassen

---

## Sammanfattning

| Fråga | Svar |
|---|---|
| Vad öppnar jag i Visual Studio? | `.sln`- eller `.slnx`-filen |
| Var bestäms om något är ett program? | I `.csproj`, med `<OutputType>Exe</OutputType>` |
| Var börjar programmet? | I `Main` eller i filen med top-level statements |
| Hur använder ett projekt ett annat? | `<ProjectReference>` i `.csproj` plus `using` i `.cs` |
| Ska `bin` och `obj` pushas? | Nej, de skapas automatiskt |

Vill du skapa egna projekt? Läs [Recept: skapa ett program som använder ett bibliotek](skapa-projekt.md).
