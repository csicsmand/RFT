# A szoftver, mint termék; a rendszerszervezés; szoftverkrízis

## A program (informatikai rendszer) 
A rendszerfejlesztés technológiájának alapelve: kimondja, hogy a program is csak egy termék. Hasonló jellemzőkkel bír, mint egy doboz müzli.

**Ezen tulajdonságok közül néhány fontosabb:**
- A programnak van ára, gyártója, forgalmazója, vevője. 
- A programnak van minősége, doboza, designja, dokumentációja.
- A programra vonatkoznak törvényi előírások, szabványok és ajánlások.

## A rendszerszervezés feladata
Ennek célja, hogy az implementálás előtt alaposan gondoljuk végig a rendszert, amit tervezünk. Erre azért van szükség, mert minél hamarabb derül ki egy tervezési hiba, annál olcsóbb azt javítani. Ez nehéz feladat, hiszen a mai napig **szoftverkrízisről** beszélhetünk.

A szoftverkrízisre adott egyik válasz a rendszerszervezés. A rendszerszervezés egy körfolyamatot ír le, a szoftver **életciklusát**. Ez alatt sok termék (szoftver, dokumentáció) keletkezik, amelyek elkészítésére a **módszertanok** tesznek ajánlást. A korai módszertanok nagy hangsúlyt fektettek arra, hogyan kell részletes, előretekintő **rendszertervet** írni. Ha egy fejlesztő nem értett valamit, akkor megnézte a azt. A mai módszertanok erre kevésbé figyelnek, inkább az iterációban és a fejlesztők közti kommunikációban bíznak. Ha egy fejlesztő nem ért valamit, megkérdezi a másik fejlesztőt. A módszertanok a programfejlesztés divatjai. Ma az **agilis-** , régebben az **iteratív-**, azt megelőzően a **strukturálisak módszertanok** voltak népszerűek. Valószínűsíthető, hogy a módszertanok területén is lesz egyfajta ciklikusság, a jövő módszertanai ismét hangsúlyt fektetnek majd a rendszertervre.

## Szoftverkrízis
A rendszerszervezés fő problémája az úgynevezett szoftverkrízis, mely alatt azt értjük,
hogy a szoftverprojektek jelentős része sikertelen. Ez egyidős a számítógépek elterjedésével.

**Sikertelen lehet a következő értelemben:**
 - a tervezettnél drágábban készül el (over budget),
 - a tervezetnél hosszabb idő alatt (over time), 
 - nem az igényeknek megfelelő,
 - nagyon rossz minőségű / rossz hatásfokú / nehezen karbantartható,
 - anyagi / környezeti / egészségügyi kárhoz vezet, 
 - átadásra sem kerül.

Mivel maga a hardver szoftver nélkül csak egy használhatatlan vas, ezért kezdetektől nagy az igény a felhasználóbarát, magas minőségű, olcsó szoftverek iránt. Sajnos ezt a szoftverfejlesztő ipar a mai napig képtelen kielégíteni. A 70-es évek 80-90%-os sikertelen projektarányához képest manapság ez jócskán 50% alatt van, de elmondható, hogy minden harmadik szoftverprojekt sikertelen. Szerencsére a sikertelen szoftverprojektek okai kevésbé súlyosak. Míg a hetvenes években a sikertelen projektek túlnyomó többsége átadásra sem került, addig manapság a sikertelenség oka inkább az idő vagy a pénzügyi keretek túllépése. Gyakori még, hogy a megrendelő nem az igényeinek teljesen megfelelő szoftvert kap, de ez inkább a két fél közti elégtelen kommunikációnak tudható be.

**A szoftverkrízis okai:**
- *Elégtelen hatékonyság:* A szoftvercégek nem elég hatékonyak, azaz adott idő alatt kevesebb jó minőségű kódot fejlesztenek, mint az elvárható lenne.

- *Művészlelkű programozók:* A programozók „programozóművészeknek” képzelik magukat, akik a programozást önmegvalósítási formának tekintik, amiért jól fizetnek.

- *Félreértés:* A szoftvercégek nem ismerik azt a szakterületet (domain), ahonnan a megrendelő jön és így nem értik a szaknyelvét.

- *Gyorsan változó környezet illetve igények:* Egy hosszú szoftverprojekt ideje alatt megváltozhat a megrendelő igénye. Ennek oka lehet például egy új jogszabály, azaz a program környezetének megváltozása.

- *A fejlesztési idő nehezen becsülhető:* A szoftverprojektek sikertelenségének legfőbb oka, hogy az előre kitűzött időpontra nem készül el a program. Ehhez hozzájárul, hogy rendkívül sok váratlan nehézségbe ütközhet egy programozó.

- *Kevéssé specifikált feladat:* Gyakori probléma, hogy a specifikáció egyetlen oldalas, sok követelményre csak a fejlesztés során derül fény.

**A szoftverkrízis megoldásai:**

*Rendszerszervezési válaszok*
- A rendszerszervezés válasza a módszertanok bevezetése. A módszertanok szigorúan vagy kevésbé szigorúan, de előírják a szoftverfejlesztés lépéseinek sorrendjét. Meghatározzák, mikor kell a megrendelőnek és a fejlesztőnek kommunikálnia, ezek alapján milyen dokumentumoknak kell létrejönniük. Minden lépés néhány dokumentumra épül és általában egy új dokumentum vagy programrészlet az eredménye. A lépések a szoftver életciklusának a lépései.

