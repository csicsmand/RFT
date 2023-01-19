# Követelmény specifikáció

## Áttekintés
A következőkben egy olyan rendszer fejlesztésén fogunk dolgozni, mely az ASD Kft. munkáját könnyíti meg. Célunk ezzel a projekttel a régi és elavult raktározási programjuk kiváltása. A dolgozók elérhetik a főraktár készleteit és akár egyidőben is módosíthatják azt egy REST API alkalmazás segítségével. Nem tervezünk több platformon való megjelenést, mivel nem tartjuk szükségesnek egyéb eszközön (tab, telefon) ennek a programnak az elérésrét, mert a cég csupán PC-ket biztosít a rendeléshez.

## Jelenlegi helyzet
Az ASD Kft. szeretné könyebbé és átláthatóbbá tenni dolgozói számára a főraktár készleteinek lekérdezését, rendelés esetén pedig módosítását. A jelenlegi szofverük elavult és lassú, időt szeretnének megspórolni. 

## Vágyálom rendszer
Mindenképp egy olyan program megvalósítása a cél, mely megkönnyíti a dolgozók munkáját. Gyors és könnyű elérést biztosít a raktárban lévő termékek adataihoz. Ezek az adatokat egyidőben is módosíthatják azt egy REST API alkalmazás segítségével.

## Funkcionális követelmények
Ideális esetben az ASD Kft. dolgozói képesek valós időben nyomon követni a raktár tartalmát. Adminisztrátori joggal akár módosítás és törlés is eszközölhető.  
ADMIN: A program használatakor Ő képes módosítani illetve törölni az adatbázis tartalmát. Bejelentkezés szükséges és ezek után lesznek elérhetők ezek a funkciók.  
FELHASZNÁLÓ: A program használatakor lekérdezni képes. Az összes termék vagy pedig az id alapján tud listázni, így megtekinteni, mi van aktuálisan a raktárban.

## Rendszerre vonatkozó törvények, szabványok, ajánlások
A rendszer felhasználói adatokat tárol, amit az Európai Unió területén a GDPR (General Data Protection Regulation) nevű rendelet szabályozza. E rendelt alapján az érintett felhasználók jogai a következők:

- Átlátható tájékoztatáshoz való jog
- Hozzáféréshez való jog
- Helyesbítéshez való jog
- Törléshez és elfeledtetéshez való jog
- Korlátozáshoz való jog
- Adathordozhatósághoz való jog
- Tiltakozáshoz való jog
- Automatikus döntéshozatal elutasításához való jog

Adatkezelési nyilatkozat:

Az Adatkezelési ‌Nyilatkozat kialakítása során figyelembe vettük a vonatkozó hatályos jogszabályokat, illetve a fontosabb nemzetközi ajánlásokat. Ezekre megfelel az alábbi jogszabályoknak: Információs önrendelkezési jogról és az információszabadságról szóló 2011. évi CXII. törvény; Az elektronikus ‌hírközlésről szóló 2003. évi C. törvény; Az elektronikus kereskedelemről szóló 2001. évi CVIII. törvény előírásainak; Az "Online Privacy Alliance" ajánlásainak.

## Jelenlegi üzleti folyamatok modellje
Jelenleg egy elavult szoftver van használatban, mely lassú. Felülete bonyolult és nehezen betanítható a használata nem csak az idősebb, de még a fiatalabb kollégáknak is. Fenntartása ár-érték arányban nem éri meg többé a cégnek.

## Igényelt üzleti folyamatok modellje
Manapság a raktározás nem kellene, hogy lassú folyamat legyen. Egy valós időben változásokat kötni tudó rendszer a cél, melynek használata könnyen betanulható. Gyors és innovatív megoldást szeretnénk, mely megkönnyíti, mind dolgozóink, mind a vezetőség munkáját.

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
PC: personal computer (személyi számítógép)
CRUD: CREATE, READ, UPDATE és DELETE műveletek összefogó neve
UX: User Experience
