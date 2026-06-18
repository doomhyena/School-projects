# 🌐 Hálózatok II.

A Hálózatok II. tantárgy a Bláthy Ottó Villamosipari Technikumban a haladó hálózati ismereteket fedi le: switchek és routerek konfigurálásától a VLAN-okon, STP-n és EtherChannelen át a DHCPv4/v6 és IPv6 protokollokig.

## Mit fogsz itt tanulni?

Az **01. Modul** az alapvető hálózati fogalmakat ismétli át (hálózati eszközök, topológiák, internetkapcsolat, hálózatbiztonság). A **02. Modul** gyakorlati Cisco IOS konfigurációkat tartalmaz: switch és router alapbeállítások, VLAN-ok, STP, EtherChannel, DHCPv4 és DHCPv6.

## Kapcsolódó tantárgyak

- [[Hálózatok I.]] — Alapismeretek és ágazati alapvizsga előkészítő
- [[Szerverek és felhőszolgáltatások]] — Szerver oldali hálózati alkalmazások

---

## 01. Modul – Hálózati alapfogalmak

### 1.2 A hálózatok részei

- [[1.2.1 Állomások]]
- [[1.2.2 Egyenrangú hálózatok (Peer-to-Peer)]]
- [[1.2.3 Végberendezések (End Devices)]]
- [[1.2.4 Közvetítő eszközök (Intermediary Devices)]]

### 1.3 A hálózatok megjelenítése és a topológiák

- [[1.3.1 Megjelenítés]]
- [[1.3.2 Topológiai ábrák]]

### 1.4 Gyakori hálózattípusok

- [[1.4.1 Különböző méretű hálózatok]]
- [[1.4.2 LAN-ok és WAN-ok]]
- [[1.4.3 Az internet]]
- [[1.4.4 Intranet és extranet]]

### 1.5 Internetkapcsolat

- [[1.5.1 Csatlakozási technológiák]]
- [[1.5.2-1.5.3 Kapcsolattípusok]]
- [[1.5.4 Konvergált hálózatok]]

### 1.6 Megbízható hálózatok

- [[1.6.2 Hibatűrés]]
- [[1.6.3 Skálázhatóság]]
- [[1.6.4 Szolgáltatásminőség (QoS)]]
- [[1.6.5 Hálózatbiztonság]]

### 1.7 Hálózati trendek

- [[1.7.1-1.7.5 Mai trendek]]
- [[1.7.6 Felhőalapú szolgáltatások]]
- [[1.7.7-1.7.9 Otthoni technológiák]]

### 1.8 Hálózatbiztonság

- [[1.8.1 Fenyegetések]]
- [[1.8.2 Megoldások]]

---

## 02. Modul – Kapcsolás, VLAN-ok és hálózati protokollok

### 1. rész – Switch és router alapbeállítások

#### 1.1 A switch alapbeállításainak megadása

- [[1.1.1 A switch rendszerindítási sorrendje]]
- [[1.1.2 A boot system parancs]]
- [[1.1.3 A switch LED-jelzőfényei]]
- [[1.1.4 Helyreállítás egy rendszerösszeomlás után]]
- [[1.1.5 A switch felügyeleti hozzáférése]]
- [[1.1.6 Példa a switch virtuális interfészének (SVI) beállítására]]

#### 1.2 Switchportok konfigurációja

- [[1.2.1 Duplex kommunikáció]]
- [[1.2.2 Switchportok beállítása a fizikai rétegben]]
- [[1.2.3 Auto-MDIX]]
- [[1.2.4 A switch ellenőrzésére szolgáló parancsok]]
- [[1.2.5 A switchportok beállításainak ellenőrzése]]
- [[1.2.6 A hálózatelérési réteg problémái]]
- [[1.2.7 Az interfész bemeneti és kimeneti hibái]]
- [[1.2.8 A hálózatelérési réteg problémáinak hibaelhárítása]]

#### 1.3 Secure Remote Access

- [[1.3.1 A Telnet működése]]
- [[1.3.2 Az SSH működése]]
- [[1.3.3 A switch SSH-támogatottságának ellenőrzése]]
- [[1.3.4 Az SSH beállítása]]
- [[1.3.5 Az SSH működésének ellenőrzése]]

#### 1.4 A router alapbeállításainak megadása