- A rendszerszervezés másik válasza a kockázatmenedzsment. A kockázatmenedzsment kimondja, hogy a kockázatokat fel kell mérni, azokat a valószínűségük és okozott idő és pénz veszteségük szerint osztályozni és a legsúlyosabb kockázatokra készülni kell. Ez általában redundáns erőforrások biztosításával lehetséges.

- A rendszerszervezés következő válasza a megrendelő és a fejlesztő kommunikációját segítő vizuális nyelvek bevezetése, ezek egységesítése. Az UML, és főleg a Use Case-ek elterjedése egy olyan jelölésrendszert biztosít, amelyet a megrendelő szakemberei és a programozók is könnyen megértenek. Ez segíti a félreértések elkerülését a két fél közt.

*Programozás-technológiai válaszok*
- A programozás-technológia első válasza, hogy a programozási nyelvek fejlődésével egy utasítás egyre több gépi kódú utasításnak felel meg. Ez az arány assembler nyelveknél egy az egyhez, azaz egy assembler memonic egy gépi kódú utasításnak felel meg. A második generációs strukturált nyelvek esetén egy utasítás néhány tucat gépi kódú utasítást vált ki (1:10). A harmadik generációs procedurális nyelveknél egy utasítás néhány száz gépi kódú utasításnak felelhet meg (1:100). A negyedik generációs OOP nyelvek esetén ez a szám néhány ezer is lehet (1:1000). Ezzel a módszerrel nő a programozók hatékonysága.

- A programozás-technológia második válasza a program modulokra bontása. Már az assembler nyelvek is megengedték, hogy a forráskódot több állományba tároljuk, ezek között szubrutinokat hívjunk. Minden állományt külön kellett fordítani (compile) tárgykódú programmá, ami már gépi kódú, de amiben a címzések még nem feloldottak. A tárgykódú programokat egy szerkesztő (linker) segítségével kellett futtatható programmá összeszerkeszteni. A modularitás a programozási nyelvek fejlődésével egyre nagyobb támogatást kapott. Megjelentek a függvények és az eljárások (együtt alprogramok), a modulok, a unit-ok (fordítási alegységek), végül az osztályok, amik az adattagokat és a rajtuk végzett metódusokat zárja egységbe. A modularitás nagy áldása az, hogy megengedi, hogy több programozó készítse a programot. Minden programozónak csak a saját modulját kell átlátnia, a többit nem. Ez azért fontos, mert egy programozó csak néhány ezer, esetleg tízezer kódsort lát át (az a modul maximális mérete). A modularitás megengedi, hogy ennél nagyobb programot is fejleszthessünk azáltal, hogy azt kisebb, átlátható modulokra bontjuk. A moduloknak természetesen kommunikálniuk kell.

- A programozás-technológia fő válasza a tervezési minták bevezetése. A tervezési minták egyegy gyakori problémára nyújtanak kiforrott, mégis általános megoldást. 

- A programozás-technológia legújabb válasza a terület (domain) specifikus keretrendszerek, programozási nyelvek megjelenése, illetve olyan technológiák, amelyekkel ezek könnyen elkészíthetők. A területspecifikus fejlesztés ígérete az, hogy egy konkrét területre specifikált nyelven a fejlesztés sokkal hatékonyabb. Gondoljunk például arra, milyen egyszerű CMS rendszerekkel web portált készíteni. A területspecifikus technológiák közül ezek a legismertebbek: 
    - Model Driven Architecture vagy Development,  
    - Domain-Specific Modeling.

*Szoftverfejlesztés technológi válaszok*

- A szoftverfejlesztés technológiájának első válasza a programozó munkájának segítése. Nagyon fontos lépés volt az editorok, debuggerek integrálása egy integrált fejlesztési környezetbe (integrated development environment, röviden IDE), ami többek közt szintaxiskiemeléssel (syntax highlight) segíti a programozó munkáját. Ide sorolható minden olyan szoftver, ami egy programozó saját munkáját segíti.

- A szoftverfejlesztés technológiájának második válasza a tesztelés segítése, automatizálása. Itt nagy szerepet kap a unit-tesztek elterjedése, ami lehetővé tette az agilis módszertanok elterjedését. Sok szoftver létezik, amely segíti a különböző tesztek elvégzését.

- A szoftverfejlesztés technológiájának további válasza (ami az előző általánosítása) a csoportmunkát segítő technológiák kifejlesztése. Láttuk, hogy a program modulokra bontható, a modulokat más-más programozó készítheti. A fejlesztőknek sokat kell kommunikálniuk, hiszen továbbra is egy szoftvert fejlesztenek, a modulok függnek egymástól, a moduloknak hívniuk kell egymást. Ide tartozik minden olyan szoftver, ami több programozó együttes munkáját segíti. A fő csapatmunkát segítő technológiák: 
    - Verziókövetés 
    - Hibakövetés 
    - Modellező eszközök 
    - Fordítás segítő „make” eszközök.

