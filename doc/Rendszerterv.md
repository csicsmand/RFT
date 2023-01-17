# Rendszerterv

## A rendszer célja

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

## Tesztterv
A projekt elkészítése során folyamatos tesztelésre van szükség, melynek célja a rendszer és komponensei funkcionalitásának teljes vizsgálata, ellenőrzése. Tesztelni kell a back-end részt, az adminisztrátori funkciók működését. Tesztelni kell a dizájn minden elemét. Tesztelni kell az adatbázis megfelelő működését, értjük ez alatt az adatok helyes tárolását stb.

Alfa teszt: Meglévő funkcióknak a klienssel. A tesztet a fejlesztők végzik.

Béta teszt: Ezt a tesztet nem a fejlesztők végzik. A kliens funkciói. 


## Telepítési terv
Szerver: Node Js, Apache és PHPMyadmin.
Kliens: Különösebb telepítést nem igényel.

## Karbantartási terv
Az alkalmazás üzelmetétese és karbantartása magába foglalja a programhibák elhárítását. Az alkalmazás bővítési lehetőségét fenntartjuk. Belső illetve egyéb igények, környezeti feltételek változása esetén kiterjed a program- és állomány modosításra is. 