- [[1.4.1 A router alapvető beállításainak megadása]]
- [[1.4.2 Parancsszimulátor - A router alapvető beállításainak megadása]]
- [[1.4.3 A dual stack topológia]]
- [[1.4.4 Router interfészek konfigurálása]]
- [[1.4.5 Parancsszimulátor - Router interfészek konfigurálása]]
- [[1.4.6 IPv4-es loopback interfészek]]

#### 1.5 Közvetlenül csatlakozó hálózatok ellenőrzése

- [[1.5.1 Interfészellenőrző parancsok]]
- [[1.5.2 Az interfész állapotának ellenőrzése]]
- [[1.5.3 IPv6 link-local és multicast címek ellenőrzése]]
- [[1.5.4 Az interfész konfigurációjának ellenőrzése]]
- [[1.5.5 Útvonalak ellenőrzése]]
- [[1.5.6 A show parancsok kimenetének szűrése]]
- [[1.5.7 Parancsszimulátor - A show parancsok kimenetének szűrése]]
- [[1.5.8 Parancselőzmények]]
- [[1.5.9 Parancsszimulátor - Parancselőzmények]]

---

### 2. rész – Frame Forwarding és szórási tartományok

#### 2.1 Frame Forwarding

- [[2.1.1 Hálózati kapcsolás]]
- [[2.1.2 A switch MAC-címtáblája]]
- [[2.1.3 A switch tanulási és továbbítási módszere]]
- [[2.1.4 Videó - Egymáshoz csatlakoztatott switch-ek MAC-címtáblái]]
- [[2.1.5 Kapcsolási módok]]
- [[2.1.6 Tárol-és-továbbít kapcsolás]]

#### 2.2 Collision and Broadcast Domains

- [[2.2.1 Ütközési tartományok]]
- [[2.2.2 Szórási tartományok]]
- [[2.2.3 Hálózati túlterhelés enyhítése]]

---

### 3. rész – VLAN-ok konfigurálása

#### 3.1 Overview of VLANs

- [[3.1.1 VLAN definíciók]]
- [[3.1.2 A VLAN kialakításának előnyei]]
- [[3.1.3 VLAN típusok]]

#### 3.2 VLAN-ok több switch-et tartalmazó környezetben

- [[3.2.1 VLAN-trönkök meghatározása]]
- [[3.2.2 VLAN-ok nélküli hálózat]]
- [[3.2.3 VLAN-okat használó hálózat]]
- [[3.2.4 VLAN azonosítása címkével]]
- [[3.2.5 Natív VLAN-ok és a 802.1Q címkézés]]
- [[3.2.6 Hangátviteli VLAN-ok címkézése]]
- [[3.2.7 Példa a hang VLAN ellenőrzésére]]

#### 3.3 VLAN Configuration

- [[3.3.1 VLAN-tartományok a Catalyst switch-eken]]
- [[3.3.2 VLAN létrehozási parancsok]]
- [[3.3.3 Példa VLAN létrehozására]]
- [[3.3.4 A portok VLAN-hoz rendelése]]
- [[3.3.5 Példa a portok VLAN-hoz történő hozzárendelésére]]
- [[3.3.6 Adat és hang VLAN-ok]]
- [[3.3.7 Példa adat és hang VLAN-okra]]
- [[3.3.8 VLAN-információk ellenőrzés]]
- [[3.3.9 Port VLAN-tagságának megváltoztatása]]
- [[3.3.10 VLAN-ok törlése]]
- [[3.3.11 Parancsszimulátor - VLAN-konfiguráció]]

#### 3.4 VLAN-trönkök

- [[3.4.1 Trönkkonfigurációs parancsok]]
- [[3.4.2 Trönkkonfigurációs példa]]
- [[3.4.3 Trönkbeállítások ellenőrzése]]
- [[3.4.4 A trönk visszaállítása alapértelmezett állapotra]]

#### 3.5 Dynamic Trunking Protocol

- [[3.5.1 A DTP bemutatása]]
- [[3.5.2 Egyeztetett interfészmódok]]
- [[3.5.3 A DTP-konfiguráció eredményei]]
- [[3.5.4 A DTP-mód ellenőrzése]]

---

### 4. rész – VLAN-ok közötti forgalomirányítás

#### 4.1 A VLAN-ok közötti forgalomirányítás alapjai

- [[4.1.1 Mit értünk VLAN-ok közötti forgalomirányításon]]
- [[4.1.2 A VLAN-ok közti forgalomirányítás hagyományos módja]]
- [[4.1.3 VLAN-ok közötti forgalomirányítás router-on-a-stick módszerrel]]
- [[4.1.4 VLAN-ok közötti forgalomirányítás 3. rétegbeli switch-en]]

