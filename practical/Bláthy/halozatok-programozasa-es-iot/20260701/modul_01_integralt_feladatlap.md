# Programozási alapok Pythonban - integrált feladatlap kommentált megoldásokkal

## 1. feladat: Szenzoradatok egyszerű elemzése

### Kiinduló helyzet
Egy okosotthon hőmérője 10 percenként adatot küld a vezérlőnek. A kapott lista az elmúlt 80 perc hőmérsékleti értékeit tartalmazza Celsius-fokban. A vezérlőnek nemcsak meg kell jelenítenie az adatokat, hanem egyszerű döntést is kell hoznia arról, hogy szükséges-e hűtés vagy figyelmeztetés. Ez a feladat a listakezelés, a függvényírás, az elágazás és a ciklus gyakorlására szolgál IoT-környezetben.

### Feladatok
1. Számítsd ki az átlaghőmérsékletet.
2. Keresd meg a legkisebb és legnagyobb értéket.
3. Írj riasztást, ha bármelyik érték meghaladja a 24 °C-ot.
4. Készíts classify_temperature(value) nevű függvényt, amely cold, normal vagy hot értéket ad vissza.
5. Írd ki minden mérés mellé a besorolást.
6. Bővítésként döntsd el, hogy az átlag alapján be kell-e kapcsolni a ventilátort.

### Kommentált programkód
```python

# 1. feladat: Szenzoradatok egyszerű elemzése
# Kiinduló helyzet:
# Egy okosotthon hőmérője 10 percenként adatot küld a vezérlőnek.
# A lista az elmúlt 80 perc méréseit tartalmazza Celsius-fokban.
# A cél az, hogy a tanulók listákkal, függvényekkel, elágazásokkal és ciklusokkal
# dolgozzanak, miközben egy valós IoT-jellegű problémát oldanak meg.

# ELŐZETES ISMERET: lista
# A lista több érték tárolására alkalmas adatszerkezet.
# Itt minden elem egy hőmérsékleti mérés.
temperature_values = [21.8, 22.1, 22.5, 23.0, 24.2, 25.1, 24.8, 23.6]


# ELŐZETES ISMERET: függvény
# A függvény újrafelhasználható programrész. A values paraméterrel bármilyen
# számlistát átadhatunk, nem csak a fenti temperature_values listát.
def calculate_average(values):
    # ELŐZETES ISMERET: üres lista kezelése
    # Üres listára nem lehetne átlagot számítani, mert nullával osztanánk.
    if len(values) == 0:
        return 0

    # ELŐZETES ISMERET: sum(), len()
    # sum(values): az elemek összege
    # len(values): az elemek száma
    return sum(values) / len(values)


# ELŐZETES ISMERET: feltételes elágazás
# A függvény egyetlen mérési értéket kategóriába sorol.
def classify_temperature(value):
    if value < 20:
        return "cold"
    elif value <= 24:
        # 20 és 24 Celsius-fok között normál tartományról beszélünk.
        return "normal"
    else:
        # 24 Celsius-fok felett az értéket magasnak minősítjük.
        return "hot"


# ELŐZETES ISMERET: összetettebb feldolgozó függvény
# Ez a függvény kiszámítja a fő statisztikai értékeket, majd minden mérést kiír.
def print_temperature_report(values):
    average = calculate_average(values)
    minimum = min(values)
    maximum = max(values)

    print("Hőmérsékleti adatok elemzése")
    print(f"Átlaghőmérséklet: {average:.2f} °C")
    print(f"Minimum hőmérséklet: {minimum} °C")
    print(f"Maximum hőmérséklet: {maximum} °C")

    print("\nMért értékek besorolása:")

    # ELŐZETES ISMERET: for ciklus
    # A ciklus végigmegy a lista minden mérési értékén.
    for value in values:
        category = classify_temperature(value)
        print(f"{value} °C -> {category}")

        # ELŐZETES ISMERET: riasztási feltétel
        # IoT-rendszerekben gyakori, hogy egy küszöbérték átlépése eseményt vált ki.
        if value > 24:
            print("  Figyelmeztetés: magas hőmérséklet!")


# ELŐZETES ISMERET: logikai visszatérési érték
# A függvény True/False értéket ad vissza, vagyis eldönti, hogy szükséges-e művelet.
def should_turn_on_fan(values):
    average = calculate_average(values)

    # BŐVÍTÉS: nem egyetlen kiugró érték, hanem az átlag alapján döntünk.
    return average > 24


# ELŐZETES ISMERET: program belépési pontja
# Az alábbi rész akkor fut le, ha közvetlenül ezt a fájlt indítjuk el.
if __name__ == "__main__":
    print_temperature_report(temperature_values)

    print("\nVentilátor vezérlése:")

    if should_turn_on_fan(temperature_values):
        print("A ventilátort be kell kapcsolni.")
    else:
        print("A ventilátor kikapcsolva maradhat.")
```

