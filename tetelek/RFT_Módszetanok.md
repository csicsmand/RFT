# Módszertanok

A módszertanok feladata, hogy meghatározzák, hogy a szoftver életciklus egyes lépései milyen sorrendben követik egymást, milyen dokumentumokat, szoftver termékeket kell előállítani és hogyan. Egy nagy szabálykönyvre emlékeztetnek, ami pontosan leírja, hogyan kell szoftvert előállítani.

A módszertanokat több szempontból is osztályozhatjuk. Az első szempont, hogy milyen sorrendben követik egymást az életciklus fázisai.
**Csoportosításuk:**
- lineáris
- spirális
- iteratív (inkrementális)

A második szempont, hogy milyen implementációs nyelvet részesít előnyben a módszertan.
**Csoportosításuk:**
- folyamat orientált
- adat központú
- strukturált
- objektum orientált
- esetleg ezek keveréke

A harmadik szempont, hogy milyen megközelítést használ a módszertan a célja eléréséhez. Mivel a cél a sikeres szoftverprojekt, ezért a megközelítés alatt általában egy olyan technikát értünk, ami a félreértések elkerülésére szolgál. Ugyanakkor a megközelítés alatt a programozásra tett ajánlást is érthetjük.
**Csoportosításuk:**
- jól dokumentált
- prototípus alapú
- rapid
- agilis
- extrém
- esetleg ezek keveréke

A negyedik szempont, hogy mennyire szigorúan követelik meg a jól dokumentáltságot. 
**Csoportosításuk:**
- könnyűsúlyú (lightweight) módszertan
- nehézsúlyú (heavyweight) módszertan

**Minden módszertan jellemzője:**
- Az elemzés és tervezés szétválasztása. 
- A logikai és fizikai tervezés szétválasztása.

## Stukturális módszetanok
A feladatot modulokra bontják, az implementációban is ajánlott a program modulokra bontása. Ezért a strukturált programozási nyelveket részesítik előnyben. Mivel az objektum orientált nyelvek is strukturáltak, ezért azokkal együtt is használhatók. Jellemzője, hogy az életciklus lépései merev sorrendben követik egymást, azaz **lineáris**. Ezek a módszertanok nagy, hosszú ideig tartó projektek megvalósítására valók. Közös jellemzőjük, hogy **nehézsúlyúak**, azaz sok és részletes dokumentációval próbálják meg elkerülni a félreértéseket. Az egyes dokumentumok elkészítéséhez általában **adat központú** vagy **folyamat központú** technikákat ajánl.

## Vízesés modell
Ez volt az első módszertan, ami széles körben elterjedt. Az egyik legismertebb strukturális módszertan. Nagy megrendelők nagy projektjeihez alakították ki. Mivel a nagy megrendelők általában rugalmatlanok, ezért előnyős, hogy a módszertan kevés döntési pontot definiál.\
A modell **lineáris**, azaz az életciklus lépései egymás után, átfedés nélkül következnek. A módszertan ipari termelésből ered, ahol nincs lehetőség a követelmények változtatására, ha már egyszer azokat meghatároztuk. Ezért a vízesés modell eredeti változata nem engedi, hogy visszatérjünk egy már lezárt fázisba. Ezt azért teheti meg, mert csak akkor léphetünk a következő fázisba, ha az előzőt már tökéletesen sikerült lezárni. A modell rengeteg dokumentum elkészültét írja elő. Mivel ezeket el kell fogadtatni a megrendelővel, ezzel véli biztosítani a módszertan, hogy nincs félreértés a megrendelő és a szoftvercég közt.

## V-modell
Nevét onnan kapta, hogy két szára van és így egy V betűhöz hasonlít. Az egyik szára **megegyezik a vízesés modellel**. Ez a fejlesztési szár. A másik szára a létrejövő termékek tesztjeit tartalmazza. Ez a tesztelési szár. Az egy szinten lévő fejlesztési és tesztelési lépések összetartoznak, azaz a tesztelési lépés a fejlesztési lépés során létrejött dokumentumokat használja, vagy a létrejött terméket teszteli.

## Prototípus modell
válasz a vízesés modell sikertelenségére. A fejlesztő cégek rájöttek, hogy tarthatatlan a vízesés modell megközelítése, hogy a rendszerrel a felhasználó csak a projekt végén találkozik. Gyakran csak ekkor derült ki, hogy az életciklus elején félreértették egymást a felek és nem a valós követelményeknek megfelelő rendszer született. Ezt elkerülendő a prototípus modell azt mondja, hogy a végső átadás előtt több prototípust is szállítsunk le, hogy mihamarabb kiderüljenek a félreértések, illetve a megrendelő lássa, mit várhat a rendszertől.

