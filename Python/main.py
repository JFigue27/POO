from car import Car
from account import Account

if __name__ == "__main__":
    print("Hola Mundo!!")

    car = Car("Honda Accord", Account("Jose Jaime Figueroa", "JJFIGU31654"))
    print(vars(car))
    print(vars(car.driver))
