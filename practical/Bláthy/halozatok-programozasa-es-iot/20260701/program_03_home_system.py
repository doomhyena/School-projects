home_state = {
    "motion": True,
    "temperature": 26.3,
    "door": "locked",
    "lamp": "off",
    "fan": "off"
}

def apply_rules(original_state):
    state = original_state.copy()

    messages = []

    if state['motion']:
        state['lamp'] = 'on'
        messages.append("Mozgás érzékelve: lámpa bekapcsolva.")
    else:
        state['lamp'] = 'off'
        messages.append("Nincsen mozgás: lámpa kikapcsolva.")
    
    if state['temperature'] > 25:
        state['fan'] = 'on'
        messages.append("A hőmérséklet 25 °C felett van: ventillátor bekapcsolva.")
    elif state['temperature'] < 22:
        state['fan'] = 'off'
        messages.append("A hőmérséklet 22 °C alatt van: ventillátor kikapcsolva.")
    else:
        messages.append("A hőmérséklet normál tartományban van.")

    if state['motion'] and state['door'] == 'locked':
        messages.append("Biztonsági figyelmeztetés: mozgás érzékelhető zárt ajtó mellett.")

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