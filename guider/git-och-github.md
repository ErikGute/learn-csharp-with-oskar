# Git och GitHub

**Git** och **GitHub** är inte samma sak:

| | Git | GitHub |
|---|---|---|
| Vad | Ett **program** som håller koll på versioner av dina filer | En **webbplats** där man lagrar och delar Git-repon |
| Var | På din dator | På internet |
| Används till | Spara versioner, gå tillbaka, slå ihop ändringar | Dela kod, samarbeta, köra automatisk rättning |
| Liknelse | Spara-funktionen i ett spel, med alla sparfiler kvar | En molntjänst för sparfilerna |

---

## Varför använder man Git?

Utan Git blir det lätt så här:
```
uppgift.cs
uppgift_fungerar.cs
uppgift_fungerar_NY.cs
uppgift_fungerar_NY_final.cs
```

Med Git finns **en** fil, och Git kommer ihåg alla tidigare versioner:
```
a1b2c3d  Löste uppgift 3
e4f5a6b  Löste uppgift 2
c7d8e9f  Löste uppgift 1
```

Programmerare använder Git för att:
- **gå tillbaka** om något går sönder
- **se vad som ändrats** och när
- **jobba flera** i samma kod utan att skriva över varandras ändringar

---

## Grundbegreppen

### Repository (repo)
En mapp som Git håller koll på. Git sparar sin historik i en dold
undermapp som heter `.git`. Den ska du aldrig röra.

### Commit: en sparpunkt
En commit är en **ögonblicksbild** av alla filer, plus ett meddelande om
vad som ändrats. Varje commit får ett id, till exempel `a1b2c3d`.

En commit görs i två steg:

```
  Dina filer           Staging area            Historiken
 ┌────────────┐       ┌────────────┐          ┌────────────┐
 │ ändrade    │ ────▶ │ redo att   │ ───────▶ │ sparad     │
 │ filer      │  add  │ sparas     │  commit  │ version    │
 └────────────┘       └────────────┘          └────────────┘
```

```powershell
git add .                               # 1. välj vad som ska sparas (punkt = allt)
git commit -m "Löste uppgift 3"         # 2. spara med ett meddelande
```

**Ett bra commit-meddelande** säger *vad* du gjorde: `Löste uppgift 3`,
`Rättade fel i Betyg`. Undvik `fix` och `asdf`.

### Remote: en kopia någon annanstans
En **remote** är ett smeknamn för en adress till ett repo på internet.
I kursen har du två:

| Remote | Pekar på | Du gör |
|---|---|---|
| `origin` | **Din fork** på GitHub | `git push`, alltså skickar ditt arbete |
| `upstream` | **Lärarens repo** på GitHub | `git pull upstream main`, alltså hämtar nya övningar |

Se dina remotes med `git remote -v`.

### Branch: en gren
En branch är en egen spår-linje av commits. I kursen använder du bara
huvudgrenen `main`.

---

## Kommandona i kursen

| Kommando | Gör | Rör dina filer? |
|---|---|---|
| `git clone <adress>` | Laddar ner ett repo till datorn (en gång) | Skapar en ny mapp |
| `git status` | Visar vad som ändrats sedan senaste commit | Nej |
| `git add .` | Lägger alla ändringar i staging area | Nej |
| `git commit -m "…"` | Sparar en version lokalt | Nej |
| `git push` | Skickar dina commits till din fork | Nej |
| `git fetch upstream` | Kollar vad som finns hos läraren | Nej |
| `git pull upstream main` | Hämtar och slår ihop lärarens ändringar | **Ja** |
| `git log --oneline` | Visar historiken | Nej |

### `git status` är din bästa vän
Kör den så fort du är osäker. Den talar om läget:

| `git status` säger | Betyder |
|---|---|
| *nothing to commit, working tree clean* | Allt är sparat i en commit |
| *Changes not staged for commit* | Du har ändrat filer men inte kört `git add` |
| *Changes to be committed* | Du har kört `git add` men inte `git commit` |
| *Your branch is ahead of 'origin/main' by 2 commits* | Du har commits som inte är pushade. Kör `git push` |

---

## GitHub: det som händer på webben

### Fork
En **fork** är din egen kopia av någon annans repo, på ditt GitHub-konto.
Du får skriva i den, men inte i originalet. Så fungerar open source: man
forkar, gör ändringar och föreslår dem tillbaka.

### Clone eller fork?
| | Fork | Clone |
|---|---|---|
| Var | På GitHub | Från GitHub till din dator |
| Skapar | En kopia på ditt GitHub-konto | En kopia på din dator |
| I kursen | Görs en gång, av lärarens repo | Görs en gång, av **din fork** |

### Actions: automatisk rättning
**GitHub Actions** kör ett program på GitHubs datorer varje gång du pushar.
I kursen kör det testerna och visar resultatet. Mer om det i
[Tester och autorättning](tester-och-autorattning.md).

---

## Hur allt hänger ihop

```
   LÄRARENS REPO ───fork───▶ DIN FORK ───clone───▶ DIN DATOR
   (upstream)                (origin)                   │
        │                        ▲                      │ add + commit
        │                        └────────push──────────┤
        └────────────── pull upstream main ─────────────┘
```

1. **Fork** och **clone** görs en gång.
2. Varje lektion: `add` + `commit` + `push`.
3. När läraren har lagt ut något nytt: `pull upstream main`, sedan `push`.

---

## Ordlista

| Ord | Betyder |
|---|---|
| **Repo** | En mapp med kod som Git håller koll på |
| **Commit** | En sparad version av filerna, med ett meddelande |
| **Push** | Skicka commits från datorn till GitHub |
| **Pull** | Hämta commits från GitHub och slå ihop med dina |
| **Fetch** | Kolla vad som finns på GitHub, utan att ändra något |
| **Clone** | Ladda ner ett repo till datorn |
| **Fork** | Kopiera någon annans repo till ditt GitHub-konto |
| **Remote** | En adress till ett repo någon annanstans (`origin`, `upstream`) |
| **Branch** | En gren av historiken (i kursen bara `main`) |
| **Merge** | Slå ihop två versioner av koden |
| **Konflikt** | Två personer har ändrat samma rad, och Git vet inte vilken som ska gälla |
| **`.gitignore`** | En lista över filer som Git inte ska spara, till exempel `bin` och `obj` |
| **Staging area** | Väntrummet mellan `add` och `commit` |
