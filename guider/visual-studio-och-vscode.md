# Guide: Arbeta i Visual Studio och VS Code

Det finns två vanliga program för att skriva C#. Båda fungerar i kursen.

| | Visual Studio | VS Code |
|---|---|---|
| Vad | En komplett utvecklingsmiljö (IDE) | En lätt kodeditor med tillägg |
| Fungerar på | Windows | Windows, Mac, Linux, i webbläsaren |
| Öppnar du | `.sln`- eller `.slnx`-filen | Mappen med repot |
| Bra för | Allt i kursen, särskilt debuggern och testerna | Svagare datorer, Mac, eller om du gillar enkla verktyg |
| Kostar | Gratis (Community) | Gratis |

**Använd det programmet som din skola har valt.** Den här guiden tar upp
båda, så att du klarar dig även hemma.

---

# Del 1: Visual Studio

## Öppna kursen
```powershell
cd C:\github-repos\learn-csharp-with-oskar
start learn-csharp-with-oskar.sln
```
Eller: **File → Open → Project/Solution** och välj `.sln`-filen.

## Fönstren du behöver

```
┌──────────────────────────────────────────────────────────────────┐
│  Meny och verktygsfält            ▶ Start   [startprojekt ▼]     │
├──────────────────────────────────────────┬───────────────────────┤
│                                          │  Solution Explorer    │
│                                          │  ├─ 01-grunder        │
│           EDITORN                        │  │  ├─ Grunder        │
│           (här skriver du kod)           │  │  ├─ Grunder.Provkor│
│                                          │  │  └─ Grunder.Tests  │
│                                          │  └─ ...               │
├──────────────────────────────────────────┴───────────────────────┤
│  Error List  |  Output  |  Test Explorer  |  Terminal            │
└──────────────────────────────────────────────────────────────────┘
```

| Fönster | Till för | Öppna med |
|---|---|---|
| **Solution Explorer** | Alla projekt och filer. Dubbelklicka för att öppna | **View → Solution Explorer** (Ctrl+Alt+L) |
| **Error List** | Alla kompileringsfel. Dubbelklicka för att hoppa till felet | **View → Error List** |
| **Output** | Meddelanden när du bygger | **View → Output** |
| **Test Explorer** | Alla tester, gröna och röda | **Test → Test Explorer** |
| **Terminal** | PowerShell inne i Visual Studio, för Git-kommandon | **View → Terminal** |
| **Git Changes** | Commit och push med knappar | **View → Git Changes** |

Har du stängt ett fönster av misstag? Öppna det igen via **View**-menyn.
Är allt kaos? Välj **Window → Reset Window Layout**.

## Köra, testa och debugga

| Jag vill… | Gör så här |
|---|---|
| Välja vilket program som körs | Högerklicka på projektet → **Set as Startup Project** |
| Bygga | **Ctrl+Shift+B** |
| Köra med debugger | **F5** eller ▶ |
| Köra utan debugger (snabbare) | **Ctrl+F5** |
| Stoppa | **Shift+F5** |
| Sätta en brytpunkt | Klicka i vänstermarginalen, eller **F9** |
| Köra alla tester | **Test → Run All Tests** (Ctrl+R, A) |
| Debugga ett test | Högerklicka på testet i Test Explorer → **Debug** |

