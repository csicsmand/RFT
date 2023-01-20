# Rendszerterv

## A rendszer célja
A következőkben egy olyan rendszer fejlesztésén fogunk dolgozni, mely az ASD Kft. munkáját könnyíti meg. Célunk ezzel a projekttel a régi és elavult raktározási programjuk kiváltása. A dolgozók elérhetik a főraktár készleteit és akár egyidőben is módosíthatják azt egy REST API alkalmazás segítségével.  
Nem tervezünk több platformon való megjelenést, mivel nem tartjuk szükségesnek egyéb eszközön (tab, telefon) ennek a programnak az elérésrét, mert a cég csupán PC-ket biztosít a dolgozói munkavégzéséhez.
Az ASD Kft. szeretné könyebbé és átláthatóbbá tenni dolgozói számára a főraktár készleteinek megtekintését és annak módosítását. A jelenlegi szofverük elavult és lassú, időt szeretnének megspólni.

## Projektterv
SZEREPKÖRÖK

SZERVER:
- Boros Balázs
- Budai Vera
- Csicsman Dominika
- Gasparovics Adrienn 

KLIENS: 
- Boros Balázs
- Budai Vera
- Csicsman Dominika
- Gasparovics Adrienn 

## Üzleti folyamatok modellje
Egy valós időben változásokat követni tudó rendszer a cél, melynek használata könnyen betanulható. Gyors és innovatív megoldást szeretnének, mely megkönnyíti, mind dolgozóink, mind a vezetőség munkáját.\
Ideális esetben az ASD Kft. dolgozói képesek valós időben nyomon követni a raktár tartalmát. Adminisztrátori joggal akár módosítás és törlés illetve létrehozást is eszközölni.\
A cég számára legfontosabb az igényelt folyamatok közül, az a hosszú távú támogatás és karbantartás.

![Használati esetek](img/hasznalatiEset.png "Csicsman Dominika")

ADMIN: A program használatakor Ő képes módosítani illetve törölni az adatbázis tartalmát. Bejelentkezés szükséges és ezek után lesznek elérhetők ezek a funkciók.

FELHASZLÓ: A program használatakor lekérdezni képes. Az összes termék vagy pedig az id alapján tud listázni, így megtekinteni, mi van aktuálisan a raktárban.  

**FELHASZNÁLÓ**  
1.: A "START" gomb lenyomásável kilistázza a raktár aktuális tartalmát

2.: A "Bejelentkezés" gombra kattintva megnyílik a bejelentkezőfelületünk, ahová a megfelelő felhasználónév és jelszó megadásával elérhetővé válnak az admin funkciók, mint az új tétel felvétele ("ADD"), tételk(ek) törlése, illetve a meglévő tétel adatainak módosítása ("UPDATE").

3.: *Képernyő törlése:* Ezt a funkciót az admin, illetve a userek is használhatják. Akkor használjuk, ha már sok mindent csináltunk és átláthatatlan a munkafelületünk. Ekkor a "CLEAR" gombra kattintva minden eddigi kiírás eltűnik, de a tételek természetesen az adatbázisban maradnak, hiszen törölni csak az admin tud. 
Tétel törlése: Csak az admin használhatja ezt a funkciót. A tétel ID-ja megadása után a tétel törlésre fog kerülni az adatbázisból. Erre akkor lehet szükség, ha már egy adott terméket nem forgalmaz tovább a cég.  


**ADMIN**  
1.:*Tétel adatainak módosítása:* Ha az admin elrontott valamilyen adatot a felvételkor, szerencsére nincs szükség arra, hogy kitörölje a tételt és újra felvegye, elég csak frissíteni az adatokat. Ez a funkció abban az esetben is használható, ha például változott a tétel ára, vagy már más mennyiség érhető el a raktában belőle. Ekkor az ID mezőbe beírjuk a tétel azonosítóját, a megváltoztatni kívánt adat mezőjébe pedig a már frissített adatot írjuk be, a többi tulajdonságot változatlanul hagyjuk. Az "UPDATE" gombra kattintva frissítésre kerülnek az adatok.

2.:*Lekérdezés lefuttatása:* Erre akkor lehet szükség, ha valamilyen információt szeretnénk megtudni az adott tételről (általában ez az ár, vagy az elérhető mennyiség). Ezt a funkciót az admin, illetve a userek is használhatják. Az ablak bal felső részében egy legördülő listából választhatjuk ki, hogy ID szerint szeretnénk valamit konkrétan lekérdezni, vagy az összes tételt szeretnénk kilistázni. A kért adat megadása után a "START" gombra kattintva megkapjuk a kért információt.


## Követelmények
|MODUL|ID|NÉV|V.|LEÍRÁS|
|---|---|---|---|---|
|Adatbázis|K1|Adatbázis|1.0|A program újraindítása során az adatok nem vesznek el.|
|Szerver|K2|CRUD|1.0|CRUD műveletek megvalósítása a szerver részéről.|
|Szerver|K3|SWAGGER|1.0|Interaktív dokumentáció.|
|Kliens|K4|C# kliens kialakítása|1.0|A program felületének megtervezése UX szempontból. |
|Kliens|K5|C# kliens megvalósítása|1.0|A program felületének megvalósítása. |
|Jogosultság|K6|Jogosultság rendszer|1.0|Jogosultság rendszer a CRUD műveletekhez (Kivéve a lekérdezés).|

## Funkcionális terv
A rendszerben 2 szerepkört tudunk megkülönböztetni. Admint és Usert.
User:
- Nem igényel bejelentkezést.
- Le tudja kérdezni az adatokat.

Admin:
- Igényel bejelentkezést.
- Le tudja kérdezni az adatokat, módosítani és törölni.

## Fizikai környezet
|Név|Típus|
|---|---|
|Visual Studio Code|fejlesztőkörnyezet|
|Visual Studio|fejlesztőkörnyezet|
|PHPMyAdmin|adatbázis kliens|
|Swagger|API dokumentáció|
|Node JS|javasript szerver|
  
  
## Implementációs terv  
A szerver Node JS segítségével készül, mellyel aránylag gyorsan lehet fejleszteni. A szerverhez interaktív api dokumentáció is készül Swagger segítségével.  
  
A kliens egy C# kliens lesz, melynek a Form részével gyorsan és könnyen alakítható ki a REST API-nk kinézete. Ez fogja felhasználni a szerveren futó Rest szolgáltatás metódusait.
  

## Architekturális terv

## Tesztterv
A projekt elkészítése során folyamatos tesztelésre van szükség, melynek célja a rendszer és komponensei funkcionalitásának teljes vizsgálata, ellenőrzése. Tesztelni kell a back-end részt, az adminisztrátori funkciók működését. Tesztelni kell a dizájn minden elemét. Tesztelni kell az adatbázis megfelelő működését, értjük ez alatt az adatok helyes tárolását stb.

Alfa teszt: Meglévő funkcióknak a klienssel. A tesztet a fejlesztők végzik.

Béta teszt: Ezt a tesztet nem a fejlesztők végzik. A kliens funkciói. 


## Telepítési terv
Szerver: Node Js, Apache és PHPMyadmin.
Kliens: Különösebb telepítést nem igényel.

## Karbantartási terv
Az alkalmazás üzelmetétese és karbantartása magába foglalja a programhibák elhárítását. Az alkalmazás bővítési lehetőségét fenntartjuk. Belső illetve egyéb igények, környezeti feltételek változása esetén kiterjed a program- és állomány modosításra is. 