#### 4.2 VLAN-ok közötti forgalomirányítás router-on-a-stick módszerrel

- [[4.2.1 Router-on-a-stick eset]]
- [[4.2.2 Az S1 VLAN- és trönkkonfigurációja]]
- [[4.2.3 Az S2 VLAN- és trönkkonfigurációja]]
- [[4.2.4 Az R1 alinterfész-konfigurációs módja]]
- [[4.2.5 A PC1 és PC2 közötti kapcsolat ellenőrzése]]
- [[4.2.6 A router-on-a-stick VLAN-ok közötti forgalomirányítás ellenőrzése]]

#### 4.3 VLAN-ok közötti forgalomirányítás 3. rétegbeli switch-en

- [[4.3.1 VLAN-ok közötti forgalomirányítás egy 3. rétegbeli switch-en]]
- [[4.3.2 A 3. rétegbeli switch esete]]
- [[4.3.3 A 3. rétegbeli switch konfigurációja]]
- [[4.3.4 A 3. rétegbeli switch VLAN-ok közötti forgalomirányításának ellenőrzése]]
- [[4.3.5 Forgalomirányítás 3. rétegbeli switch-en]]
- [[4.3.6 A forgalomirányítás esete 3. rétegbeli switch-en]]
- [[4.3.7 Forgalomirányítás konfigurálása 3. rétegbeli switch-en]]

#### 4.4 VLAN-ok közötti forgalomirányítás hibaelhárítása

- [[4.4.1 A VLAN-ok közötti forgalomirányítás gyakori problémái]]
- [[4.4.2 A VLAN-ok közötti forgalomirányítás hibaelhárításának esete]]
- [[4.4.3 Hiányzó VLAN-ok]]
- [[4.4.4 Switch trönkportjával kapcsolatos problémák]]
- [[4.4.5 A switch hozzáférési portjával kapcsolatos problémák]]
- [[4.4.6 A router konfigurálásával kapcsolatos kérdések]]

---

### 5. rész – Spanning Tree Protocol (STP)

#### 5.1 Az STP célja

- [[5.1.1 Redundancia a 2. rétegbeli kapcsolt hálózatokban]]
- [[5.1.2 Feszítőfa-protokoll (Spanning Tree Protocol)]]
- [[5.1.3 Az STP újraszámítása]]
- [[5.1.4 A redundáns switch-kapcsolatok problémái]]
- [[5.1.5 2. rétegbeli hurkok]]
- [[5.1.6 Szórási vihar]]
- [[5.1.7 A feszítőfa-algoritmus (STA)]]

#### 5.2 Az STP működése

- [[5.2.1 A hurokmentes topológia létrehozásának lépései]]
- [[5.2.2 1. A gyökérponti híd kiválasztása]]
- [[5.2.3 Az alapértelmezett BID-ek hatása]]
- [[5.2.4 A gyökérelérési útvonal költségének meghatározása]]
- [[5.2.5 2. Gyökérportok megválasztása]]
- [[5.2.6 3. Kijelölt portok megválasztása]]
- [[5.2.7 4. Alternatív (lezárt) portok kijelölése]]
- [[5.2.8 Gyökérport kijelölése több, egyenlő költségű útvonalon]]
- [[5.2.9 STP-időzítők és -portállapotok]]
- [[5.2.10 Az összes portállapot működési adatai]]
- [[5.2.11 VLAN-onkénti feszítőfa-protokoll]]

#### 5.3 Az STP fejlődése

- [[5.3.1 Az STP különböző változatai]]
- [[5.3.2 Az RSTP alapjai]]
- [[5.3.3 RSTP portállapotok és portszerepkörök]]
- [[5.3.4 PortFast és BPDU Guard]]
- [[5.3.5 Az STP alternatívái]]

---

### 6. rész – EtherChannel

#### 6.1 EtherChannel Operation

- [[6.1.1 Portok összefogása (Link Aggregation)]]
- [[6.1.2 EtherChannel]]
- [[6.1.3 Az EtherChannel előnyei]]
- [[6.1.4 A megvalósítás korlátai]]
- [[6.1.5 Automatikus egyeztető protokollok]]
- [[6.1.6 A PagP működése]]
- [[6.1.7 Példa a PagP-módok beállításaira]]
- [[6.1.8 Az LACP működése]]
- [[6.1.9 Példa az LACP-módok beállításaira]]

#### 6.2 Az EtherChannel konfigurálása

