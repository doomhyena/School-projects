import json

CONFIG_FILE = "smart_home_config.json"

default_config = [
    {"id": 1, "name": "Smart Lamp", "type": "actuator", "room": "living_room", "status": "off"},
    {"id": 2, "name": "Motion Detector", "type": "sensor", "room": "hall", "status": "inactive"},
    {"id": 3, "name": "Smart Door", "type": "actuator", "room": "entrance", "status": "locked"},
    {"id": 4, "name": "Temperature Meter", "type": "sensor", "room": "bedroom", "value": 22.5}
]

def save_config(config):
    with open(CONFIG_FILE, "w", encoding="utf-8") as file:
        json.dump(config, file, indent=4, ensure_ascii=False)

def load_config():
    try:
        with open(CONFIG_FILE, "r", encoding="utf-8") as file:
            return json.load(file)
    except FileNotFoundError:
        print("A konfigurációs fájl nem található. Alapértelmezett fájl létrehozása.")
        save_config(default_config)
        return default_config.copy()
    
    except json.JSONDecodeError:
        print("Hibás JSON-fájl. Alapértelmezett konfiguráció betöltése.")
        return default_config.copy()
    
def list_devices(config):
    print("\n---Eszközlista---")

    for device in config:
        text = f"{device['id']}. {device['name']} | {device['type']} | {device['room']}"

        if "status" in device:
            text += f" | állapot: {device['status']}"
        
        if "value" in device:
            text += f" | érték: {device['value']}"

        print(text)

def update_status(config):
    try:
        device_id = int(input("Add meg az eszköz ID-ját: "))
        new_status = input("Add meg az új állapotot: ")

        for device in config:
            if device['id'] == device_id:
                device['status'] = new_status
                print("Állapot módosítva.")
                return
        print("Nincs ilyen ID-jú eszköz.")
    except ValueError:
        print("Hibás ID. Számot kell megadni.")

def add_new_device(config):
    name = input("Eszköz neve: ")
    if name == "":
        print("Az eszköz neve nem lehet üres.")
        return
    
    device_type = input("Típus (sensor/actuator): ")
    if device_type not in ["sensor", "actuator"]:
        print("A típus csak sensor vagy actuator lehet.")
        return

    room = input("Helyiség: ")
    status = input("Kezdő állapot: ")

    new_id = max(device['id'] for device in config) + 1

    new_device = {
        "id": new_id,
        "name": name,
        "type": device_type,
        "room": room,
        "status": status
    }

    config.append(new_device)
    print("Új eszköz hozzáadva.")

    

def main():
    config = load_config()

    while True:
        print("\n--- Smart Home konfig menedzser ---")
        print("1. Eszközök listázása")
        print("2. Eszköz állapot módosítása")
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
            print("Kilépés. Konfiguráció mentve.")
            break
        else:
            print("Érvénytelen menüpont.")

if __name__ == "__main__":
    main()