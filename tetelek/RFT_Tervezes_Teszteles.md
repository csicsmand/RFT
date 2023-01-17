# Tervezés, implementáció, tesztelés iterációk

A logikai és fizikai rendszertervek nagyvonalú vagy részletes rendszertervek, amelyek leírják a magvalósításának részleteit. A logikai rendszerterv az ideális rendszer terve, amely nem veszi figyelembe a fizikai megszorításokat, csak sajátjait. Például fizikai, hogy mekkora tárterület áll rendelkezésre, logai pedig, hogy az ár nem lehet negatív szám.

A fizikai rendszerterv a logikai rendszerterv finomítása. Ennek során figyelembe vesszük a fizikai megszorításokat. Gyakran úgy tűnik, hogy a logikai és a fizikai modell nagyon távol áll egymástól, mert ha a logikai vázolt megoldás például túl lassú lenne, akkor a fizikaiban egy teljesen másik megoldást kell leírni. Ugyanakkor ez is csak finomítás, hiszen a két megoldás ugyanarra a kérdésre ad választ.

A rendszerterv általában UML ábrákból és szöveges részekből áll. Az UML ábrák önmagukban nem egyértelműek, ezért kell magyarázattal is ellátni őket.

A rendszerterv alapja a funkcionális specifikáció. Míg a funkcionális specifikáció a felhasználó szemszögéből írja le a rendszert, addig a rendszerterv a programozók, illetve üzemeltetők szemszögéből.

**Egy rendszerterv általában az alábbi fejezetekből és alfejezetekből áll:** 
- A rendszer célja 
  - Projekt terv 
  - Projektszerepkörök, felelősségek 
  - Projektmunkások és felelősségeik
  - Ütemterv 
  - Mérföldkövek 

- Üzleti folyamatok modellje 
  - Üzleti szereplők 
  - Üzleti folyamatok 
  - Üzleti entitások

- Követelmények
  - Funkcionális követelmények 
  - Nem funkcionális követelmények 
  - Törvényi előírások, szabványok

- Funkcionális terv 
  - Rendszerszereplők 
  - Rendszerhasználati esetek és lefutásaik 
  - Határosztályok 
  - Menü-hierarchiák 
  - Képernyőtervek 

- Fizikai környezet 
  - Vásárolt softwarekomponensek és külső rendszerek 
  - Hardver és hálózati topológia 
  - Fizikai alrendszerek 
  - Fejlesztő eszközök 
  - Keretrendszer (pl. Spring) 

- Absztrakt domain modell o Domain specifikáció, fogalmak 
  - Absztrakt komponensek, ezek kapcsolatai 

- Architekturális terv 
  - Egy architekturális tervezési minta (pl. MVC, 3-rétegű alkalmazás, …) 
  - Az alkalmazás rétegei, fő komponensei, ezek kapcsolatai o Változások kezelése 
  - Rendszer bővíthetősége o Biztonsági funkciók 

- Adatbázis terv 
  - Logikai adatmodell 
  - Tárolt eljárások
  - Fizikai adatmodellt legeneráló SQL szkript

- Implementációs terv 
  - Perzisztencia-osztályok 
  - Üzleti logika osztályai 
  - Kliensoldal osztályai

- Tesztterv 
- Telepítési terv 
- Karbantartási terv

