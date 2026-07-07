import json

CONFIG_FILE = "greenhouse_config.json"

default_config = [
    {"id": 1, "name": "Humidity Sensor", "type": "sensor", "zone": "north", "status": "active"},
    {"id": 2, "name": "Soil Moisture Sensor", "type": "sensor", "zone": "south", "status": "active"},
    {"id": 3, "name": "Water Pump", "type": "actuator", "zone": "south", "status": "off"},
    {"id": 4, "name": "Ventilation Fan", "type": "actuator", "zone": "central", "status": "off"}
]


def save_config(config):
    with open(CONFIG_FILE, "w", encoding="utf-8") as f:
        json.dump(config, f, indent=2, ensure_ascii=False)
    print("Konfiguráció elmentve.")


def load_config():
    try:
        with open(CONFIG_FILE, "r", encoding="utf-8") as f:
            return json.load(f)
    except FileNotFoundError:
        print("Konfigurációs fájl nem található, alapértelmezett konfiguráció létrehozva.")
        save_config(default_config)
        return default_config
    except json.JSONDecodeError:
        print("HIBA: A JSON-fájl hibás formátumú. Alapértelmezett konfiguráció használata.")
        return default_config


def list_devices(config):
    print(f"{'ID':<5} {'Név':<25} {'Típus':<12} {'Zóna':<10} {'Állapot'}")
    print("-" * 65)
    for device in config:
        print(f"{device['id']:<5} {device['name']:<25} {device['type']:<12} {device['zone']:<10} {device['status']}")


def update_status(config):
    try:
        device_id = int(input("Eszköz ID-ja: "))
    except ValueError:
        print("HIBA: Az ID csak szám lehet.")
        return

    device = next((d for d in config if d["id"] == device_id), None)
    if device is None:
        print(f"HIBA: Nincs {device_id} ID-jú eszköz.")
        return

    new_status = input("Új állapot: ").strip()
    device["status"] = new_status
    print(f"'{device['name']}' állapota módosítva: {new_status}")


def add_new_device(config):
    name = input("Eszköz neve: ").strip()
    if not name:
        print("HIBA: Az eszköz neve nem lehet üres.")
        return

    device_type = input("Típus (sensor/actuator): ").strip()
    if device_type not in ("sensor", "actuator"):
        print("HIBA: A típus csak 'sensor' vagy 'actuator' lehet.")
        return

    zone = input("Zóna: ").strip()
    status = input("Állapot: ").strip()

    new_id = max(d["id"] for d in config) + 1 if config else 1
    config.append({"id": new_id, "name": name, "type": device_type, "zone": zone, "status": status})
    print(f"Új eszköz hozzáadva (ID: {new_id}).")


def main():
    config = load_config()

    while True:
        print()
        print("=== Okos üvegház - Eszközkezelő ===")
        print("1. Eszközök listázása")
        print("2. Eszköz állapotának módosítása")
        print("3. Új eszköz hozzáadása")
        print("4. Mentés")
        print("0. Kilépés")
        choice = input("Választás: ").strip()

        if choice == "1":
            print()
            list_devices(config)
        elif choice == "2":
            update_status(config)
        elif choice == "3":
            add_new_device(config)
        elif choice == "4":
            save_config(config)
        elif choice == "0":
            save_config(config)
            print("Kilépés.")
            break
        else:
            print("Érvénytelen választás.")


main()
