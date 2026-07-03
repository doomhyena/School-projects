# Lista -> Egy adattípust tartalmazó lista (hőmérséklet értékek Celsius fokban)
temperature_values = [21.8, 22.1, 22.5, 23.0, 24.2, 25.1, 24.8, 23.6]

# Python -> Gyengén típusos nyelv, így a lista elemei különböző adattípusokat is tartalmazhatnak
#test = ["Alma", 'a', 1, 3.14, True]

#Python változók -> Gyengén típusos nyelv, így a változók különböző adattípusokat is tartalmazhatnak
#temp1 = temperature_values[0]
#print(temp1)
#temp1 = test[0]
#print(temp1)

# testlist = []

#print(temperature_values)
#print(test)

def calculate_average(values):
    if len(values) == 0:
        return 0

    return sum(values) / len(values)

#print(calculate_average(testlist))

def print_temperature_report(values):
    average = calculate_average(values)
    minimum = min(values)
    maximum = max(values)

    print("Hőmérsékleti adatok elemzése:")
    print(f"Átlaghőmérséklet: {average:.2f} °C")
    print(f"Minimum hőmérséklet: {minimum} °C")
    print(f"Maxcimum hőmérséklet: {maximum} °C")

    for value in values:
        category = classify_temperature(value)
        print(f"{value} °C -> {category}")
        if value > 24:
            print("\tFigyelmeztetés: Magas hőmérséklet!")

def classify_temperature(value):
    if value < 20:
        return "cold"
    elif value <= 24:
        return "normal"
    else:
        return "hot"
    
def should_turn_on_fan(values):
    average = calculate_average(values)

    return average > 24
    
if __name__ == "__main__":
    print_temperature_report(temperature_values)

    if should_turn_on_fan(temperature_values):
        print("A ventillátor bekapcsol")
    else:
        print("A ventillátor kikapcsol")