## 2. feladat: IoT-eszközleltár feldolgozása Pythonban

### Kiinduló helyzet
Egy okosotthonban több különböző eszköz található: lámpa, ventilátor, ajtó, mozgásérzékelő, hőmérő, locsoló és szélérzékelő. A központi vezérlő minden eszközről tárolja az azonosítót, a nevet, a típust, a helyiséget és az aktuális állapotot vagy mért értéket. A hallgatók egy Python-listát kapnak, amelyben minden eszköz egy szótárként szerepel. A feladat célja az adatszerkezetek, a keresés, a szűrés és az összesítés gyakorlása.

### Feladatok
1. Írj függvényt, amely kilistázza az összes eszköz nevét és típusát.
2. Írj függvényt, amely csak a szenzorokat jeleníti meg.
3. Írj függvényt, amely csak az aktuátorokat jeleníti meg.
4. Írj keresőfüggvényt, amely id alapján visszaad egy eszközt.
5. Írj függvényt, amely megszámolja, hány eszköz van helyiségenként.
6. Bővítsd a programot úgy, hogy új eszközt lehessen hozzáadni.

### Kommentált programkód
```python

# 2. feladat: IoT-eszközleltár feldolgozása Pythonban
# Kiinduló helyzet:
# Egy okosotthon központi vezérlője nyilvántartja a hozzá kapcsolódó eszközöket.
# A szenzorok adatokat mérnek, például mozgást vagy hőmérsékletet.
# Az aktuátorok parancsokat hajtanak végre, például lámpát kapcsolnak vagy ajtót zárnak.
# A feladat célja a lista, a szótár, a keresés, a szűrés és az összesítés gyakorlása.

# ELŐZETES ISMERET: lista szótárakkal
# Minden eszköz egy szótár. A szótár kulcs-érték párokat tárol.
# Például: "name" -> "Smart Lamp", "type" -> "actuator".
devices = [
    {"id": 1, "name": "Smart Lamp", "type": "actuator", "room": "living_room", "status": "off"},
    {"id": 2, "name": "Motion Detector", "type": "sensor", "room": "hall", "status": "inactive"},
    {"id": 3, "name": "Smart Door", "type": "actuator", "room": "entrance", "status": "locked"},
    {"id": 4, "name": "Temperature Meter", "type": "sensor", "room": "bedroom", "value": 22.5},
    {"id": 5, "name": "Lawn Sprinkler", "type": "actuator", "room": "garden", "status": "off"},
    {"id": 6, "name": "Wind Detector", "type": "sensor", "room": "garden", "status": "inactive"}
]


# ELŐZETES ISMERET: függvény paraméterrel
# A device_list paraméter miatt a függvény bármely hasonló eszközlistával használható.
def list_devices(device_list):
    print("Összes IoT-eszköz:")

    # ELŐZETES ISMERET: bejárás for ciklussal
    for device in device_list:
        print(f"{device['id']}. {device['name']} - {device['type']} - {device['room']}")


# ELŐZETES ISMERET: szűrés
# Csak azok az eszközök jelennek meg, amelyek type mezője megegyezik a kért típussal.
def list_by_type(device_list, device_type):
    print(f"\n{device_type.capitalize()} típusú eszközök:")

    for device in device_list:
        if device["type"] == device_type:
            print(f"{device['id']}. {device['name']} - {device['room']}")


# ELŐZETES ISMERET: keresés azonosító alapján
# A valódi IoT-rendszerekben az eszközöket gyakran egyedi azonosító alapján kezeljük.
def find_device_by_id(device_list, device_id):
    for device in device_list:
        if device["id"] == device_id:
            return device

    # ELŐZETES ISMERET: None
    # A None azt jelzi, hogy nem találtunk megfelelő eszközt.
    return None


# ELŐZETES ISMERET: összesítés szótárral
# A room_counter kulcsa a helyiség neve, értéke pedig az ott található eszközök száma.
def count_devices_by_room(device_list):
    room_counter = {}

    for device in device_list:
        room = device["room"]

        if room in room_counter:
            room_counter[room] += 1
        else:
            room_counter[room] = 1

    return room_counter


# ELŐZETES ISMERET: új elem hozzáadása listához
# Az új eszköz új azonosítót kap, majd bekerül a devices listába.
def add_device(device_list, name, device_type, room, status="off"):
    # ELŐZETES ISMERET: max() és generátorkifejezés
    # Megkeressük a legnagyobb meglévő ID-t, majd eggyel növeljük.
    new_id = max(device["id"] for device in device_list) + 1

    new_device = {
        "id": new_id,
        "name": name,
        "type": device_type,
        "room": room,
        "status": status
    }

    # ELŐZETES ISMERET: lista módosítása
    # Az append() az eredeti listát módosítja.
    device_list.append(new_device)
    return new_device


if __name__ == "__main__":
    # Program futtatása, a függvények kipróbálása
    list_devices(devices)

    list_by_type(devices, "sensor")
    list_by_type(devices, "actuator")

    searched_id = 3
    found_device = find_device_by_id(devices, searched_id)

    print(f"\nKeresett eszköz ID alapján: {searched_id}")

    if found_device is not None:
        print("Talált eszköz:")
        print(found_device)
    else:
        print("Nincs ilyen azonosítójú eszköz.")

    print("\nEszközök száma helyiségenként:")
    room_counts = count_devices_by_room(devices)

    for room, count in room_counts.items():
        print(f"{room}: {count} db")

    print("\nÚj eszköz hozzáadása:")
    new_device = add_device(
        devices,
        name="Smart Fan",
        device_type="actuator",
        room="bedroom",
        status="off"
    )

    print("Hozzáadott eszköz:")
    print(new_device)

    print("\nFrissített eszközlista:")
    list_devices(devices)
```

