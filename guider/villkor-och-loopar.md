# Guide: Villkor, loopar och arrayer

## Villkor: `if`, `else if`, `else`

Ett villkor låter programmet välja väg.

```csharp
if (poang >= 90)
{
    Console.WriteLine("A");
}
else if (poang >= 50)
{
    Console.WriteLine("Godkänd");
}
else
{
    Console.WriteLine("Inte godkänd");
}
```

Datorn testar villkoren **uppifrån och ned** och kör bara det **första**
som är sant. Ordningen spelar alltså roll.

### Jämförelser

| Skrivs | Betyder | Exempel som är sant |
|---|---|---|
| `==` | lika med | `5 == 5` |
| `!=` | inte lika med | `5 != 3` |
| `<` / `>` | mindre än / större än | `3 < 5` |
| `<=` / `>=` | mindre/större än eller lika med | `5 >= 5` |

### Kombinera villkor

| Skrivs | Betyder | Exempel |
|---|---|---|
| `&&` | och (båda måste vara sanna) | `alder >= 13 && alder <= 19` |
| `\|\|` | eller (minst ett måste vara sant) | `dag == "lördag" \|\| dag == "söndag"` |
| `!` | inte | `!klar` |

### `switch`: välja bland många fasta värden
När ett värde ska jämföras med många olika alternativ blir `switch` ofta
tydligare än en lång rad med `else if`:

```csharp
switch (nummer)
{
    case 1:
        return "ett";
    case 2:
        return "två";
    default:              // alla andra värden
        return "många";
}
```

⚠️ **Vanligt fel:** `=` betyder *lägg värdet i variabeln*, medan `==`
betyder *är lika med?*. I ett villkor ska det nästan alltid vara `==`.

---

## Loopar: upprepa kod

### `for`: när du vet hur många varv
```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);       // skriver 1, 2, 3, 4, 5
}
```

En for-loop har tre delar inom parentesen:

| Del | Exempel | Betyder |
|---|---|---|
| Start | `int i = 1` | Räknaren börjar på 1 |
| Villkor | `i <= 5` | Fortsätt så länge detta är sant |
| Steg | `i++` | Öka räknaren med 1 efter varje varv |

### `while`: när du inte vet hur många varv
```csharp
int tal = 100;
while (tal > 1)
{
    tal = tal / 2;
    Console.WriteLine(tal);     // 50, 25, 12, 6, 3, 1
}
```

### `foreach`: gå igenom alla saker i en array eller lista
```csharp
int[] betyg = { 12, 15, 9 };
foreach (int b in betyg)
{
    Console.WriteLine(b);
}
```

### Avbryta tidigt
- `break` hoppar ut ur loopen direkt.
- `continue` hoppar till nästa varv.

---

## Arrayer

En array är en rad med lådor av samma typ. Varje låda har ett nummer, ett
**index**, som börjar på **0**.

```csharp
int[] tal = { 4, 9, 2 };
//  index:    0  1  2

tal[0]          // 4, det första talet
tal[2]          // 2, det sista talet
tal.Length      // 3, antal tal
tal[1] = 7;     // byter 9 mot 7
```

Skapa en tom array med plats för 10 tal (alla börjar som 0):
```csharp
int[] tabell = new int[10];
```

⚠️ **Vanligt fel:** `tal[3]` finns inte i en array med 3 tal. Då får du
`IndexOutOfRangeException`. Det sista indexet är alltid `Length - 1`.

---

## Fyra loopmönster som återkommer hela tiden

De flesta loopuppgifter är något av de här mönstren. Lär dig känna igen dem!

### 1. Summera
```csharp
int summa = 0;                      // börja på 0
for (int i = 0; i < tal.Length; i++)
{
    summa += tal[i];                // lägg till varje tal
}
```

### 2. Räkna
```csharp
int antal = 0;                      // börja på 0
foreach (int t in tal)
{
    if (t > 10)                     // villkor inne i loopen
    {
        antal++;                    // räkna upp när villkoret stämmer
    }
}
```

### 3. Hitta största
```csharp
int storsta = tal[0];               // anta att det första är störst
foreach (int t in tal)
{
    if (t > storsta)
    {
        storsta = t;                // hittade ett större, kom ihåg det
    }
}
```

### 4. Fylla en ny array
```csharp
int[] dubbla = new int[tal.Length]; // ny array, samma längd
for (int i = 0; i < tal.Length; i++)
{
    dubbla[i] = tal[i] * 2;
}
```

---

## Vanliga loopfel

| Fel | Exempel | Vad som händer |
|---|---|---|
| Ett varv för lite | `i < 5` när du menade `i <= 5` | Sista talet kommer inte med |
| Ett varv för mycket | `i <= tal.Length` | `IndexOutOfRangeException` |
| Oändlig loop | `while (x > 0)` där `x` aldrig ändras | Programmet hänger sig. Stoppa med **Shift+F5** |
| Startvärde i loopen | `int summa = 0;` **inuti** loopen | Summan nollställs varje varv |

---

## Prova själv i Provkör

Lägg till i `01-grunder/Grunder.Provkor/Program.cs` och kör:

```csharp
// 1. Skriv ut 10, 9, 8 ... 1 med en for-loop som räknar NEDÅT
for (int i = 10; i >= 1; i--)
{
    Console.Write(i + " ");
}
Console.WriteLine();

// 2. Skriv ut alla tal mellan 1 och 30 som är delbara med 3
//    Tips: använd % och if inne i loopen.

// 3. Hur många gånger kan man halvera 1000 innan man kommer under 1?
//    Tips: while-loop och en räknare.
```

**Kopplat till övning 01:** uppgift 4 är mönstret *summera*, uppgift 5 och 9
är *räkna*, uppgift 8 är *hitta största* och uppgift 6 och 11 är *fylla en
ny array*.
