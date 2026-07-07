greenhouse_devices = [
    {"id": 1, "name": "Humidity Sensor", "type": "sensor", "zone": "north", "status": "active"},
    {"id": 2, "name": "Soil Moisture Sensor", "type": "sensor", "zone": "south", "status": "active"},
    {"id": 3, "name": "Water Pump", "type": "actuator", "zone": "south", "status": "off"},
    {"id": 4, "name": "Ventilation Fan", "type": "actuator", "zone": "central", "status": "off"},
    {"id": 5, "name": "Light Sensor", "type": "sensor", "zone": "roof", "status": "active"},
    {"id": 6, "name": "Automatic Shade", "type": "actuator", "zone": "roof", "status": "open"}
]


def list_devices(device_list):
    print("Összes eszköz:")
    for device in device_list:
        print(f"  ID: {device['id']} | Név: {device['name']} | Típus: {device['type']} | Zóna: {device['zone']}")


def list_sensors(device_list):
    print("Szenzorok:")
    for device in device_list:
        if device["type"] == "sensor":
            print(f"  ID: {device['id']} | Név: {device['name']} | Zóna: {device['zone']}")


def list_actuators(device_list):
    print("Aktuátorok:")
    for device in device_list:
        if device["type"] == "actuator":
            print(f"  ID: {device['id']} | Név: {device['name']} | Zóna: {device['zone']}")


def find_device_by_id(device_list, device_id):
    for device in device_list:
        if device["id"] == device_id:
            return device
    return None


def count_devices_by_zone(device_list):
    counts = {}
    for device in device_list:
        zone = device["zone"]
        counts[zone] = counts.get(zone, 0) + 1
    return counts


def add_device(device_list, name, device_type, zone, status):
    new_id = max(device["id"] for device in device_list) + 1
    new_device = {"id": new_id, "name": name, "type": device_type, "zone": zone, "status": status}
    device_list.append(new_device)
    return new_device


# Eszközök listázása
list_devices(greenhouse_devices)
print()

# Csak szenzorok
list_sensors(greenhouse_devices)
print()

# Csak aktuátorok
list_actuators(greenhouse_devices)
print()

# Keresés ID alapján
found = find_device_by_id(greenhouse_devices, 3)
print(f"Eszköz ID=3: {found}")
not_found = find_device_by_id(greenhouse_devices, 99)
print(f"Eszköz ID=99: {not_found}")
print()

# Eszközök száma zónánként
zone_counts = count_devices_by_zone(greenhouse_devices)
print("Eszközök száma zónánként:")
for zone, count in zone_counts.items():
    print(f"  {zone}: {count} eszköz")
print()

# Új eszköz hozzáadása
add_device(greenhouse_devices, "Temperature Sensor", "sensor", "central", "active")
print("Új eszköz hozzáadása után:")
list_devices(greenhouse_devices)
