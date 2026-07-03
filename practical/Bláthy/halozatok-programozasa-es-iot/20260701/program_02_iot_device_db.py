# list = ["elem", "Elem", "elem"]
# Dictionary -> Szótár (label): (value)
devices = [
    {"id": 1, "name": "Smart Lamp", "type": "actuator", "room": "living_room", "status": "off"},
    {"id": 2, "name": "Motion Detector", "type": "sensor", "room": "hall", "status": "inactive"},
    {"id": 3, "name": "Smart Door", "type": "actuator", "room": "entrance", "status": "locked"},
    {"id": 4, "name": "Temperature Meter", "type": "sensor", "room": "bedroom", "value": 22.5},
    {"id": 5, "name": "Lawn Sprinkler", "type": "actuator", "room": "garden", "status": "off"},
    {"id": 6, "name": "Wind Detector", "type": "sensor", "room": "garden", "status": "inactive"}
]

def list_devices(device_list):
    print("IoT-eszköz lista:")

    for device in device_list:
        print(f"{device['id']}. {device['name']} - {device['type']} - {device['room']}")

def list_by_type(device_list, device_type):
    print(f"\n{device_type.capitalize()} típusú eszközök:")

    for device in device_list:
        if device['type'] == device_type:
            print(f"{device['id']}. {device['name']} - {device['room']}")

def find_device_by_id(device_list, device_id):
    for device in device_list:
        if device['id'] == device_id:
            return device
        
    return None

def count_device_by_room(device_list):
    room_counter = {}

    for device in device_list:
        room = device['room']

        if room in room_counter:
            room_counter[room] += 1
        else:
            room_counter[room] = 1
        # print(room_counter)
    return room_counter

def add_device(device_list, name, device_type, room, status="off"):
    new_id = max(device['id'] for device in device_list) + 1

    new_device = {
        "id": new_id,
        "name": name,
        "type": device_type,
        "room": room,
        "status": status
    }

    device_list.append(new_device)
    return new_device

if __name__ == "__main__":
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
        print("Nincs ilyen ID-jű eszköz!")

    # print(count_device_by_room(devices))
    print("\nEszközök száma helyiségenként:")
    room_counts = count_device_by_room(devices)

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

    print("\nEszközök száma helyiségenként:")
    room_counts = count_device_by_room(devices)

    for room, count in room_counts.items():
        print(f"{room}: {count} db")