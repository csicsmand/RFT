# Követelmény specifikáció

## Áttekintés
A következőkben egy olyan rendszer fejlesztésén fogunk dolgozni, mely az ASD Kft. munkáját könnyíti meg. Célunk ezzel a projekttel a régi és elavult raktározási programjuk kiváltása. A dolgozók elérhetik a főraktár készleteit és akár egyidőben is módosíthatják azt egy REST API alkalmazás segítségével. Nem tervezünk több platformon való megjelenést, mivel nem tartjuk szükségesnek egyéb eszközön (tab, telefon) ennek a programnak az elérésrét, mert a cég csupán PC-ket biztosít a rendeléshez

## Jelenlegi helyzet
Az ASD Kft. szeretné könyebbé és átláthatóbbá tenni dolgozói számára a főraktár készleteinek lekérdezését, rendelés esetén pedig módosítását. A jelenlegi szofverük elavult és lassú, időt szeretnének megspólni. 

## Vágyálom rendszer
Mindenképp egy olyan program megvalósítása a cél, mely megkönnyíti a dolgozók munkáját. Gyors és könnyű elérést biztosít a raktárban lévő termékek adataihoz. Ezek az adatokat egyidőben is módosíthatják azt egy REST API alkalmazás segítségével.

## Funkcionális követelmények

## Rendszerre vonatkozó törvények, szabványok, ajánlások

## Jelenlegi üzleti folyamatok modellje

## Igényelt üzleti folyamatok modellje

## Követelménylista
|MODUL|ID|NÉV|V.|LEÍRÁS|
|---|---|---|---|---|
|Adatbázis|K1|Adatbázis|1.0|A program újraindítása során az adatok nem vesznek el.|
|Szerver|K2|CRUD|1.0|CRUD műveletek megvalósítása a szerver részéről.|
|Szerver|K3|SWAGGER|1.0|Interaktív dokumentáció.|
|Kliens|K4|C# kliens kialakítása|1.0|A program felületének megtervezése UX szempontból. |
|Kliens|K5|C# kliens megvalósítása|1.0|A program felületének megvalósítása. |
|Jogosultság|K6|Jogosultság rendszer|1.0|Jogosultság rendszer a CRUD műveletekhez (Kivéve a lekérdezés).|

## Fogalomtár
