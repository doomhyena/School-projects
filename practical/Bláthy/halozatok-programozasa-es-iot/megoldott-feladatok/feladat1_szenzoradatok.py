humidity_values = [42, 45, 47, 51, 56, 62, 67, 70, 64, 58]


def classify_humidity(value):
    if value < 40:
        return "low"
    elif value <= 65:
        return "normal"
    else:
        return "high"


def should_turn_on_ventilation(values):
    return sum(values) / len(values) > 60


# 1. Átlagos páratartalom
average = sum(humidity_values) / len(humidity_values)
print(f"Átlagos páratartalom: {average:.1f}%")

# 2. Legalacsonyabb és legmagasabb érték
print(f"Legalacsonyabb érték: {min(humidity_values)}%")
print(f"Legmagasabb érték: {max(humidity_values)}%")

# 3. Figyelmeztetés 65% felett
print()
for value in humidity_values:
    if value > 65:
        print(f"FIGYELMEZTETÉS: Magas páratartalom! ({value}%)")

# 4. Figyelmeztetés 40% alatt
for value in humidity_values:
    if value < 40:
        print(f"FIGYELMEZTETÉS: Alacsony páratartalom! ({value}%)")

# 6. Mérési értékek besorolással
print()
print("Mérési értékek és besorolásuk:")
for value in humidity_values:
    classification = classify_humidity(value)
    print(f"  {value}% -> {classification}")

# 8. Szellőztetés szükségessége
print()
if should_turn_on_ventilation(humidity_values):
    print("Be kell kapcsolni a szellőztetést.")
else:
    print("Nem szükséges a szellőztetés bekapcsolása.")