## 3. feladat: Egyszerű okosotthon-szabálymotor

### Kiinduló helyzet
Az okosotthon-vezérlő egyszerre több állapotadat alapján dönt: érzékel-e mozgást a mozgásérzékelő, mekkora a hőmérséklet, zárva van-e az ajtó, illetve milyen állapotban van a lámpa és a ventilátor. A rendszer célja, hogy egyszerű szabályok alapján automatikusan módosítsa az aktuátorok állapotát, és közben érthető üzeneteket adjon a felhasználónak vagy az üzemeltetőnek.

### Feladatok
1. Ha mozgás van, kapcsoljon be a lámpa.
2. Ha nincs mozgás, kapcsoljon ki a lámpa.
3. Ha a hőmérséklet 25 °C fölött van, kapcsoljon be a ventilátor.
4. Ha a hőmérséklet 22 °C alatt van, kapcsoljon ki a ventilátor.
5. Ha mozgás van és az ajtó zárva van, írjon biztonsági üzenetet.
6. A szabályokat külön függvénybe szervezd: apply_rules(home_state).

### Kommentált programkód
```python

# 3. feladat: Egyszerű okosotthon-szabálymotor
# Kiinduló helyzet:
# Egy okosotthon-vezérlő egyszerre több állapotadatot lát:
# - van-e mozgás,
# - mennyi a hőmérséklet,
# - zárva van-e az ajtó,
# - milyen állapotban van a lámpa és a ventilátor.
# A rendszer ezekből az adatokból szabályok alapján dönt.
# A cél a logikai feltételek, a szótárkezelés és a függvénybe szervezés gyakorlása.

# ELŐZETES ISMERET: állapottér szótárral
# Egy IoT-rendszer aktuális állapotát egyszerűen modellezhetjük egy szótárral.
home_state = {
    "motion": True,
    "temperature": 26.3,
    "door": "locked",
    "lamp": "off",
    "fan": "off"
}


# ELŐZETES ISMERET: szabálymotor
# A szabálymotor olyan függvény, amely bemeneti állapotból új állapotot és üzeneteket készít.
def apply_rules(original_state):
    # ELŐZETES ISMERET: másolat készítése
    # A copy() miatt az eredeti home_state változó nem módosul közvetlenül.
    # Ez jó gyakorlat, mert könnyebb összehasonlítani a régi és az új állapotot.
    state = original_state.copy()

    # ELŐZETES ISMERET: lista üzenetek gyűjtésére
    # Az üzenetek később kiírhatók, naplózhatók vagy elküldhetők egy másik rendszernek.
    messages = []

    # 1-2. szabály: mozgás alapján lámpavezérlés
    if state["motion"]:
        state["lamp"] = "on"
        messages.append("Mozgás érzékelve: lámpa bekapcsolva.")
    else:
        state["lamp"] = "off"
        messages.append("Nincs mozgás: lámpa kikapcsolva.")

    # 3-4. szabály: hőmérséklet alapján ventilátorvezérlés
    # ELŐZETES ISMERET: if-elif-else szerkezet
    # Egyszerre csak az első igaz ág fut le.
    if state["temperature"] > 25:
        state["fan"] = "on"
        messages.append("A hőmérséklet 25 °C felett van: ventilátor bekapcsolva.")
    elif state["temperature"] < 22:
        state["fan"] = "off"
        messages.append("A hőmérséklet 22 °C alatt van: ventilátor kikapcsolva.")
    else:
        messages.append("A hőmérséklet normál tartományban van.")

    # 5. szabály: összetett feltétel
    # ELŐZETES ISMERET: and logikai operátor
    # A biztonsági üzenet csak akkor jelenik meg, ha mindkét feltétel igaz.
    if state["motion"] and state["door"] == "locked":
        messages.append("Biztonsági figyelmeztetés: mozgás érzékelhető zárt ajtó mellett.")

    # ELŐZETES ISMERET: több érték visszaadása
    # A függvény az új állapotot és az üzeneteket is visszaadja.
    return state, messages


if __name__ == "__main__":
    new_state, messages = apply_rules(home_state)

    print("Eredeti állapot:")
    print(home_state)

    print("\nÚj állapot:")
    print(new_state)

    print("\nÜzenetek:")
    for message in messages:
        print("-", message)
```

