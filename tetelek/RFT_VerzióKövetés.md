# Rendszerfejlesztés eszközei, feladatkövetés, verziókövetés

**Verziókövetés:** A verziókövetés ugyan közvetetten magába foglalja egy termék 1.2 és 1.3 verziója közötti eltérések követését is, de alapvetően nem erről van szó. Erre a whatsnew.txt a megfelelő eszköz. A verziókövető rendszerek képesek állományok tartalmi változásait követni, figyelembe véve, hogy ki és mikor módosította azokat, valamint korábbi állapotokat is képes előállítani.

**A verziókövető rendszerek lehetővé teszik, hogy:**
- A verziókövetés alá helyezett minden állomány, minden korábbi változatát vissza lehet keresni.

- Egy állomány tetszőleges két változata közötti eltéréseket meg tudja jeleníteni.

- Ha ketten egyszerre módosítják ugyanazt az állományt, akkor lehetőség szerint mindkettőjük módosításai megfelelően rögzítésre kerüljenek. Amennyiben a két módosítás ütközne egymással, akkor a későbbi módosítást végző személy értesüljön a konfliktusról és dönteni tudjon arról, hogy milyen tartalom kerüljön be végül az állományba.

- Elágazásokat hozhatunk létre. Tegyük fel, hogy az alap szoftverünkből készítünk egy általános iskoláknak és egy középiskoláknak szánt verziót is, akkor ezeket külön ágra (branch) helyezhetjük. A későbbiekben ezeket külön-külön fejleszthetjük.

**Veziókövető rendszerek:**
- RCS
- CVS
- Subversion
- Git
- CMVC (IBM)
- SourceSafe (Microsoft)

**Feladatkövető rendszer:**
- Kanban
- Trello