Mer om debuggern finns i [Testkör din kod själv](testkora.md#3-debuggern-stega-igenom-koden).

## Commit och push i Visual Studio
1. Öppna **View → Git Changes**.
2. Skriv ett meddelande i rutan högst upp.
3. Klicka på pilen bredvid **Commit All** och välj **Commit All and Push**.

För att hämta lärarens uppdateringar: använd **Terminal** och kommandona i
[README-filen](../README.md#nya-övningar-från-läraren).

## Smarta funktioner i editorn

| Funktion | Kortkommando | Vad den gör |
|---|---|---|
| **IntelliSense** | Dyker upp när du skriver, eller **Ctrl+Space** | Förslag på metoder och variabler. Tryck **Tab** för att välja |
| **Snabbfix** (glödlampan) | **Ctrl+.** | Förslag på hur ett fel kan rättas, t.ex. lägga till `using` |
| **Gå till definition** | **F12** | Hoppa till där en metod eller klass är skriven |
| **Byt namn** | **Ctrl+R, Ctrl+R** | Byter namn på en variabel eller metod överallt |
| **Formatera** | **Ctrl+K, Ctrl+D** | Rättar indrag och mellanslag |
| **Kommentera bort** | **Ctrl+K, Ctrl+C** | Gör markerade rader till kommentarer |
| **Ta bort kommentar** | **Ctrl+K, Ctrl+U** | Tvärtom |
| **Sök efter fil eller metod** | **Ctrl+T** | Sök i hela solutionen |

**Kodsnuttar:** skriv `cw` och tryck **Tab två gånger** så blir det
`Console.WriteLine();`. Det fungerar också med `for`, `foreach`, `if` och
`while`.

---

# Del 2: VS Code

## Installera (en gång)
1. Installera **VS Code** från code.visualstudio.com.
2. Installera **.NET 10 SDK** från dotnet.microsoft.com.
3. Öppna VS Code, klicka på **Extensions** i vänsterlisten (fyra rutor)
   och installera **C# Dev Kit** från Microsoft. Det är gratis för
   skolarbete.

## Öppna kursen
```powershell
cd C:\github-repos\learn-csharp-with-oskar
code .
```
Eller: **File → Open Folder** och välj repomappen. Punkten i `code .`
betyder *den här mappen*.

## Panelerna du behöver

| Panel | Till för | Öppna med |
|---|---|---|
| **Explorer** | Alla filer och mappar | Översta ikonen i vänsterlisten (Ctrl+Shift+E) |
| **Solution Explorer** | Projekten, som i Visual Studio | Längst ner i Explorer-panelen (kommer med C# Dev Kit) |
| **Problems** | Alla kompileringsfel | **View → Problems** (Ctrl+Shift+M) |
| **Testing** | Alla tester (kolvikonen i vänsterlisten) | **View → Testing** |
| **Terminal** | PowerShell | **View → Terminal** |
| **Source Control** | Commit och push med knappar | Ikonen med grenar i vänsterlisten (Ctrl+Shift+G) |

## Köra, testa och debugga

| Jag vill… | Gör så här |
|---|---|
| Köra ett program | I terminalen: `dotnet run --project 01-grunder/Grunder.Provkor` |
| Bygga | I terminalen: `dotnet build` |
| Köra alla tester | Kolvikonen → ▶ högst upp. Eller i terminalen: `dotnet test` |
| Debugga ett program | Öppna `Program.cs` i Provkör-projektet och tryck **F5**. Välj **C#** om VS Code frågar |
| Sätta en brytpunkt | Klicka till vänster om radnumret, eller **F9** |
| Debugga ett test | Högerklicka på den gröna/röda pilen bredvid testet → **Debug Test** |

## Commit och push i VS Code
1. Öppna **Source Control** (Ctrl+Shift+G).
2. Skriv ett meddelande i rutan högst upp.
3. Klicka på **Commit**. Svara **Yes** om VS Code frågar om alla ändringar ska tas med.
4. Klicka på **Sync Changes** för att pusha.

## Smarta funktioner i editorn

| Funktion | Kortkommando |
|---|---|
| Förslag (IntelliSense) | Dyker upp automatiskt, eller **Ctrl+Space** |
| Snabbfix (glödlampan) | **Ctrl+.** |
| Gå till definition | **F12** |
| Byt namn | **F2** |
| Formatera | **Shift+Alt+F** |
| Kommentera / ta bort kommentar | **Ctrl+K, Ctrl+C** / **Ctrl+K, Ctrl+U** |
| Öppna fil snabbt | **Ctrl+P** |
| Sök bland alla kommandon | **Ctrl+Shift+P** |

---

# Del 3: Samma sak med kommandon

Det här fungerar likadant oavsett program, i PowerShell eller i
terminalen inne i Visual Studio och VS Code:

| Jag vill… | Kommando |
|---|---|
| Bygga allt | `dotnet build` |
| Köra alla tester | `dotnet test` |
| Köra ett program | `dotnet run --project <mapp>` |
| Se vad som ändrats | `git status` |
| Spara och skicka | `git add .` → `git commit -m "…"` → `git push` |

Kommandona är bra att kunna. De fungerar på alla datorer, och det är så
GitHub Actions rättar din kod.

---

# Vanliga problem

| Problem | Lösning |
|---|---|
| Solution Explorer är tom (Visual Studio) | Du har öppnat en mapp i stället för `.sln`-filen. **File → Open → Project/Solution** |
| Inga färger eller förslag i koden (VS Code) | C# Dev Kit är inte installerat, eller så har du öppnat en enskild fil i stället för mappen |
| ▶ ger fel om *class library* | Fel startprojekt. Högerklicka på Provkör-projektet → **Set as Startup Project** |
| Testerna syns inte i Test Explorer | Bygg först (**Ctrl+Shift+B**) |
| Testerna står som *Not Run* | Läs **Output**-fönstret (välj **Tests**). Visa läraren |
| `dotnet` känns inte igen | .NET SDK är inte installerat. Starta om terminalen efter installationen |