## 4. feladat: IoT-konfiguráció mentése JSON-fájlba

### Kiinduló helyzet
Egy okosotthon-rendszerben az eszközök állapotát nem elegendő csak a program futása közben tárolni. Ha a vezérlő újraindul, akkor az eszközök nevét, típusát, helyiségét és állapotát vissza kell tudni tölteni. Ehhez egy smart_home_config.json nevű konfigurációs fájlt használunk. A feladat célja a JSON-formátum, a fájlkezelés, a kivételkezelés, az inputkezelés és az egyszerű menüvezérlés gyakorlása.

### Feladatok
1. Hozz létre smart_home_config.json fájlt.
2. Mentsd bele az eszközök nevét, típusát, helyiségét és állapotát.
3. Írj Python-programot, amely betölti ezt a fájlt.
4. Kezelje le, ha a fájl nem létezik.
5. Kezelje le, ha hibás a JSON.
6. Írja ki az eszközök listáját rendezett formában.
7. Bővítésként a program módosítson egy eszközállapotot, majd mentse vissza a fájlt.

### Kommentált programkód
```python

# 4. feladat: IoT-konfiguráció mentése JSON-fájlba
# Kiinduló helyzet:
# Egy okosotthon-rendszernek újraindítás után is emlékeznie kell az eszközök állapotára.
# Ezért az eszközök adatait JSON-fájlba mentjük.
# A JSON azért hasznos, mert ember számára olvasható, és sok rendszer tudja feldolgozni.
# A cél a fájlkezelés, a JSON-szerializáció, a hibakezelés és az egyszerű menürendszer gyakorlása.

# ELŐZETES ISMERET: modul importálása
# A json modul a Python beépített eszköze JSON-adatok írására és olvasására.
import json


# ELŐZETES ISMERET: konstans
# A nagybetűs név azt jelzi, hogy ezt az értéket a programban állandóként kezeljük.
CONFIG_FILE = "smart_home_config.json"


# ELŐZETES ISMERET: alapértelmezett konfiguráció
# Ezt használjuk, ha a fájl még nem létezik, vagy hibás a tartalma.
default_config = [
    {"id": 1, "name": "Smart Lamp", "type": "actuator", "room": "living_room", "status": "off"},
    {"id": 2, "name": "Motion Detector", "type": "sensor", "room": "hall", "status": "inactive"},
    {"id": 3, "name": "Smart Door", "type": "actuator", "room": "entrance", "status": "locked"},
    {"id": 4, "name": "Temperature Meter", "type": "sensor", "room": "bedroom", "value": 22.5}
]


# ELŐZETES ISMERET: JSON-fájl mentése
# A json.dump() Python-adatszerkezetből JSON-fájlt készít.
def save_config(config):
    # ELŐZETES ISMERET: with open(...)
    # A with szerkezet automatikusan bezárja a fájlt a művelet végén.
    with open(CONFIG_FILE, "w", encoding="utf-8") as file:
        # indent=4: olvasható, tagolt formátum
        # ensure_ascii=False: az ékezetes karakterek is szépen jelennek meg
        json.dump(config, file, indent=4, ensure_ascii=False)


# ELŐZETES ISMERET: JSON-fájl betöltése hibakezeléssel
# A függvény megpróbálja beolvasni a konfigurációt, de hiba esetén sem omlik össze.
def load_config():
    try:
        with open(CONFIG_FILE, "r", encoding="utf-8") as file:
            return json.load(file)

    except FileNotFoundError:
        # ELŐZETES ISMERET: kivételkezelés
        # Ha a fájl még nincs meg, létrehozzuk az alapértelmezett konfigurációból.
        print("A konfigurációs fájl nem található. Alapértelmezett fájl létrehozása.")
        save_config(default_config)
        return default_config.copy()

    except json.JSONDecodeError:
        # Ez akkor fordul elő, ha a fájl létezik, de nem érvényes JSON-formátumú.
        print("Hibás JSON-fájl. Alapértelmezett konfiguráció betöltése.")
        return default_config.copy()


# ELŐZETES ISMERET: rendezett megjelenítés
# Az if "status" in device ellenőrzi, hogy az adott kulcs létezik-e a szótárban.
def list_devices(config):
    print("\n--- Eszközlista ---")

    for device in config:
        text = f"{device['id']}. {device['name']} | {device['type']} | {device['room']}"

        if "status" in device:
            text += f" | állapot: {device['status']}"

        if "value" in device:
            text += f" | érték: {device['value']}"

        print(text)


# ELŐZETES ISMERET: felhasználói input és típuskonverzió
# Az input() mindig szöveget ad vissza, ezért az ID-t int-té kell alakítani.
def update_status(config):
    try:
        device_id = int(input("Add meg az eszköz ID-ját: "))
        new_status = input("Add meg az új állapotot: ")

        for device in config:
            if device["id"] == device_id:
                device["status"] = new_status
                print("Állapot módosítva.")
                return

        print("Nincs ilyen azonosítójú eszköz.")

    except ValueError:
        # ValueError akkor keletkezik, ha az ID helyére nem számot írnak.
        print("Hibás ID. Számot kell megadni.")


# ELŐZETES ISMERET: validáció
# A program ellenőrzi, hogy a kötelező mezők értelmesek-e.
def add_new_device(config):
    name = input("Eszköz neve: ")
    device_type = input("Típus sensor/actuator: ")
    room = input("Helyiség: ")
    status = input("Kezdő állapot: ")

    if name == "":
        print("Az eszköz neve nem lehet üres.")
        return

    if device_type not in ["sensor", "actuator"]:
        print("A típus csak sensor vagy actuator lehet.")
        return

    new_id = max(device["id"] for device in config) + 1

    new_device = {
        "id": new_id,
        "name": name,
        "type": device_type,
        "room": room,
        "status": status
    }

    config.append(new_device)
    print("Új eszköz hozzáadva.")


# ELŐZETES ISMERET: menüvezérelt program
# A while True ciklus addig fut, amíg a felhasználó a kilépést nem választja.
def main():
    config = load_config()

    while True:
        print("\n--- Smart Home konfigurációkezelő ---")
        print("1. Eszközök listázása")
        print("2. Eszköz állapotának módosítása")
        print("3. Új eszköz hozzáadása")
        print("4. Mentés")
        print("0. Kilépés")

        choice = input("Választás: ")

        if choice == "1":
            list_devices(config)

        elif choice == "2":
            update_status(config)

        elif choice == "3":
            add_new_device(config)

        elif choice == "4":
            save_config(config)
            print("Konfiguráció mentve.")

        elif choice == "0":
            save_config(config)
            print("Kilépés. A konfiguráció mentve.")
            break

        else:
            print("Érvénytelen menüpont.")


# ELŐZETES ISMERET: főprogram védelme
# Így a main() csak közvetlen futtatáskor indul el, importáláskor nem.
if __name__ == "__main__":
    main()
```
