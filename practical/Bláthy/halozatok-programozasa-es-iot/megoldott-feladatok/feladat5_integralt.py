import json

sensor_data = {
    "temperature_values": [25.5, 26.8, 29.1, 31.2, 32.0],
    "humidity_values": [55, 58, 63, 69, 72],
    "soil_moisture_values": [35, 32, 29, 27, 25]
}

greenhouse_state = {
    "water_pump": "off",
    "fan": "off",
    "shade": "open",
    "warning_light": "off"
}

STATE_FILE = "greenhouse_state.json"


def average(values):
    return sum(values) / len(values)


# 1. Átlagok kiszámítása
avg_temperature = average(sensor_data["temperature_values"])
avg_humidity = average(sensor_data["humidity_values"])
avg_soil_moisture = average(sensor_data["soil_moisture_values"])

print(f"Átlagos hőmérséklet:   {avg_temperature:.1f} °C")
print(f"Átlagos páratartalom:  {avg_humidity:.1f}%")
print(f"Átlagos talajnedvesség: {avg_soil_moisture:.1f}%")
print()

# 2. Ventilátor bekapcsolása ha hőmérséklet > 30 °C
if avg_temperature > 30:
    greenhouse_state["fan"] = "on"
    print("Ventilátor bekapcsolva (magas hőmérséklet).")

# 3. Figyelmeztetés ha páratartalom > 65%
if avg_humidity > 65:
    print("FIGYELMEZTETÉS: Magas páratartalom!")

# 4. Vízpumpa bekapcsolása ha talajnedvesség < 30%
if avg_soil_moisture < 30:
    greenhouse_state["water_pump"] = "on"
    print("Vízpumpa bekapcsolva (alacsony talajnedvesség).")

# 5. Figyelmeztető fény ha egyszerre magas a hőmérséklet és a páratartalom
if avg_temperature > 30 and avg_humidity > 65:
    greenhouse_state["warning_light"] = "on"
    print("Figyelmeztető fény bekapcsolva (magas hőmérséklet és páratartalom).")

# 6. Új állapot kiírása
print()
print("Új üvegház állapot:")
for key, value in greenhouse_state.items():
    print(f"  {key}: {value}")

# 7. Mentés JSON-fájlba
with open(STATE_FILE, "w", encoding="utf-8") as f:
    json.dump(greenhouse_state, f, indent=2, ensure_ascii=False)
print(f"\nÁllapot elmentve: {STATE_FILE}")

# 8. Visszaolvasás és kiírás
with open(STATE_FILE, "r", encoding="utf-8") as f:
    loaded_state = json.load(f)

print(f"\nVisszaolvasott állapot ({STATE_FILE}):")
for key, value in loaded_state.items():
    print(f"  {key}: {value}")
