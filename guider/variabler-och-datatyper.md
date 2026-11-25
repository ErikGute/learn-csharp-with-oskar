# Guide: Variabler och datatyper

## Vad är en variabel?

En variabel är en **namngiven låda** som håller ett värde. Lådan har en
**typ** som bestämmer vad som får läggas i den.

```csharp
int alder = 16;
//  │    │     └── värdet som läggs i lådan
//  │    └──────── namnet på lådan
//  └───────────── typen: vad som får ligga i lådan (här ett heltal)
```

Du kan byta innehåll i lådan, men inte byta typ:

```csharp
int alder = 16;
alder = 17;          // ✅ okej, nytt heltal
alder = alder + 1;   // ✅ okej, nu är alder 18
alder = "arton";     // ❌ fel: en text får inte ligga i en int-låda
```

---

## De vanligaste datatyperna

| Typ | Innehåller | Exempel | Bra att veta |
|---|---|---|---|
| `int` | Heltal | `int antal = 42;` | Från ungefär −2,1 till +2,1 miljarder |
| `double` | Decimaltal | `double pris = 19.90;` | Skriv **punkt** i koden, inte komma |
| `bool` | Sant eller falskt | `bool klar = true;` | Bara `true` eller `false` |
| `string` | Text | `string namn = "Oskar";` | Dubbla citattecken `" "` |
| `char` | Ett enda tecken | `char bokstav = 'A';` | Enkla citattecken `' '` |
| `int[]` | Flera heltal i rad (array) | `int[] tal = { 4, 9, 2 };` | Fast längd. Se [loopar](villkor-och-loopar.md#arrayer) |
| `List<int>` | Flera heltal (lista) | `List<int> tal = new List<int> { 4, 9 };` | Kan växa med `.Add()` |

### `var`: låt datorn räkna ut typen
```csharp
var antal = 42;        // blir int
var namn = "Oskar";    // blir string
```
Typen bestäms ändå en gång för alla. `var` sparar bara skrivande.

---

## Räkna med variabler

| Operator | Betyder | Exempel | Resultat |
|---|---|---|---|
| `+` | plus | `7 + 2` | `9` |
| `-` | minus | `7 - 2` | `5` |
| `*` | gånger | `7 * 2` | `14` |
| `/` | delat med | `7 / 2` | `3` ⚠️ |
| `%` | rest vid division | `7 % 2` | `1` |

### ⚠️ Fällan: heltalsdivision
När **båda** talen är `int` blir svaret också `int`, och decimalerna
försvinner:

```csharp
int a = 7;
int b = 2;
Console.WriteLine(a / b);           // 3, inte 3.5!
Console.WriteLine((double)a / b);   // 3.5, nu räknas det som decimaltal
```

### Kortformer
```csharp
summa = summa + 5;   // kan skrivas:
summa += 5;

antal = antal + 1;   // kan skrivas:
antal++;
```

---

## Text och värden tillsammans

Med `$` framför texten kan du stoppa in variabler inom `{ }`:

```csharp
string namn = "Ali";
int poang = 85;
Console.WriteLine($"{namn} fick {poang} poäng.");   // Ali fick 85 poäng.
```

---

## Arbeta med text

En `string` är en rad med tecken (`char`). Precis som i en array har varje
tecken ett index som börjar på 0.

```csharp
string ord = "Hej";
//  index:    012

ord.Length          // 3, antal tecken
ord[0]              // 'H', första tecknet (en char)
ord[ord.Length - 1] // 'j', sista tecknet
ord.ToUpper()       // "HEJ"
ord.ToLower()       // "hej"
ord + " då"         // "Hej då", sätt ihop text med +
ord == "Hej"        // true, jämför text
```

Gå igenom tecknen ett i taget:
```csharp
foreach (char tecken in ord)
{
    Console.WriteLine(tecken);    // H, e, j
}
```

Bygg ihop en ny text i en loop:
```csharp
string resultat = "";             // börja med tom text
for (int i = 0; i < 3; i++)
{
    resultat += "ha";             // lägg till i slutet
}
// resultat är nu "hahaha"
```

⚠️ `'a'` (enkla citattecken) är en `char`, medan `"a"` (dubbla) är en
`string`. Jämför ett tecken med `tecken == 'a'`.

---

## Byta mellan typer

| Från → till | Så gör du | Exempel |
|---|---|---|
| `int` → `double` | Händer automatiskt | `double d = 5;` |
| `double` → `int` | Tvinga med `(int)`. Decimalerna klipps bort | `(int)3.9` blir `3` |
| `string` → `int` | `int.Parse(...)` | `int.Parse("42")` blir `42` |
| vad som helst → `string` | `.ToString()` eller `$"{...}"` | `42.ToString()` blir `"42"` |

---

## Namn på variabler

- Börja med liten bokstav och skriv ihop: `antalElever`, `hogstaPoang`.
- Välj namn som säger vad det är: `summa` är bättre än `s`.
- Undvik å, ä och ö i namn. Det fungerar, men ställer ofta till det.

---

## Prova själv i Provkör

Öppna `01-grunder/Grunder.Provkor/Program.cs` och lägg till raderna
**ovanför** `Console.WriteLine("Klart!");`. Tryck ▶ och gissa svaret
**innan** du kör.

```csharp
// 1. Heltalsdivision
Console.WriteLine(7 / 2);
Console.WriteLine(7.0 / 2);
Console.WriteLine(7 % 2);

// 2. Decimaltal är inte alltid exakta
Console.WriteLine(0.1 + 0.2);

// 3. Vad händer när ett int blir för stort?
int stort = int.MaxValue;
stort = stort + 1;
Console.WriteLine(stort);

// 4. Gör om text till tal
string text = "15";
int tal = int.Parse(text);
Console.WriteLine(tal * 2);
```

**Fundera på:** Varför blev svaret på nummer 3 negativt? Vilken typ hade
du valt för att spara ett pris i kronor och ören?

> Datorn kan skriva ut decimaltal med komma (`3,5`) eftersom Windows är
> inställt på svenska. I koden skriver man ändå alltid punkt (`3.5`).
