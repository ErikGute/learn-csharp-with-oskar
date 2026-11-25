# Guide: Metoder (funktioner)

## Vad är en metod?

En metod är en **namngiven bit kod** som gör en sak. Du kan köra den, eller
*anropa* den som det heter, hur många gånger du vill. I andra språk kallas
metoder ofta **funktioner**.

En metod fungerar som en maskin: något går in, något kommer ut.

```
       in                          ut
   3 och 8  ──▶  [ StorstAvTva ]  ──▶  8
```

---

## En metods delar

```csharp
public static int StorstAvTva(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    return b;
}
```

| Del | I exemplet | Betyder |
|---|---|---|
| `public` | `public` | Andra klasser och projekt får använda metoden, till exempel testerna |
| `static` | `static` | Metoden kan anropas direkt via klassnamnet |
| **Returtyp** | `int` | Vilken typ av värde som kommer **ut** |
| **Namn** | `StorstAvTva` | Vad metoden heter. Skrivs med stor bokstav |
| **Parametrar** | `(int a, int b)` | Vad som går **in**. Varje parameter har en typ och ett namn |
| **Kropp** | `{ ... }` | Koden som körs |
| `return` | `return a;` | Skickar ut svaret **och avslutar metoden direkt** |

### Metoder som inte returnerar något: `void`
```csharp
public static void SagHej(string namn)
{
    Console.WriteLine($"Hej, {namn}!");
    // ingen return behövs
}
```

---

## Anropa en metod

```csharp
int storst = Ovningar.StorstAvTva(3, 8);
//  │              │         │        └── argument: värdena som skickas in
//  │              │         └─────────── metodens namn
//  │              └───────────────────── klassen som metoden ligger i
//  └──────────────────────────────────── variabel som tar emot svaret
```

- **Parameter** är namnet i metoden (`a`, `b`).
- **Argument** är värdet du skickar in (`3`, `8`).

Inne i metoden blir `a` lika med 3 och `b` lika med 8.

---

## Variabler inne i en metod

Variabler som skapas inne i en metod finns **bara där**. De försvinner när
metoden är klar:

```csharp
public static int Summa(int[] tal)
{
    int summa = 0;          // summa finns bara inne i Summa
    foreach (int t in tal)
    {
        summa += t;
    }
    return summa;           // värdet skickas ut, variabeln försvinner
}
```

---

## Varför metoder?

1. **Återanvändning.** Skriv koden en gång och använd den överallt.
   I övning 01 kan `AntalJamnaUppTill` anropa `ArJamnt`.
2. **Ordning.** Ett stort problem blir flera små, med tydliga namn.
3. **Testbarhet.** En metod med in- och utvärden går att testa automatiskt.

Det är precis så testerna fungerar: de anropar dina metoder med olika
värden och kontrollerar att det som kommer ut stämmer.

```csharp
// Så här ser ett av testerna i övning 01 ut:
Assert.Equal(8, Ovningar.StorstAvTva(3, 8));
//           │   └── anropa elevens metod med 3 och 8
//           └────── det som borde komma ut
```

---

## Vanliga fel

| Fel | Felmeddelande | Lösning |
|---|---|---|
| Glömt `return` | `CS0161` *not all code paths return a value* | Alla vägar genom metoden måste sluta med `return` |
| Fel typ på `return` | `CS0029` *Cannot implicitly convert type* | Returnera ett värde av samma typ som returtypen |
| Kod efter `return` | Varning `CS0162` *Unreachable code* | Koden efter `return` körs aldrig |
| Fel antal argument | `CS7036` / `CS1501` | Skicka in lika många värden som metoden har parametrar |

---

## Prova själv i Provkör

Du kan skriva egna metoder längst ner i en Provkör-fil, bredvid
hjälpmetoden `Prova`. Lägg till:

```csharp
static int Kvadrat(int tal)
{
    return tal * tal;
}
```

och anropa den högre upp i filen, ovanför `Console.WriteLine("Klart!");`:

```csharp
Console.WriteLine(Kvadrat(7));
int svar = Kvadrat(Kvadrat(2));     // en metod kan anropas med svaret från en annan!
Console.WriteLine(svar);
```

**Fler att prova:**
- `static bool ArPositivt(int tal)`: returnerar `true` om talet är större än 0
- `static string Halsa(string namn, int alder)`: returnerar t.ex. `"Hej Sara, du är 16 år!"`
- `static double Moms(double pris)`: returnerar priset med 25 % moms
