import requests

BASE_URL = "https://localhost:8000"

def safe_json(response):
    try: 
        return response.json()
    except requests.exceptions.JSONDecodeError:
        print("Hiba: A szerver válasza nem érvényes JSON formátumú.")


def get_all_devices():
    try:
        respons = requests.get(f"{BASE_URL}/devices", timeout=5)

        if respons.status_code == 200:
            data = respons.json()
            if data is not None:
                return data
            return []
        
        print(f"Hiba: Az eszközlista lekérdezése sikertelen. Státuszkód: {respons.status_code}")
        return []
    
    except requests.exceptions.ConnectionError:
        print("Hiba: nem sikerült kapcsolódni a szerverhez.")
        return []
    
    except requests.exceptions.Timeout:
        print("Hiba: A kérés időtúllépés miatt megszakadt.")
        return []
    
    except requests.exceptions.RequestException as error:
        print(f"Hálózati hiba történt: {error}")
        return []
    
def print_devices(devices):
    print("Összes IoT-eszköz: ")

    if not devices:
        print("Nincs megejelníthető eszköz.")
        return
    
    for device in devices:
        device_id = device.get("id", "-")
        name = device.get("name", "ismeretlen")
        device_type = device.get("type", "ismeretlen")
        status = device.get("status", device-get("value", "nincs adat"))

def main():
    devices = get_all_devices()

    for device in devices:
        print(f"{device["id"]} - {device["name"]}")

if __name__ == "__main__":
    main()