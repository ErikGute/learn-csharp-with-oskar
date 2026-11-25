# Övning 03: Filstrukturen i C#

I den här övningen lär du dig hur ett C#-repo hänger ihop: vad en solution,
ett projekt och en kodfil är, och varför vissa projekt går att starta med
▶ Start och andra inte.

| Del | Vad du gör | Hjälp |
|---|---|---|
| **A – Förstå** | Läs guiden och svara på 12 frågor i [`svar.txt`](svar.txt) | [Guide: Filstrukturen](../guider/filstruktur.md) |
| **B – Bygg med hjälp** | Skapa ett program som använder ett färdigt bibliotek, steg för steg | Instruktionerna nedan |
| **C – Bygg själv** | Skapa både ett bibliotek och ett program på egen hand | [Recept: skapa projekt](../guider/skapa-projekt.md) |

---

## Del A: Förstå

Läs **[Guide: Filstrukturen i C#](../guider/filstruktur.md)** och svara sedan
på frågorna. Skriv bokstaven för ditt svar i [`svar.txt`](svar.txt), till
exempel `Fråga 1: B`. **Öppna filerna i repot** för att hitta svaren.

**Fråga 1.** Vilken sorts fil håller ihop flera projekt så att Visual Studio kan öppna dem tillsammans?
- A) `.cs`
- B) `.csproj`
- C) `.sln`
- D) `.exe`

**Fråga 2.** Öppna `01-grunder/Grunder/Grunder.csproj`. Vad beskriver den filen?
- A) Projektets inställningar, till exempel vilken .NET-version som används
- B) Själva C#-koden för uppgifterna
- C) Vilka elever som har forkat repot
- D) Resultatet från senaste testkörningen

**Fråga 3.** I vilken mapp hamnar de färdigbyggda `.dll`- och `.exe`-filerna?
- A) `obj`
- B) `bin`
- C) `src`
- D) `.github`

**Fråga 4.** Varför står `bin` och `obj` i `.gitignore`?
- A) De innehåller lösenord
- B) De är för stora för GitHub
- C) Visual Studio kräver det
- D) De skapas automatiskt när man bygger, så de behöver inte sparas

**Fråga 5.** `Grunder.csproj` har ingen rad med `<OutputType>`. Vad blir projektet då?
- A) Ett körbart program
- B) Ett klassbibliotek
- C) Ett testprojekt
- D) Projektet går inte att bygga

**Fråga 6.** Vad händer om du trycker på ▶ Start när ett klassbibliotek är valt som startprojekt?
- A) Alla metoder i biblioteket körs i tur och ordning
- B) Testerna körs
- C) Du får ett felmeddelande om att projektet inte kan startas direkt
- D) Visual Studio skapar en `Main`-metod automatiskt

**Fråga 7.** Vad behöver ett projekt för att kunna startas som ett program?
- A) `<OutputType>Exe</OutputType>` i projektfilen och en startpunkt
- B) Minst tre `.cs`-filer
- C) En `README.md`
- D) Att en av filerna heter `Program.cs`

**Fråga 8.** Hur många filer i ett projekt får innehålla top-level statements?
- A) Hur många som helst
- B) Ingen
- C) Exakt en
- D) En per mapp

**Fråga 9.** Vad gör en `<ProjectReference>` i en `.csproj`-fil?
- A) Laddar ner ett paket från internet
- B) Lägger till projektet i `.sln`-filen
- C) Kopierar in koden från det andra projektet
- D) Gör att projektet kan använda klasser från ett annat projekt

**Fråga 10.** Öppna `01-grunder/Grunder.Tests/Grunder.Tests.csproj`. Var kommer `xunit` ifrån?
- A) Det är ett NuGet-paket som laddas ner via `<PackageReference>`
- B) Det ingår i Windows
- C) Det ligger i mappen `bin` från början
- D) Läraren har skrivit det

**Fråga 11.** Hur körs projektet `Grunder.Tests`?
- A) Med ▶ Start
- B) Med `dotnet run`
- C) Med Test Explorer eller `dotnet test`
- D) Automatiskt varje gång man sparar

**Fråga 12.** Filen `svar.txt` ligger direkt i mappen `03-filstruktur`, inte i något projekts mapp. Kompileras den när du bygger?
- A) Ja, alla filer i repot kompileras
- B) Nej, bara `.cs`-filer i ett projekts mapp kompileras
- C) Ja, om den ligger nära en `.csproj`-fil
- D) Bara när koden körs på GitHub

