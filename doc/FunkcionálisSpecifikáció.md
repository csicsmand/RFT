# Funkcionális specifikáció 

## Áttekintés
A következőkben egy olyan rendszer fejlesztésén fogunk dolgozni, mely az ASD Kft. munkáját könnyíti meg. Célunk ezzel a projekttel a régi és elavult raktározási programjuk kiváltása. A dolgozók elérhetik a főraktár készleteit és akár egyidőben is módosíthatják azt egy REST API alkalmazás segítségével. Nem tervezünk több platformon való megjelenést, mivel nem tartjuk szükségesnek egyéb eszközön (tab, telefon) ennek a programnak az elérésrét, mert a cég csupán PC-ket biztosít a rendeléshez.

## Jelenlegi helyzet

## Követelménylista
|MODUL|ID|NÉV|V.|LEÍRÁS|
|---|---|---|---|---|
|Adatbázis|K1|Adatbázis|1.0|A program újraindítása során az adatok nem vesznek el.|
|Szerver|K2|CRUD|1.0|CRUD műveletek megvalósítása a szerver részéről.|
|Szerver|K3|SWAGGER|1.0|Interaktív dokumentáció.|
|Kliens|K4|C# kliens kialakítása|1.0|A program felületének megtervezése UX szempontból. |
|Kliens|K5|C# kliens megvalósítása|1.0|A program felületének megvalósítása. |
|Jogosultság|K6|Jogosultság rendszer|1.0|Jogosultság rendszer a CRUD műveletekhez (Kivéve a lekérdezés).|

## Jelenlegi üzleti folyamatok modellje
Jelenleg egy elavult szoftver van használatban, mely lassú. Felülete bonyolult és nehezen betanítható a használata nem csak az idősebb, de még a fiatalabb kollégáknak is. Fenntartása ár-érték arányban nem éri meg többé a cégnek.

## Igényelt üzleti folyamatok modellje
Manapság a raktározás nem kellene, hogy lassú folyamat legyen. Egy valós időben változásokat kötni tudó rendszer a cél, melynek használata könnyen betanulható. Gyors és innovatív megoldást szeretnénk, mely megkönnyíti, mind dolgozóink, mind a vezetőség munkáját.

## Használati esetek
ADMIN: A program használatakor Ő képes módosítani illetve törölni az adatbázis tartalmát. Bejelentkezés szükséges és ezek után lesznek elérhetők ezek a funkciók.
FELHASZLÓ: A program használatakor lekérdezni képes. Az összes termék vagy pedig az id alapján tud listázni, így megtekinteni, mi van aktuálisan a raktárban.

## Forgatókönyv

## Fogalomszótár
