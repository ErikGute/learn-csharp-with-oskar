# Övning 04: Träning – 40 små uppgifter

Många korta uppgifter där du får öva mycket. Varje uppgift är en egen metod
och tar oftast bara några rader kod. För varje uppgift står **exakt vad som
ska komma ut**.

| Del | Fil att skriva i | Uppgifter | Läs först |
|---|---|---|---|
| 1. Räkna | [`Traning/Rakna.cs`](Traning/Rakna.cs) | 1–8 | [Variabler och datatyper](../guider/variabler-och-datatyper.md) |
| 2. Text | [`Traning/Text.cs`](Traning/Text.cs) | 9–16 | [Arbeta med text](../guider/variabler-och-datatyper.md#arbeta-med-text) |
| 3. Villkor | [`Traning/Villkor.cs`](Traning/Villkor.cs) | 17–24 | [Villkor och loopar](../guider/villkor-och-loopar.md) |
| 4. Loopar | [`Traning/Loopar.cs`](Traning/Loopar.cs) | 25–32 | [Villkor och loopar](../guider/villkor-och-loopar.md) |
| 5. Arrayer | [`Traning/Arrayer.cs`](Traning/Arrayer.cs) | 33–40 | [Villkor och loopar](../guider/villkor-och-loopar.md#arrayer) |

Uppgifterna blir lite svårare inom varje del. Den sista i varje del är en
**utmaning**. ⭐

## Så jobbar du

1. Öppna filen för delen och leta upp uppgiften.
2. Ta bort `throw new NotImplementedException();` och skriv din kod.
3. **Provkör:** högerklicka på `Traning.Provkor` → **Set as Startup Project** → ▶.
   Jämför med tabellen nedan. Byt gärna till egna värden i
   [`Traning.Provkor/Program.cs`](Traning.Provkor/Program.cs).
4. **Testa:** **Test → Run All Tests**. Testet för uppgiften ska bli grönt.
5. Commit, och nästa uppgift. Pusha i slutet av lektionen.

Du behöver inte göra uppgifterna i ordning. Fastnar du, hoppa till nästa
och kom tillbaka senare.

### Om ett test blir rött
Felmeddelandet säger exakt vad som är fel:
```
Medel(3, 4) ska bli 3.5, men blev 3.
```
Prova samma anrop i Provkör och se [Testkör din kod själv](../guider/testkora.md).

---

## Del 1: Räkna (`Rakna.cs`)

| Nr | Uppgift | Anrop | Ska bli |
|---|---|---|---|
| 1 | Talet gånger två | `Dubbla(4)` | `8` |
| | | `Dubbla(-3)` | `-6` |
| 2 | Talet gånger sig självt | `Kvadrat(5)` | `25` |
| | | `Kvadrat(-4)` | `16` |
| 3 | Medelvärdet som decimaltal | `Medel(3, 4)` | `3.5` |
| | | `Medel(10, 20)` | `15.0` |
| 4 | Resten vid division | `Rest(17, 5)` | `2` |
| | | `Rest(10, 2)` | `0` |
| 5 | Sekunder till hela minuter | `HelaMinuter(130)` | `2` |
| | | `HelaMinuter(59)` | `0` |
| 6 | Celsius till Fahrenheit: `C * 9 / 5 + 32` | `CelsiusTillFahrenheit(100)` | `212.0` |
| | | `CelsiusTillFahrenheit(37.5)` | `99.5` |
| 7 | Arean av en rektangel | `Rektangelarea(3, 4)` | `12.0` |
| | | `Rektangelarea(2.5, 2)` | `5.0` |
| 8 | Pris med 25 % moms | `MedMoms(100)` | `125.0` |
| | | `MedMoms(80)` | `100.0` |

## Del 2: Text (`Text.cs`)

| Nr | Uppgift | Anrop | Ska bli |
|---|---|---|---|
| 9 | Hälsning | `Halsa("Ali")` | `"Hej, Ali!"` |
| 10 | Antal tecken | `AntalTecken("hej då")` | `6` |
| | | `AntalTecken("")` | `0` |
| 11 | Första tecknet (en `char`) | `ForstaTecknet("Sara")` | `'S'` |
| 12 | Stora bokstäver | `Versaler("Hej Då 2")` | `"HEJ DÅ 2"` |
| 13 | Presentation | `Presentera("Sara", 16)` | `"Jag heter Sara och är 16 år."` |
| 14 | Antal små `a` | `AntalA("banan")` | `2` |
| | | `AntalA("Anna")` | `1` |
| 15 | Texten baklänges | `Baklanges("abc")` | `"cba"` |
| | | `Baklanges("")` | `""` |
| 16 ⭐ | Samma framlänges och baklänges? | `ArPalindrom("kajak")` | `true` |
| | | `ArPalindrom("bil")` | `false` |

## Del 3: Villkor (`Villkor.cs`)

| Nr | Uppgift | Anrop | Ska bli |
|---|---|---|---|
| 17 | Större än noll? | `ArPositivt(5)` | `true` |
| | | `ArPositivt(0)` | `false` |
| 18 | 18 år eller äldre? | `ArMyndig(18)` | `true` |
| | | `ArMyndig(17)` | `false` |
| 19 | Minst av tre tal | `MinstAvTre(4, 2, 9)` | `2` |
| | | `MinstAvTre(-1, 0, -5)` | `-5` |
| 20 | Positivt, negativt eller noll | `Tecken(5)` | `"positivt"` |
| | | `Tecken(-3)` | `"negativt"` |
| | | `Tecken(0)` | `"noll"` |
| 21 | Biljettpris: under 12 → 50, 65+ → 70, annars 100 | `Biljettpris(8)` | `50` |
| | | `Biljettpris(12)` | `100` |
| | | `Biljettpris(65)` | `70` |
| 22 | Veckodag 1–7, annars `"ogiltig"` | `Veckodag(1)` | `"måndag"` |
| | | `Veckodag(7)` | `"söndag"` |
| | | `Veckodag(9)` | `"ogiltig"` |
| 23 | FizzBuzz | `FizzBuzz(9)` | `"Fizz"` |
| | | `FizzBuzz(10)` | `"Buzz"` |
| | | `FizzBuzz(15)` | `"FizzBuzz"` |
| | | `FizzBuzz(7)` | `"7"` |
| 24 ⭐ | Skottår? | `ArSkottar(2024)` | `true` |
| | | `ArSkottar(1900)` | `false` |
| | | `ArSkottar(2000)` | `true` |

## Del 4: Loopar (`Loopar.cs`)

| Nr | Uppgift | Anrop | Ska bli |
|---|---|---|---|
| 25 | Stjärnor i rad | `Stjarnor(5)` | `"*****"` |
| | | `Stjarnor(0)` | `""` |
| 26 | Räkna från 1 | `RaknaTill(5)` | `"1 2 3 4 5"` |
| 27 | Nedräkning | `Nedrakning(3)` | `"3 2 1 Start!"` |
| 28 | Summan av jämna tal upp till n | `SummaJamna(10)` | `30` |
| | | `SummaJamna(5)` | `6` |
| 29 | Fakultet: 1 · 2 · … · n | `Fakultet(5)` | `120` |
| | | `Fakultet(0)` | `1` |
| 30 | Potens med loop | `Potens(2, 3)` | `8` |
| | | `Potens(7, 0)` | `1` |
| 31 | Antal siffror | `AntalSiffror(12345)` | `5` |
| | | `AntalSiffror(0)` | `1` |
| 32 ⭐ | Summan av siffrorna | `Siffersumma(1234)` | `10` |
| | | `Siffersumma(99)` | `18` |

## Del 5: Arrayer (`Arrayer.cs`)

| Nr | Uppgift | Anrop | Ska bli |
|---|---|---|---|
| 33 | Första talet | `Forsta([4, 8, 1])` | `4` |
| 34 | Sista talet | `Sista([4, 8, 1])` | `1` |
| 35 | Minsta talet | `Minsta([4, 8, 1, 6])` | `1` |
| | | `Minsta([-2, -9, 0])` | `-9` |
| 36 | Finns talet? | `Innehaller([4, 8, 1], 8)` | `true` |
| | | `Innehaller([4, 8, 1], 5)` | `false` |
| 37 | Antal negativa tal | `AntalNegativa([3, -1, 0, -7])` | `2` |
| 38 | Var finns talet? (`-1` om det saknas) | `IndexAv([4, 8, 1, 8], 8)` | `1` |
| | | `IndexAv([4, 8, 1], 5)` | `-1` |
| 39 | Ny array med dubbla tal | `Dubblera([1, 2, 3])` | `[2, 4, 6]` |
| 40 ⭐ | Ny array med bara jämna tal | `BaraJamna([1, 2, 3, 4, 6])` | `[2, 4, 6]` |
| | | `BaraJamna([1, 3])` | `[]` |

> I tabellen skrivs arrayer som `[4, 8, 1]`. I C#-kod skriver du
> `new[] { 4, 8, 1 }` eller `new int[] { 4, 8, 1 }`.

---

## Testerna
Det finns 40 tester, ett per uppgift. Testerna provar fler värden än de i
tabellen, särskilt **kantfall** som `0`, negativa tal och tomma arrayer.

## Mina framsteg
Kopiera listan till ett papper eller en egen fil och bocka av:

```
Del 1  [ ]1  [ ]2  [ ]3  [ ]4  [ ]5  [ ]6  [ ]7  [ ]8
Del 2  [ ]9  [ ]10 [ ]11 [ ]12 [ ]13 [ ]14 [ ]15 [ ]16⭐
Del 3  [ ]17 [ ]18 [ ]19 [ ]20 [ ]21 [ ]22 [ ]23 [ ]24⭐
Del 4  [ ]25 [ ]26 [ ]27 [ ]28 [ ]29 [ ]30 [ ]31 [ ]32⭐
Del 5  [ ]33 [ ]34 [ ]35 [ ]36 [ ]37 [ ]38 [ ]39 [ ]40⭐
```