- [[6.2.1 Konfigurálási útmutató]]
- [[6.2.2 LACP konfigurációs példa]]
- [[6.2.3 Parancsszimulátor - Az EtherChannel konfigurálása]]

#### 6.3 Az EtherChannel ellenőrzése és hibajavítása

- [[6.3.1 Az EtherChannel ellenőrzése]]
- [[6.3.2 Gyakori problémák az EtherChannel konfigurációjával]]
- [[6.3.3 EtherChannel hibaelhárítási példa]]

---

### 7. rész – DHCPv4

#### 7.1 DHCPv4 alapfogalmak

- [[7.1.1 DHCPv4-kiszolgáló és ügyfél]]
- [[7.1.2 A DHCPv4 működése]]
- [[7.1.3 A bérlet megszerzésének lépései]]
- [[7.1.4 A bérlet megújítása]]

#### 7.2 Cisco IOS DHCPv4-kiszolgáló konfigurálása

- [[7.2.1 Cisco IOS DHCPv4-kiszolgáló]]
- [[7.2.2 A Cisco IOS DHCPv4 kiszolgáló konfigurálásának lépései]]
- [[7.2.3 Konfigurációs példa]]
- [[7.2.4 A DHCPv4 működését ellenőrző parancsok]]
- [[7.2.5 A DHCPv4 működésének ellenőrzése]]
- [[7.2.6 Parancsszimulátor - DHCPv4 konfigurálása]]
- [[7.2.7 A Cisco IOS DHCPv4-kiszolgáló letiltása]]
- [[7.2.8 DHCPv4 Relay]]
- [[7.2.9 Egyéb továbbított szórásos szolgáltatások]]

#### 7.3 DHCPv4-ügyfél konfigurálása

- [[7.3.1 A Cisco Router, mint DHCPv4-kliens]]
- [[7.3.2 Konfigurációs példa]]
- [[7.3.3 Otthoni router DHCPv4-kliensként]]
- [[7.3.4 Parancsszimulátor - Cisco router konfigurálása DHCP-ügyfélként]]

---

### 8. rész – DHCPv6 és IPv6 automatikus cím-hozzárendelés

#### 8.1 IPv6 GUA hozzárendelés

- [[8.1.1 IPv6 állomás konfiguráció]]
- [[8.1.2 IPv6 állomás link-local cím]]
- [[8.1.3 IPv6 GUA hozzárendelés]]
- [[8.1.4 Az RA üzenetek három jelzőbitje]]

#### 8.2 SLAAC

- [[8.2.1 A SLAAC áttekintése]]
- [[8.2.2 A SLAAC engedélyezése]]
- [[8.2.3 A SLAAC kizárólagos használata]]
- [[8.2.4 ICMPv6 RS üzenetek]]
- [[8.2.5 Interfész azonosító előállításának folyamata az állomáson]]
- [[8.2.6 Duplikált cím felderítés]]

#### 8.3 DHCPv6

- [[8.3.1 A DHCPv6 működésének lépései]]
- [[8.3.2 Az állapotmentes DHCPv6 működése]]
- [[8.3.3 Állapotmentes DHCPv6 engedélyezése egy interfészen]]
- [[8.3.4 Az állapottartó DHCPv6 működése]]
- [[8.3.5 Állapottartó DHCPv6 engedélyezése interfészen]]

#### 8.4 DHCPv6-kiszolgáló konfigurálása

- [[8.4.1 DHCPv6 router szerepek]]
- [[8.4.2 Állapotmentes DHCPv6-szerver konfigurálása]]
- [[8.4.3 Állapotmentes DHCPv6-kliens konfigurálása]]
- [[8.4.4 Állapottartó DHCPv6-kiszolgáló konfigurálása]]
- [[8.4.5 Állapottartó DHCPv6-kliens konfigurálása]]
- [[8.4.6 DHCPv6-kiszolgáló ellenőrzésének parancsai]]
- [[8.4.7 DHCPv6-közvetítő beállítása]]
- [[8.4.8 DHCPv6-közvetítő ellenőrzése]]

---

## Ajánlott tanulási útvonal

Az **01. Modullal** kezdj, ha frissíteni szeretnéd az alapokat (hálózati eszközök, topológiák, internet). A **02. Modulban** az 1. résztől haladj sorban: először switch és router alapbeállítások (1. rész), majd switchelt hálózatok (2. rész), VLAN-ok (3-4. rész), STP (5. rész), EtherChannel (6. rész), végül DHCP és IPv6 (7-8. rész).
