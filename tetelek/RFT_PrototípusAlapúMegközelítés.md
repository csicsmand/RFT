# Prototípus alapú megközelítés

A fejlesztés azon alapszik, hogy a megrendelő üzleti folyamatai, követelményei nem ismerhetők meg teljesen. Már csak azért sem, mert ezek az idővel változnak (lásd az agilis módszertanokat). A követelményeket érdemes finomítani prototípusok segítségével. Ha a felhasználó használatba vesz egy prototípust, akkor képes megfogalmazni, hogy az miért nem felel meg az elvárásainak és hogyan kellene megváltoztatni. Ebben a megközelítésben a leszállított rendszer is egy prototípus.\
Ez a megközelítés annyira sikeres volt, hogy a modern módszertanok majd mindegyike prototípus alapú. Az iteratív módszerek általában minden mérföldkőhöz kötnek egy prototípust. Az agilis módszertanok akár minden nap új (lásd napi fordítás) prototípust állítanak elő.\
A prototípuskészítést akkor a legcélszerűbb használni, ha a rendszer és a felhasználó között sok lesz a párbeszéd. A modell on-line rendszerek elemzésében és tervezésében nagyon hatékony, különösen a tranzakció feldolgozásnál. Olyan rendszereknél, ahol kevés interakció zajlik a rendszer és a felhasználó között, ott kevésbé éri meg a prototípus modell használata, ilyenek például a számítás igényes feladatok. Különösen jól használható a felhasználói felület kialakításánál.\
**Előnyei** 
- *Minőségnövelés:* A prototípus modell képes visszaszorítani a követelményspecifikációban lévő félreértések számát. 

- *Költségcsökkenés:* A prototípus modell segít minél hamarabb kideríteni, hogy a megrendelő valójában mit is akar, és így csökkenti a költségeket, mert minél később derül fény egy félreértésre, annál többe kerülnek a változtatások. 

- *Erősíti a felhasználó bevonását a fejlesztésbe:* A prototípus modellnél szükség van a felhasználók bevonására a fejlesztésbe. A prototípusok elemzésével már a fejlesztés közben jelzéseket tudnak adnia a fejlesztők felé. Ezáltal kiderülhetnek az esetleges félreértések a fejlesztők és a megrendelő között, ugyanis a végfelhasználók tudják a legjobban, hogy mit is kellene csinálnia szoftvernek. Így végül a termék magasabb minőségi szintet érhet el a fejlesztés végére, és valószínűleg jobban kielégíti a felhasználók igényeit is mindenféle tekintetben

**Hátrányai** 
- *Probléma az elemzés miatt:* Ha a fejlesztők csak a prototípusra figyelnek, az elterelheti a figyelmüket a rendszer részletes analíziséről. Ezáltal lehet, hogy nem találják meg a legjobb megoldásokat és így a végső termék: 
    - teljesítménye gyenge lesz, 
    - nehezen lesz karbantartható, 
    - nehezen lesz skálázható

    *Megjegyzés: Ezek a veszélyek csökkennek, ha már az első prototípusban egy rugalmas architektúrát alkalmazunk. Ennek ellentmond, hogy az architektúrát a nemfunkcionális követelmények alapján kell kialakítani, amiket lehet, hogy még nem ismerünk az első prototípus elkészülténél. Erre megoldás lehet keretrendszerek alkalmazása, mint pl. a Spring keretrendszer vagy az ASP.NET MVC csomagja.*

- *A prototípus és a befejezett rendszer összekeveredése a felhasználók fejében:* A felhasználók egy prototípus tesztelésekor azt hihetik, hogy ennek már közel úgy kéne működnie, mint a végleges rendszernek, és ezért rossz visszajelzéseket adhatnak a fejlesztőknek.

- *A fejlesztők ragaszkodása a prototípushoz:* Előfordulhat, hogy miután a fejlesztők sok energiát fektettek egy prototípus elkészítésébe túlságosan is ragaszkodnak hozzá, és abból akarnak egy végső kiadást készíteni. Még akkor is, ha nem is megfelelő a prototípus architektúrája. Ilyen szempontból jobb az eldobható prototípus alkalmazása az evolúcióssal szemben.


