greenhouse_state = {
    "soil_moisture": 28,
    "temperature": 31.5,
    "light_level": 850,
    "door": "closed",
    "time_of_day": "day",
    "water_pump": "off",
    "fan": "off",
    "shade": "open",
    "warning_light": "off"
}


def apply_rules(state):
    new_state = state.copy()
    messages = []

    if new_state["soil_moisture"] < 30:
        new_state["water_pump"] = "on"
        messages.append("Vízpumpa bekapcsolva (alacsony talajnedvesség).")

    if new_state["soil_moisture"] > 60:
        new_state["water_pump"] = "off"
        messages.append("Vízpumpa kikapcsolva (magas talajnedvesség).")

    if new_state["temperature"] > 30:
        new_state["fan"] = "on"
        messages.append("Ventilátor bekapcsolva (magas hőmérséklet).")

    if new_state["temperature"] < 24:
        new_state["fan"] = "off"
        messages.append("Ventilátor kikapcsolva (alacsony hőmérséklet).")

    if new_state["light_level"] > 800:
        new_state["shade"] = "closed"
        messages.append("Árnyékoló bezárva (erős fény).")

    if new_state["light_level"] < 400:
        new_state["shade"] = "open"
        messages.append("Árnyékoló kinyitva (gyenge fény).")

    if new_state["time_of_day"] == "night" and new_state["door"] == "open":
        new_state["warning_light"] = "on"
        messages.append("Figyelmeztető fény bekapcsolva (éjszaka, ajtó nyitva).")

    return new_state, messages


print("Eredeti állapot:")
for key, value in greenhouse_state.items():
    print(f"  {key}: {value}")

new_state, messages = apply_rules(greenhouse_state)

print()
print("Alkalmazott szabályok:")
for msg in messages:
    print(f"  - {msg}")

print()
print("Új állapot:")
for key, value in new_state.items():
    print(f"  {key}: {value}")

print()
print("Eredeti állapot változatlan maradt:")
for key, value in greenhouse_state.items():
    print(f"  {key}: {value}")
