# Recept: skapa ett program som använder ett bibliotek

Det här receptet fungerar för alla övningar där du ska bygga ett eget
program som använder ett eget klassbibliotek. Byt bara ut namnen.

I exemplen används:
- `MittBibliotek`: klassbiblioteket med dina metoder
- `MinApp`: programmet som går att starta
- `MinApp.slnx`: solutionen som håller ihop dem

Läs först [Guide: Filstrukturen i C#](filstruktur.md) om du inte har gjort det.

---

## Del 1: Skapa strukturen

Öppna PowerShell i mappen där projekten ska ligga, till exempel `03-filstruktur`.

| Steg | Kommando | Vad som händer |
|---|---|---|
| 1. Skapa en solution | `dotnet new sln -n MinApp` | Filen `MinApp.slnx` skapas |
| 2. Skapa ett bibliotek | `dotnet new classlib -n MittBibliotek` | Mappen `MittBibliotek` skapas, med `.csproj` och `Class1.cs` |
| 3. Skapa ett program | `dotnet new console -n MinApp` | Mappen `MinApp` skapas, med `.csproj` och `Program.cs` |
| 4. Lägg till i solutionen | `dotnet sln MinApp.slnx add MittBibliotek\MittBibliotek.csproj MinApp\MinApp.csproj` | Båda projekten listas i `MinApp.slnx` |
| 5. Koppla ihop | `dotnet add MinApp\MinApp.csproj reference MittBibliotek\MittBibliotek.csproj` | `MinApp.csproj` får en `<ProjectReference>` |
| 6. Öppna i Visual Studio | `start MinApp.slnx` | Visual Studio öppnas med båda projekten |

**Kontrollera efter varje steg.** Öppna filerna och titta på vad som har
ändrats. Det är så man lär sig strukturen.

### Samma sak i Visual Studio (utan PowerShell)

1. **File → New → Project → Console App**. Ge projektet namnet `MinApp`, sätt
   *Location* till övningens mapp och kryssa i
   *Place solution and project in the same directory*.
2. Högerklicka på solutionen i **Solution Explorer** och välj
   **Add → New Project → Class Library**. Kalla det `MittBibliotek`.
3. Högerklicka på `MinApp`, välj **Add → Project Reference…** och kryssa i
   `MittBibliotek`.

Mappstrukturen blir lite annorlunda än med PowerShell, men testerna
godkänner båda varianterna.

---

## Del 2: Skriv koden

### I biblioteket
Byt namn på `Class1.cs` till något beskrivande (högerklicka → **Rename**) och
skriv en `public static class` med `public static`-metoder:

```csharp
namespace MittBibliotek;

public static class Verktyg
{
    public static int Dubbla(int tal)
    {
        return tal * 2;
    }
}
```

Glöm inte `public`. Utan det kan andra projekt inte se klassen.

### I programmet
Ersätt innehållet i `Program.cs`:

```csharp
using MittBibliotek;

Console.WriteLine(Verktyg.Dubbla(21));
```

---

## Del 3: Kör och testa

| Vad | I Visual Studio | I PowerShell |
|---|---|---|
| Bygga | **Ctrl+Shift+B** | `dotnet build` |
| Köra programmet | ▶ Start (programmet måste vara startprojekt) | `dotnet run --project MinApp` |
| Köra testerna | **Test → Run All Tests** | `dotnet test` |

---

## Checklista innan du pushar

- [ ] Biblioteket har **ingen** `<OutputType>Exe</OutputType>`.
- [ ] Programmet **har** `<OutputType>Exe</OutputType>`.
- [ ] Programmets `.csproj` har en `<ProjectReference>` till biblioteket.
- [ ] Solutionen innehåller båda projekten.
- [ ] Klassen och metoderna i biblioteket är `public`.
- [ ] `Program.cs` har `using` med bibliotekets namespace.
- [ ] Programmet skriver ut exakt det som uppgiften kräver.

---

## Vanliga fel och vad de betyder

| Felmeddelande | Vad det betyder | Lösning |
|---|---|---|
| *A project with an output type of class library cannot be started directly* | Du försöker starta ett bibliotek | Högerklicka på programmet och välj **Set as Startup Project** |
| `CS0103` *The name 'X' does not exist in the current context* | Koden hittar inte klassen `X` | Lägg till `using` med rätt namespace överst i filen |
| `CS0246` *The type or namespace name 'X' could not be found* | Projektet har ingen tillgång till det andra projektet | Lägg till en `<ProjectReference>` (steg 5) |
| `CS0122` *'X' is inaccessible due to its protection level* | Klassen eller metoden är inte `public` | Lägg till `public` framför klassen och metoden |
| `CS5001` *Program does not contain a static 'Main' method* | Programmet saknar startpunkt | Skriv kod direkt i `Program.cs` eller lägg till en `Main`-metod |
| `CS8802` *Only one compilation unit can have top-level statements* | Två filer har kod utanför en klass | Flytta koden till en fil, eller lägg den i en klass |
| `MSB1011` *more than one project or solution file* | Mappen innehåller flera `.sln`/`.slnx`, och kommandot vet inte vilken du menar | Skriv ut filnamnet, till exempel `dotnet sln MinApp.slnx add …` |