**A kezdeti prototípus fejlesztése általában a következő lépésekből áll:**
- *1. Az alap követelmények meghatározása:* Olyan alap követelmények meghatározása, mint a bemeneti és kimeneti adatok. Általában a teljesítményre vagy a biztonságra vonatkozó követelményekkel nem foglalkozunk. 

- *2. Kezdeti prototípus kifejlesztése:* Csak a felhasználói felületeket fejlesztjük le egy erre alkalmas CASE eszközzel. A mögötte lévő funkciókat nem, kivéve az új ablakok nyitását. 

- *3. Bemutatás:* A végfelhasználók megvizsgálják a prototípust, és jelzik, hogy mit gondolnak másként, illetve mit tennének még hozzá. 

- *4. A követelmények pontosítása:* A visszajelzéseket felhasználva pontosítjuk a követelményspecifikációt. Ha még mindig nem elég pontos a specifikáció, akkor a prototípust továbbfejlesztjük és ugrunk a 3. lépésre. Ha elég pontos képet kaptunk arról, hogy mit is akar a megrendelő, akkor az egyes módszertanok mást és mást írnak elő.

**Tehát a prototípus modell:** 
- általában iteratív, 
- általában nem strukturált 
- prototípus alapú, 
- gyakran rapid, agilis, esetleg extrém, 
- általában könnyűsúlyú, és 
- követelmény központú

## Fő változatai
**Eldobható prototípus (Throwaway prototyping):** Az elnevezés arra utal, hogy az elkészült modellt úgymond eldobják az elemzés után, vagyis nem lesz része a végső kiadásnak. Arra használjuk ezt a prototípust, hogy a követelményeket minél gyorsabban, minél jobban fel tudjuk mérni, így a felhasználók is láthatják, hogy mire számíthatnak. Miután ez megtörtént, a prototípus eldobható, és a rendszer a prototípussal felderített követelményekre fog épülni. Ennek a változatnak a legnagyobb előnye, hogy a felhasználók gyorsan kipróbálhatják az első modellt, így újragondolhatják az előzetesen megadott követelményeket. Ezzel nagyon sok költséget és munkát meg lehet takarítani, mert rögtön az életciklus elején kiderülhet, hogy valamit máshogyan kellene csinálni. Ugyanakkor a gyors fejlesztés miatt nem szabad csodákat várni az eldobandó példánytól. A másik előnye, hogy a felhasználói felületet is hamar kialakíthatjuk, és azzal együtt tesztelhetik. Ki kell hangsúlyozni, hogy ennek a változatnak csak akkor van értelme, ha az eldobható prototípus az életciklus elején gyorsan elkészül. A lényeg a gyorsaságon van. Ennek legszebb példája az extrém programozás.

**Evolúciós prototípus (Evolutionary prototyping):** Az evolúciós prototípuskészítés jóval másabb, mint az előző változat. Itt már a fejlesztés elején egy nagyon robosztus prototípust kell kidolgozni, ami a lelke lesz a rendszernek, és a későbbiekben már csak finomítani kell rajta. Ugyanakkor itt is meg van a lehetősége a fejlesztőnek, hogy változtassa a beépített funkciókat. Az eldobható prototípussal szemben van egy előnye, mégpedig, hogy itt már az elején egy működő rendszert kap a megrendelő elemzésre, még ha az összes követelmény nincs is beépítve a szoftverbe. Még az is előfordulhat, hogy a felhasználó már az egyik prototípust elkezdi használni a gyakorlatban, mert még az is jobb, mint a semmi. Ennél a változatnál a fejlesztőknek nem kell az egész rendszert egyben fejleszteni. Megtehetik, hogy a rendszernek csak bizonyos részeire koncentrálnak. A kockázatok minimalizálása miatt a fejlesztők csak azt a részét fejlesztik a rendszernek, amit már tökéletesen megértettek, aztán a prototípust elküldik a megrendelőnek, aki dolgozik vele, és visszajelzések ad. Ha további követelmények tisztulnak le, akkor halad tovább a fejlesztés ezek megvalósításával. 