## Spirál modell
Barry Boehm 1988-ban publikálta. A spirál modellt a gyakorlatban csak elvétve használják, inkább az elvi jelentősége nagy. A modell a prototípus modell és a vízesés modell egyes tulajdonságait kombinálja. Nagy, bonyolult, drága rendszerekhez ajánlott. A jelentőségét az adja, hogy ez az első modell, amely egyfajta **iterációt** használ. Habár a prototípus modellben is van ciklus, de vagy csak a követelmények felderítésére szolgál, vagy az egész életciklus megismétlését jelenti.

## Rational Unified Process – RUP 
Ez egy iteratív szoftvertervezési módszertan. Megmutatja, hogy az egyes tervezési szakaszokban milyen feladatok vannak és ezeket a feladatokat milyen képzettségű embereknek kell kiosztani ahhoz, hogy a projektet sikeresen elemezzük, megtervezzük, implementáljuk és teszteljük. A módszertan célja az, hogy egy minőségi terméket tudjunk előállítani minél hamarabb, minél hatékonyabban és ellenőrizhető módon.

## Gyors alkalmazásfejlesztés – RAD
Ez egy olyan elgondolás, amelynek lényege a szoftver gyorsabb és jobb minőségű elkészítése. 
**Ezt a következő módon éretjük el:**
- Korai prototípuskészítés és ismétlődő felhasználói átvételi tesztek.
- A csapat - megrendelő és a csapaton belüli kommunikációban kevésbé formális. 
- Szigorú ütemterv, így az újítások mindig csak a termék következő verziójában jelennek meg.
- Követelmények összegyűjtése fókusz csoportok és munkaértekezletek használatával.
- Komponenesek újrahasznosítása.

## Agilis szoftverfejlesztés 
Az agilis szoftverfejlesztés valójában **iteratív** szoftverfejlesztési módszerek egy csoportjára utal, amelyet 2001-ben az Agile Manifesto nevű kiadványban öntöttek formába. Az agilis fejlesztési módszerek (nevezik adaptívnak is) egyik fontos jellemzője, hogy a résztvevők, amennyire lehetséges megpróbálnak alkalmazkodni a projekthez. Ezért fontos például, hogy a fejlesztők folyamatosan tanuljanak.

## Scrum
Ez egy **agilis** szoftverfejlesztési metódus. Jellegzetessége, hogy fogalmait a rugby nevű csapatjátékból meríti. Ilyen fogalom, maga a scrum is, amely dulakodást jelent. A módszertan jelentős szerepet tulajdonít a csoporton belüli összetartásnak. A csoporton belül sok a találkozó, a kommunikáció, lehetőség van a gondok megbeszélésre is. Az ajánlás szerint jó, ha a csapat egy helyen dolgozik és szóban kommunikál.

## Az extrém programozás 
Ez egy agilis módszertan. A nevében az extrém szó onnan jön, hogy az eddigi módszertanokból átveszi a jól bevált technikákat és azokat nem csak jól, hanem extrém jól alkalmazza, minden mást feleslegesnek tekint.
**Az extrém programozás 4 tevékenységet ír elő:**
- *Kódolás:* A forráskód a projekt legfontosabb terméke, ezért a kódolásra kell a hangsúlyt helyezni. Igazán kódolás közben jönnek ki a feladat nehézségei, hiába gondoltuk azt át előtte. A kód a legalkalmasabb a két programozó közötti kommunikációra, mivel azt nem lehet kétféleképpen érteni. A kód alkalmas a programozó gondolatainak kifejezésére.

- *Tesztelés:* Addig nem lehetünk benne biztosak, hogy egy funkció működik, amíg nem teszteltük. Az extrém felfogás szerint kevés tesztelés kevés hibát talál, extrém sok tesztelés megtalálja mind. A tesztelés játssza a dokumentáció szerepét. Nem dokumentáljuk a metódusokat, hanem unit-teszteket fejlesztünk hozzá. Nem készítünk követelményspecifikációt, hanem átvételi teszteseteket fejlesztünk a megértett követelményekből.

- *Odafigyelés:* A fejlesztőknek oda kell figyelniük a megrendelőkre, meg kell érteniük az igényeiket. El kell magyarázni nekik, hogy hogyan lehet technikailag kivitelezni ezeket az igényeket, és ha egy igény kivitelezhetetlen, ezt meg kell értetni a megrendelővel.

- *Tervezés:* Tervezés nélkül nem lehet szoftvert fejleszteni, mert az ad- hoc megoldások átláthatatlan struktúrához vezetnek. Mivel fel kell készülni az igények változására, ezért úgy kell megtervezni a szoftvert, hogy egyes komponensei amennyire csak lehet függetlenek legyenek a többitől. Ezért érdemes pl. objektum orientált tervezési alapelveket használni.

