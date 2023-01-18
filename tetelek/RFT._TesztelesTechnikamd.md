# Tesztelési technikák, tesztelés szintjei

**A tesztelési technikákat csoportosítása rendelkezésre álló információ alapján:**
- Feketedobozos (black-box) vagy specifikáció alapú, amikor a specifikáció alapján készülnek a tesztesetek.

- Fehérdobozos (white-box) vagy strukturális teszt, amikor a forráskód alapján készülnek a tesztesetek.

- Szürkedobozos (grey-box), amikor a forráskódnak csak egy része ismert és ez alapján készülnek a tesztesetek.

## Fekete-, fehér- és szürkedobozos tesztek

**Feketedobozos tesztelés:** A tesztelő nem látja a forráskódot, de a specifikációkat igen. A teszt futtatásához szükség van a lefordított szoftverre. Leggyakoribb formája, hogy egy adott bemenetre tudjuk, milyen kimenetet kellene adni a programnak. Lefuttatjuk a programot a bemenetre és összehasonlítjuk a kapott kimenetet az elvárttal. Ezt alkalmazzák pl. az ACM (ICPC) versenyeken is. 

**Fehérdobozos tesztelés:** A forráskód rendelkezésre áll. Mindig egy már kész struktúrát tesztelünk. A strukturális teszt esetén értelmezhető a (struktúra) lefedettség. Ez azt mutatja meg, hogy a struktúra hány százalékát tudjuk tesztelni a meglévő tesztesetekkel. (Például a unit teszt a metódisok sturtúra tesztje)\

*Ezeket szoktuk tesztelni:*
- kódsorok
- elágazások
- metódusok
- osztályok
- funkciók
- modulok

**Szürkedobozos tesztelés:** Általában néhány interfész, áll rendelkezésre.

## A tesztelés szintjei:
- komponensteszt
- integrációs teszt
- rendszerteszt
- átvételi teszt

**Komponensteszt:** A a rendszer önálló részeit teszteli általában a forráskód ismeretében (fehérdobozos teszt). Gyakori fajtái a unit- és a modulteszt.

*Unit-teszt:* Más néven egységteszt, a metódusokat teszteli. Adott paraméterekre ismerjük a metódus visszatérési értékét, a teszt megvizsgálja, hogy a tényleges visszatérési érték megegyezik-e az elvárttal. Ha igen, sikeres a teszt, egyébként sikertelen. Minden fejlett programozási környezet (IDE) támogatja, azaz egyszerű ilyen teszteket írni. A jelentőségüket az adja, hogy a futtatásukat is támogatják, így egy változtatás után csak lefuttatjuk az összes unit-tesztet, ezzel biztosítjuk magunkat, hogy a változás nem okozott hibát (regressziós teszt). 

*Modulteszt:* Általában a modul nemfunkcionális tulajdonságát teszteli, pl. sebességét, vagy, hogy van-e memóriaszivárgás (memory leak), van-e szűk keresztmetszet (bottleneck).

**Integrációs teszt:** a komponensek közti interfészeket, az operációs rendszer és a rendszer közti interfészt, illetve más rendszerek felé nyújtott interfészeket tesztelik. Az összeillesztés során keletkező hibákat keresi. Mivel a részeket más-más programozók, csapatok fejlesztették, ezért az elégtelen kommunikációból súlyos hibák keletkezhetnek. Ezeket a teszteket érdemes előre hozni, amennyire lehet, mert minél nagyobb az integráció mértéke, annál nehezebb meghatározni, hogy a fellelt hiba (általában egy futási hiba) honnan származik.\
Típusai a komponens integrációs teszt és a rendszer integrációs teszt.

*Komponens integrációs teszt:* A komponensek közötti kölcsönhatások tesztje a komponensteszt után.

*Rendszer integrációs teszt:* A rendszer és más rendszerek közötti kölcsönhatásokat tesztje a rendszerteszt után.

**Rendszerteszt:** A már kész szoftverterméket teszteli, hogy megfelel-e a követelményspecifikációnak, a funkcionális specifikációnak, a rendszertervnek. Gyakran feketedobozos teszt, amit sok esetben nem is a fejlesztő cég, ahol esetleg elfogultak a tesztelők, hanem egy független cég végzi. Ilyenkor a tesztelők és a fejlesztők közti kapcsolat tartást egy hibabejelentő (bug tracking) rendszer látja el. Fontos, hogy a rendszerteszthez használt környezet a lehető legjobban hasonlítson a megrendelő környezetére, hogy a környezet-specifikus hibákat is sikerüljön felderíteni.

**Átváteli teszt:** Hasonlóan a rendszerteszthez az egész rendszert teszteli, de ezt már a végfelhasználók végzik. Fajtái az alfa-, a béta, a felhasználói- és üzemeltetői teszt.

*Alfa teszt:* A késztermék tesztje a fejlesztő cégnél, de nem a fejlesztő csapat által. Ennek része, amikor egy kis segédprogram több millió véletlen egérkattintással ellenőrzi, hogy össze-vissza kattintgatva sem lehet kifektetni a programot. 

*Béta teszt:* A végfelhasználók egy szűk csoportja végzi. Játékoknál gyakori, hogy a kiadás előtt néhány játékosnak elküldik a játékot, akik rövid idő alatt sokat játszanak vele. Cserébe csak azt kérik, hogy a felfedezett hibákat jelentsék.

*Felhasználói átvételi teszt:* Ekkor már az összes, vagy majdnem az összes felhasználó, megkapja a szoftvert és az éles környezetben használatba veszi. Azaz installálják és használják, de még nem a termelésben. Ennek a tesztnek a célja, hogy a felhasználók meggyőződjenek, hogy a termék biztonságosan használható lesz. Itt már elvárt, hogy a fő funkciók mind működjenek, de előfordulhat, hogy az éles színhelyen előjön olyan környezet függő hiba, ami a teszt környezetben nem. Lehet ez például egy funkció lassúsága.

*Üzemeltetői átvételi teszt:* a rendszergazdák ellenőrzik, hogy a biztonsági funkciók, pl. a biztonsági mentés és a helyreállítás, helyesen működnek-e.