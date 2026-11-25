# Så fungerar C#

Den här guiden förklarar vad som faktiskt händer från det att du skriver
kod tills programmet körs. Du behöver inte kunna allt utantill, men det
hjälper att ha en bild av helheten.

---

## Från kod till program

Datorn förstår inte C#. Den förstår bara maskinkod, alltså ettor och nollor.
Därför behövs två steg:

```
  Grunder.cs                Grunder.dll                 Programmet körs
 ┌──────────────┐  bygga  ┌──────────────┐   köra   ┌──────────────────┐
 │ int x = 5;   │ ──────▶ │ 0x2A 0x16 …  │ ───────▶ │ Hej, klassen!    │
 │ if (x > 3)…  │         │ (mellankod)  │          │                  │
 └──────────────┘         └──────────────┘          └──────────────────┘
   du skriver               kompilatorn                .NET kör den
                            översätter
```

| Steg | Vad som händer | Vem gör det |
|---|---|---|
| **1. Skriva** | Du skriver C#-kod i `.cs`-filer | Du |
| **2. Bygga** (kompilera) | Kompilatorn kontrollerar koden och översätter den till en `.dll`-fil | Kompilatorn, när du trycker **Ctrl+Shift+B** eller ▶ |
| **3. Köra** | .NET läser `.dll`-filen och kör den på datorn | .NET |

När du trycker på ▶ Start i Visual Studio sker steg 2 och 3 direkt efter
varandra.

---

## Vad är vad?

| Namn | Vad det är | Liknelse |
|---|---|---|
| **C#** | Programspråket, alltså reglerna för hur koden skrivs | Svenska språket |
| **.NET** | Plattformen som kör C#-program och har tusentals färdiga klasser, som `Console` och `List` | Ett bibliotek fullt av färdiga verktyg |
| **.NET SDK** | Verktygen för att *bygga* program: kompilatorn och kommandot `dotnet` | En verkstad |
| **Visual Studio** | Programmet du skriver kod i. Det har editor, byggknapp, debugger och testverktyg | Ett skrivbord med allt inom räckhåll |
| **Kompilatorn** | Översätter din kod och letar efter fel | En korrekturläsare som också översätter |

Visual Studio använder samma .NET SDK som kommandot `dotnet` i PowerShell.
Därför fungerar både ▶ i Visual Studio och `dotnet run`.

---

## Grundregler för C#-kod

```csharp
using Verktyg;                              // 1. using högst upp

int antal = 3;                              // 2. varje sats slutar med ;

if (antal > 2)                              // 3. { } håller ihop ett block
{
    Console.WriteLine("Många!");            // 4. text inom " "
}

// Det här är en kommentar. Den ignoreras av datorn.
```

| Regel | Exempel |
|---|---|
| Varje **sats** (instruktion) slutar med semikolon | `int x = 5;` |
| **Klamrar** `{ }` håller ihop kod som hör ihop | Kroppen i en `if`, en loop eller en metod |
| C# skiljer på **stora och små bokstäver** | `Console` fungerar, `console` gör det inte |
| **Text** skrivs inom dubbla citattecken | `"Hej"` |
| **Kommentarer** börjar med `//` | `// en anteckning till dig själv` |
| **Indrag** (mellanslag i början av raden) är för människor | Datorn bryr sig inte, men koden blir lättare att läsa |

Tips: tryck **Ctrl+K, Ctrl+D** i Visual Studio så rättas indragen automatiskt.

---

## Tre sorters fel

Alla programmerare får fel hela tiden. Det viktiga är att veta **vilken
sort** felet är, eftersom de hittas på olika sätt.

### 1. Kompileringsfel: koden går inte att bygga
Kompilatorn förstår inte koden. Programmet kan inte köras alls.

```csharp
int x = 5      // saknar ;
Console.Writeline("Hej");   // fel stavning: ska vara WriteLine
```

- **Syns:** röda vågiga streck under koden, och i fönstret **Error List** (**View → Error List**).
- **Känns igen på:** en felkod som börjar med `CS`, till exempel `CS1002: ; expected`.
- **Gör så här:** dubbelklicka på felet i Error List så hoppar Visual Studio till rätt rad. Läs meddelandet, och googla felkoden om du inte förstår.

### 2. Körfel: programmet kraschar
Koden kunde byggas, men något gick fel när den kördes.

```csharp
int[] tal = { 1, 2, 3 };
Console.WriteLine(tal[3]);   // det finns ingen plats 3!
```

- **Syns:** programmet stannar och Visual Studio visar ett **Exception**, till exempel `IndexOutOfRangeException`.
- **Gör så här:** läs namnet på felet och titta på raden som är markerad. Vanliga exempel:

| Exception | Betyder ungefär |
|---|---|
| `IndexOutOfRangeException` | Du försökte läsa en plats i en array som inte finns |
| `NullReferenceException` | Du använde en variabel som inte pekar på något |
| `FormatException` | `int.Parse` fick text som inte är ett tal |
| `DivideByZeroException` | Du delade ett heltal med 0 |
| `NotImplementedException` | Metoden är inte skriven än (står i alla uppgifter från början) |

### 3. Logiska fel: programmet ger fel svar
Allt verkar fungera, men svaret är fel. Det är det svåraste felet,
eftersom datorn inte säger något.

```csharp
int summa = 0;
for (int i = 1; i < 5; i++)    // ska vara <= om 5 ska komma med
{
    summa += i;
}
```

- **Syns:** ett **rött test**, eller ett konstigt svar i Provkör.
- **Gör så här:** provkör med enkla värden där du vet svaret, och använd debuggern. Se [Testkör din kod själv](testkora.md).

Testerna i kursen finns till stor del för att hitta just logiska fel.

---

## Vad händer när jag trycker på ▶?

1. Visual Studio **sparar** alla filer.
2. Kompilatorn **bygger** startprojektet och alla projekt det refererar till.
3. Finns det kompileringsfel: **stopp**. Du får se felen.
4. Annars **startar** .NET programmet från startpunkten, alltså `Main`
   eller filen med top-level statements.
5. Ett konsolfönster visar det som skrivs ut med `Console.WriteLine`.

Mer om startprojekt och varför bibliotek inte kan startas:
[Filstrukturen i C#](filstruktur.md).