---

## Del B: Bygg med hjälp

I mappen [`Verktyg`](Verktyg) finns ett färdigt **klassbibliotek** med en
metod som skapar en hälsning:

```csharp
Halsning.Skapa("klassen")   // ger "Hej, klassen!"
```

Biblioteket kan inte startas själv. Din uppgift är att skapa ett
**program** som använder det.

### Målet
```
03-filstruktur/
├── HejApp.slnx               ← din egen solution (kan också heta HejApp.sln)
├── HejApp/
│   ├── HejApp.csproj         ← OutputType Exe + ProjectReference till Verktyg
│   └── Program.cs            ← skriver ut Halsning.Skapa("klassen")
└── Verktyg/                  ← fanns redan
```

Kör du programmet ska det skriva ut:
```
Hej, klassen!
```

### Gör så här (i PowerShell)

Stå i repots rotmapp och kör ett kommando i taget. **Öppna filerna efter
varje steg** och se vad som har ändrats.

**1. Gå till övningens mapp**
```powershell
cd 03-filstruktur
```

**2. Skapa en ny solution.** Den blir en egen "pärm" för ditt program.
```powershell
dotnet new sln -n HejApp
```
Filen heter `HejApp.slnx`. Heter den `HejApp.sln` hos dig, skriv `HejApp.sln` i stegen nedan i stället.

**3. Skapa ett konsolprogram.** Titta i `HejApp\HejApp.csproj`. Där står `<OutputType>Exe</OutputType>`.
```powershell
dotnet new console -n HejApp
```

**4. Lägg till båda projekten i din solution**
```powershell
dotnet sln HejApp.slnx add HejApp\HejApp.csproj Verktyg\Verktyg.csproj
```

**5. Låt programmet använda biblioteket.** Titta i `HejApp.csproj` igen. Nu finns där en `<ProjectReference>`.
```powershell
dotnet add HejApp\HejApp.csproj reference Verktyg\Verktyg.csproj
```

**6. Öppna din solution i Visual Studio**
```powershell
start HejApp.slnx
```

**7. Skriv koden.** Ersätt allt i `Program.cs` med:
```csharp
using Verktyg;

Console.WriteLine(Halsning.Skapa("klassen"));
```

**8. Tryck på ▶ Start.** Nu fungerar det, eftersom `HejApp` är ett program.

**9. Committa och pusha** som vanligt.

### Fundera på
- Varför fick du fel med ▶ Start på ett klassbibliotek, men inte på `HejApp`?
- `Verktyg` finns nu med i **två** solutions. Är det två kopior av projektet? *(Tips: titta i mapparna.)*
- Ta bort raden `using Verktyg;` och bygg. Vilket fel får du? Slå upp det i [receptet](../guider/skapa-projekt.md#vanliga-fel-och-vad-de-betyder).
- Ta bort `<ProjectReference>` i `HejApp.csproj` och bygg. Vilket fel får du nu? Ställ sedan tillbaka allt.

---

## Del C: Bygg själv

Nu gör du samma sak, men utan steg-för-steg-instruktioner. Använd
**[Recept: skapa ett program som använder ett bibliotek](../guider/skapa-projekt.md)**.

### Uppgiften
Skapa i mappen `03-filstruktur`:

1. Ett **klassbibliotek** som heter `Kalkylator`, med:
   - namespace `Kalkylator`
   - en `public static class Rakna`
   - metoden `public static int Addera(int a, int b)` som returnerar summan
   - metoden `public static int Multiplicera(int a, int b)` som returnerar produkten

2. Ett **program** som heter `RaknaApp`, som använder `Kalkylator` och skriver ut exakt:
   ```
   2 + 3 = 5
   4 * 5 = 20
   ```
   Siffrorna `5` och `20` ska räknas ut med dina metoder, inte skrivas in för hand.

3. En **solution** som heter `RaknaApp` och innehåller båda projekten.

### Tips
- Skriv ut text och värden tillsammans så här: `Console.WriteLine($"2 + 3 = {resultat}");`
- Testerna kontrollerar också att `Kalkylator` räknar rätt med andra tal än 2, 3, 4 och 5.
- Använd checklistan i receptet innan du pushar.

---

## Testerna
Det finns 23 tester: 12 för Del A, 5 för Del B och 6 för Del C.
Testnamnen börjar med `03 ·`. Kör dem från huvudsolutionen
`learn-csharp-with-oskar.sln`.