**Az implementáció** során valósítjuk meg az előző fázisokban megtervezett rendszert. Az újabb módszertanok szerint a kódolást előbbre kell hozni, prototípusokat kell fejleszteni. Akár így, akár úgy, de itt már a programozóké a főszerep. Szerencsés esetben rendelkezésükre áll egy részletes rendszerterv, ami metódusszintig specifikálja a feladatot. Kevésbé szerencsés esetben csak képernyőtervek és az elkészítendő funkciók leírása adott.\
A feladattól függően más-más nyelven érdemes implementálni a feladatot. Jó választás lehet a Java, ami platform független, illetve a .NET Windows platform esetén. Mindkét nyelv kiválóan támogatott, rengeteg rendszeralkönyvtár áll szolgálatunkra. Ezen túl, mindkét nyelv általános célú. Ha nagyon jól meghatározott területre kell fejlesztenünk, például egy szakértői rendszert, akkor érdemes nem általános célú nyelvet, hanem egy speciális nyelvet (DSL – Domain Specific Language) használni a fejlesztéshez.\
Implementáció során felfedezhetjük, hogy a specifikáció nem megvalósítható, vagy ellentmondásos. Ekkor egy előző fázisra kell visszalépnünk és módosítani a specifikációt.\
Törekedni kell arra, hogy az elkészülő osztályok, modulok újra felhasználhatóak legyenek. A már meglévő modulokat érdemes újra felhasználni. Érdemes külső komponenseket is felhasználni, de ekkor időt vesz igénybe a komponens API-jának megtanulása. 
Az implementáció során törekednünk kell arra, hogy könnyen újrafelhasználható és rugalmas kódot írjunk. Erről nagy részletességgel írunk a programozás technológia fejezetben. Itt jön létre a forráskód és dokumentáció, mint termék.

Tesztelésre azért van szükség, hogy a szoftvertermékben meglévő hibákat még az üzembehelyezés előtt megtaláljuk, ezzel növeljük a termék minőségét, megbízhatóságát. Abban szinte biztosak lehetünk, hogy a szoftverben van hiba, hiszen azt emberek fejlesztik, és az emberek hibáznak. Gondoljunk arra, hogy a legegyszerűbb programban, mondjuk egy szöveges menükezelésben, mennyi hibát kellett kijavítani, mielőtt működőképes lett. Tehát abban szinte biztosak lehetünk, hogy tesztelés előtt van hiba, abban viszont nem lehetünk biztosak, hogy tesztelés után nem marad hiba. A tesztelés után azt tudjuk elmondani, hogy a letesztelt részekben nincs hiba, így nő a program megbízhatósága. Ez azt is mutatja, hogy a program azon funkcióit kell tesztelni, amiket a felhasználók legtöbbször fognak használni.

**A fenti megállapításokat a következő elvekben, a tesztelés alapelveiben, foglalhatjuk össze:**
- *1. A tesztelés hibák jelenlétét jelzi:* A tesztelés képes felfedni a hibákat, de azt nem, hogy nincs hiba. Ugyanakkor a szoftver minőségét és megbízhatóságát növeli.

- *2. Nem lehetséges kimerítő teszt:* Minden bemeneti kombinációt nem lehet letesztelni (csak egy 10 hosszú karakterláncnak 256^10 lehetséges értéke van) és nem is érdemes. Általában csak a magas kockázatú és magas prioritású részeket teszteljük.

- *3. Korai teszt:* Érdemes a tesztelést az életciklus minél korábbi szakaszában elkezdeni, mert minél hamarabb találunk meg egy hibát (mondjuk a specifikációban), annál olcsóbb javítani. Ez azt is jelenti, hogy nemcsak programot, hanem dokumentumokat is lehet tesztelni.

- *4. Hibák csoportosulása:* A tesztelésre csak véges időnk van, ezért a tesztelést azokra a modulokra kell koncentrálni, ahol a hibák a legvalószínűbbek, illetve azokra a bementekre kell tesztelnünk, amelyre valószínűleg hibás a szoftver (pl. szélsőértékek).

- *5. A féregirtó paradoxon:* Ha az újra tesztelés során (lásd később a regressziós tesztet) mindig ugyanazokat a teszteseteket futtatjuk, akkor egy idő után ezek már nem találnak több hibát (mintha a férgek alkalmazkodnának a teszthez). Ezért a tesztjeinket néha bővíteni kell.

- *6. A tesztelés függ a körülményektől:* Másképp tesztelünk egy atomerőműnek szánt programot és egy beadandót. Másképp tesztelünk, ha a tesztre 10 napunk vagy csak egy éjszakánk van.

- *7. A hibátlan rendszer téveszméje:* Hiába javítjuk ki a hibákat a szoftverben, azzal nem lesz elégedett a megrendelő, ha az nem felel meg az igényeinek. Azaz használhatatlan szoftvert nem érdemes tesztelni.




